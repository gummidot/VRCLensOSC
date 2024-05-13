using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Numerics;
using System.Windows.Forms;
using Com.Okmer.GameController;
using Gma.System.MouseKeyHook;
using Rug.Osc;

namespace VRCLensOSC
{
    public partial class MainForm : Form
    {
        private OscSender osc;
        private OscReceiver oscr;
        private IKeyboardMouseEvents gh;

        public bool IsConnected = false;
        public const int Multi = 10000;
        public const float Div = 0.0001f;
        public const float DivPer = 0.01f;
        private int DroneKey = 1;
        private int DroneRotKey = 1;
        private bool DroneSwitch = false;
        private bool DroneTurbo = false;
        private const float DroneTurboStep = 1f;
        private int DefaultSldZoom;
        private bool DroneSpeedToggle = false;
        private bool FocusApToggle = false;
        private bool ZoomToggle = false;

        private XBoxController controller;
        private int controllerIndex = 1;

        public enum DroneFeatureToggle
        {
            Reset = 0,
            FocusPeakingZebra = 1,
            DoF = 11,
            AvatarAutoFocus = 13,
            Move = 212,
            PivotMove = 214,
            DropPivot = 253
        }

        // Custom feature toggles for VRCL_Custom/FeatureToggle
        public enum CustomFeatureToggle
        {
            Reset = 0,
            DoFOff = 11,
            Move = 212
        }

        // Qadesh Dolly
        public const string QDollyParamChairMovement = "ChairMovement";
        public const string QDollyParamRedChairSpeed = "RedChairSpeed";

        private bool QDollyChairMovement = false;

        public MainForm()
        {
            InitializeComponent();
            osc = new OscSender(IPAddress.Parse("127.0.0.1"), 0, 9000);
            oscListener.DoWork += new DoWorkEventHandler(OSCRECEIVE);
            this.DefaultSldZoom = this.sldZoom.Value;
            RefreshControllerList();

            gh = Hook.GlobalEvents();
            gh.KeyDown += GlobalKeyDownShortkey;
        }
        ~MainForm()
        {
            gh.KeyDown -= GlobalKeyDownShortkey;
            gh.KeyDown -= GlobalKeyDown;
            gh.KeyUp -= GlobalKeyUp;
            gh.Dispose();
        }

        public void OSCRECEIVE(object sender, DoWorkEventArgs e)
        {
            string[] packet;
            
            while(oscr.State != OscSocketState.Closed)
            {
                if (oscr.State == OscSocketState.Connected)
                {
                    try
                    {
                        packet = oscr.Receive().ToString().Split(',');
                        switch (packet[0])
                        {
                            case "/avatar/parameters/VRCLZoomRadial":
                                if (sldZoom.InvokeRequired) sldZoom.Invoke((MethodInvoker)delegate { sldZoom.Value = pkt2sld(packet[1]); });
                                else sldZoom.Value = pkt2sld(packet[1]);
                                if (lbZoomPer.InvokeRequired) lbZoomPer.Invoke((MethodInvoker)delegate { lbZoomPer.Text = Math.Round(sldZoom.Value * DivPer) + "%"; });
                                else lbZoomPer.Text = Math.Round(sldZoom.Value * DivPer) + "%";
                                break;
                            case "/avatar/parameters/VRCLExposureRadial":
                                if (sldEV.InvokeRequired) sldEV.Invoke((MethodInvoker)delegate { sldEV.Value = pkt2sld(packet[1]); });
                                else sldEV.Value = pkt2sld(packet[1]);
                                if (lbEV.InvokeRequired) lbEV.Invoke((MethodInvoker)delegate { lbEV.Text = Math.Round(sldEV.Value * DivPer) + "%"; });
                                else lbEV.Text = Math.Round(sldEV.Value * DivPer) + "%";
                                break;
                            case "/avatar/parameters/VRCLApertureRadial":
                                if (sldAp.InvokeRequired) sldAp.Invoke((MethodInvoker)delegate { sldAp.Value = pkt2sld(packet[1]); });
                                else sldAp.Value = pkt2sld(packet[1]);
                                if (lbApPer.InvokeRequired) lbApPer.Invoke((MethodInvoker)delegate { lbApPer.Text = Math.Round(sldAp.Value * DivPer) + "%"; });
                                else lbApPer.Text = Math.Round(sldAp.Value * DivPer) + "%";
                                break;
                            case "/avatar/parameters/VRCLFocusRadial":
                                if (sldFocus.InvokeRequired) sldZoom.Invoke((MethodInvoker)delegate { sldFocus.Value = pkt2sld(packet[1]); });
                                else sldFocus.Value = pkt2sld(packet[1]);
                                if (lbFocus.InvokeRequired) lbFocus.Invoke((MethodInvoker)delegate { lbFocus.Text = Math.Round(sldFocus.Value * DivPer) + "%"; });
                                else lbFocus.Text = Math.Round(sldFocus.Value * DivPer) + "%";
                                break;
                            case "/avatar/parameters/VRCLInt_DroneSpeed":
                                if (sldSpeed.InvokeRequired) sldSpeed.Invoke((MethodInvoker)delegate { sldSpeed.Value = pkt2sld(packet[1]); });
                                else sldSpeed.Value = pkt2sld(packet[1]);
                                if (lbSpeed.InvokeRequired) lbSpeed.Invoke((MethodInvoker)delegate { lbSpeed.Text = Math.Round(sldSpeed.Value * DivPer) + "%"; });
                                else lbSpeed.Text = Math.Round(sldSpeed.Value * DivPer) + "%";
                                break;
                            case "/avatar/parameters/" + QDollyParamRedChairSpeed:
                                if (sldQDollySpeed.InvokeRequired) sldQDollySpeed.Invoke((MethodInvoker)delegate { sldQDollySpeed.Value = pkt2sld(packet[1]); });
                                else sldQDollySpeed.Value = pkt2sld(packet[1]);
                                if (lbQDollySpeed.InvokeRequired) lbQDollySpeed.Invoke((MethodInvoker)delegate { lbQDollySpeed.Text = Math.Round(sldQDollySpeed.Value * DivPer) + "%"; });
                                else lbQDollySpeed.Text = Math.Round(sldQDollySpeed.Value * DivPer) + "%";
                                break;
                            case "/avatar/parameters/VRCLDroneSwitch":
                                if (int.TryParse(packet[1], out int n))
                                {
                                    if (n == 0)
                                    {
                                        if (btnDroneSwitch.InvokeRequired) btnDroneSwitch.Invoke((MethodInvoker)delegate { btnDroneSwitch.ForeColor = SystemColors.ControlText; });
                                        else btnDroneSwitch.ForeColor = SystemColors.ControlText;
                                    }
                                    else if (n == 6)
                                    {
                                        if (btnDroneSwitch.InvokeRequired) btnDroneSwitch.Invoke((MethodInvoker)delegate { btnDroneSwitch.ForeColor = Color.DarkRed; });
                                        else btnDroneSwitch.ForeColor = Color.DarkRed;
                                    }
                                }
                                break;
                        }
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }
        }

        private int pkt2sld(string pkt)
        {
            return (int)(double.Parse(pkt.Trim().Replace("f", "")) * Multi);
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (this.btnConnect.Text == "Connect")
            {
                if (Connect())
                {
                    this.IPAddr.Enabled = false;
                    this.Port.Enabled = false;
                    this.btnConnect.Text = "Disconnect";
                    IsConnected = true;
                }
            }
            else
            {
                osc.Close();
                oscr.Close();
                this.IPAddr.Enabled = true;
                this.Port.Enabled = true;
                this.btnConnect.Text = "Connect";
                IsConnected = false;
            }
        }
        
        private bool Connect()
        {
            try
            {
                IPAddress addr = IPAddress.Parse(this.IPAddr.Text);
                int port = (int)this.Port.Value;
                if (osc != null)
                {
                    osc.Close();
                    osc = new OscSender(addr, 0, port);
                    osc.Connect();

                    oscr = new OscReceiver(9001);
                    oscr.Connect();
                    oscListener.RunWorkerAsync();
                }

                return true;
            }
            catch (FormatException e)
            {
                MessageBox.Show("Please Enter Correct IP Address", "Wrong IP Address");
                Console.WriteLine(e.Message);
                return false;
            }
        }

        //------------------------------------------------------------------------------------

        private void SwitchDrone()
        {
            if (DroneSwitch)
            {
                osc.Send(new OscMessage("/avatar/parameters/VRCLDroneSwitch", 0));
                btnDroneSwitch.ForeColor = SystemColors.ControlText;
                DroneSwitch = false;
            }
            else
            {
                osc.Send(new OscMessage("/avatar/parameters/VRCLDroneSwitch", 6));
                btnDroneSwitch.ForeColor = Color.DarkRed;
                DroneSwitch = true;
            }
        }

        //------------------------------------------------------------------------------------

        private void RefreshControllerList()
        {
            this.controllerIndexList.Items.Clear();
            for (int i = 1; i <= 4; i++)
            {
                XBoxController controller = new XBoxController(userIndex: i);
                if (controller.Connection.Value)
                {
                    this.controllerIndexList.Items.Add($"Controller {i}");
                }
                controller.Close();
            }
            this.controllerIndexList.Items.Add("Disabled");
        }

        private void AssignHotKey()
        {
            gh.KeyDown += GlobalKeyDown;
            gh.KeyUp += GlobalKeyUp;

            if (controllerIndex > 0)
            {
                // Use slower poll rate than default 10 ms
                controller = new XBoxController(userIndex: controllerIndex, fastPollIntervalMilliseconds: 25);
                // Reasonable dead zone to prevent drifting
                controller.LeftThumbstick.DeadZone = 0.005f;
                controller.LeftThumbstick.ValueChanged += XBoxLeftThumbstickChanged;
            }
        }

        // Move drone horizontally
        private void XBoxLeftThumbstickChanged(object sender, ValueChangeArgs<Vector2> e)
        {
            float stepHMax = DroneTurbo ? DroneTurboStep : (float)stepMoveH.Value;
            float stepVMax = DroneTurbo ? DroneTurboStep : (float)stepMoveV.Value;
            float stepHMin = (float)stepMinMoveHV.Value;
            float stepVMin = (float)stepMinMoveHV.Value;
            float stepH = e.Value.X;
            float stepV = e.Value.Y;

            // Limit steps to min and max
            stepH = roundStep(e.Value.X, stepHMin, stepHMax, 0);
            stepV = roundStep(e.Value.Y, stepVMin, stepVMax, 0);
#if DEBUG
            Console.WriteLine($"Left thumbstick changed: x: {e.Value.X} ({stepH}), y: {e.Value.Y} ({stepV})");
#endif
            // Include controller input in DroneKey so other inputs don't reset VRCLFeatureToggle
            // while the controller is still being used. The key code doesn't matter as long as it's unique.
            int controllerDroneKey = 1336;
            if (e.Value.X != 0 || e.Value.Y != 0)
            {
                if (DroneKey % controllerDroneKey != 0) DroneKey *= controllerDroneKey;
                if (DroneKey != 1)
                {
                    // Not in the UI thread - don't update the UI
                    UseDrone((int)DroneFeatureToggle.Move, true, false);
                }
            }
            else
            {
                if (DroneKey % controllerDroneKey == 0)
                {
                    DroneKey /= controllerDroneKey;
                }
                if (DroneKey == 1)
                {
                    UseDrone((int)DroneFeatureToggle.Move, false, false);
                }
            }
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", stepH));
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", stepV));
        }

        // Round a step value to a nearest increment, limited by a min and max
        private float roundStep(float step, float min, float max, float increment)
        {

            float sign = Math.Sign(step);
            step = Math.Abs(step);
            if (increment > 0)
            {
                step = (float)Math.Round(step / increment) * increment;
            }
            step = Math.Max(Math.Min(step, max), min) * sign;
            return step;
        }

        void GlobalKeyDownShortkey(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Oemtilde:
                    if (e.Control)
                    {
                        this.ToggleShortkey();
                    }
                    break;
            }
        }

        void GlobalKeyDown(object sender, KeyEventArgs e)
        {
            float stepV = DroneTurbo ? DroneTurboStep : (float)stepMoveV.Value;
            float stepH = DroneTurbo ? DroneTurboStep : (float)stepMoveH.Value;
            float stepUpVUpDown = DroneTurbo ? DroneTurboStep : (float)stepMoveVUpDown.Value;

            // Key codes: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keys
            switch (e.KeyCode)
            {
                case Keys.OemMinus:
                    if (e.Shift)
                    {
                        ToggleZoom();
                    }
                    else
                    {
                        TimerZoomOut.Enabled = true;
                        btnZoomOut.Enabled = false;
                    }
                    break;
                case Keys.Oemplus:
                    if (e.Shift) {
                        OSCZoomReset();
                    } else {
                        TimerZoomIn.Enabled = true;
                        btnZoomIn.Enabled = false;
                    }
                    break;
                case Keys.OemOpenBrackets: TimerEVm.Enabled = true; btnEVm.Enabled = false; break;
                case Keys.Oem6: TimerEVp.Enabled = true; btnEVp.Enabled = false; break;
                case Keys.Oem1: TimerApShallow.Enabled = true; btnApShallow.Enabled = false; break;
                case Keys.Oem7: TimerApGrea.Enabled = true; btnApGreat.Enabled = false; break;
                case Keys.D9: TimerFocusClo.Enabled = true; btnFocusClo.Enabled = false; break;
                case Keys.D0: TimerFocusFur.Enabled = true; btnFocusFur.Enabled = false; break;
                // Experimental volume wheel controls (must disable default volume controls).
                // KeyUp fires immediately after KeyDown, so there's only a KeyDown action here.
                case Keys.VolumeDown:
                    switch (this.comboBoxVolume.Text)
                    {
                        case "Focus": FocusDecrease(); break;
                        case "Zoom": ZoomDecrease(); break;
                        case "Speed": SpeedDecrease(); break;
                    }
                    break;
                case Keys.VolumeUp:
                    switch (this.comboBoxVolume.Text)
                    {
                        case "Focus": FocusIncrease(); break;
                        case "Zoom": ZoomIncrease(); break;
                        case "Speed": SpeedIncrease(); break;
                    }
                    break;
                case Keys.OemPipe:
                    ToggleFocusAp();
                    break;
                case Keys.D7:
                    TimerSpeedSlower.Enabled = true;
                    btnSpeedSlower.Enabled = false;
                    break;
                case Keys.D8:
                    TimerSpeedFaster.Enabled = true;
                    btnSpeedFaster.Enabled = false;
                    break;
                case Keys.D6:
                case Keys.Scroll:
                    ToggleDroneSpeed();
                    break;
                case Keys.D3:
                    ToggleQDollyChairMovement();
                    break;
                case Keys.D1:
                    TimerQDollySpeedSlower.Enabled = true;
                    btnQDollySpeedSlower.Enabled = false;
                    break;
                case Keys.D2:
                    TimerQDollySpeedFaster.Enabled = true;
                    btnQDollySpeedFaster.Enabled = false;
                    break;
                case Keys.I:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", stepV));
                    if (DroneKey % (int)e.KeyCode != 0) DroneKey *= (int)e.KeyCode;
                    if (DroneKey != 1) {
                        if (e.Shift) {
                            UseDrone((int)DroneFeatureToggle.PivotMove, true);
                        } else {
                            UseDrone((int)DroneFeatureToggle.Move, true);
                        }
                    }
                    break;
                case Keys.J:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", -stepH));
                    if (DroneKey % (int)e.KeyCode != 0) DroneKey *= (int)e.KeyCode;
                    if (DroneKey != 1) {
                        if (e.Shift) {
                            UseDrone((int)DroneFeatureToggle.PivotMove, true);
                        } else {
                            UseDrone((int)DroneFeatureToggle.Move, true);
                        }
                    }
                    break;
                case Keys.K:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", -stepV));
                    if (DroneKey % (int)e.KeyCode != 0) DroneKey *= (int)e.KeyCode;
                    if (DroneKey != 1) {
                        if (e.Shift) {
                            UseDrone((int)DroneFeatureToggle.PivotMove, true);
                        } else {
                            UseDrone((int)DroneFeatureToggle.Move, true);
                        }
                    }
                    break;
                case Keys.L:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", stepH));
                    if (DroneKey % (int)e.KeyCode != 0) DroneKey *= (int)e.KeyCode;
                    if (DroneKey != 1) {
                        if (e.Shift) {
                            UseDrone((int)DroneFeatureToggle.PivotMove, true);
                        } else {
                            UseDrone((int)DroneFeatureToggle.Move, true);
                        }
                    }
                    break;
                case Keys.O:
                    osc.Send(new OscMessage("/avatar/parameters/VRCLDroneV", stepUpVUpDown));
                    if (DroneKey % (int)e.KeyCode != 0) DroneKey *= (int)e.KeyCode;
                    if (DroneKey != 1) {
                        if (e.Shift) {
                            UseDrone((int)DroneFeatureToggle.PivotMove, true);
                        } else {
                            UseDrone((int)DroneFeatureToggle.Move, true);
                        }
                    }
                    break;
                case Keys.U:
                    osc.Send(new OscMessage("/avatar/parameters/VRCLDroneV", -stepUpVUpDown));
                    if (DroneKey % (int)e.KeyCode != 0) DroneKey *= (int)e.KeyCode;
                    if (DroneKey != 1) {
                        if (e.Shift) {
                            UseDrone((int)DroneFeatureToggle.PivotMove, true);
                        } else {
                            UseDrone((int)DroneFeatureToggle.Move, true);
                        }
                    }
                    break;
                case Keys.Up:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", (float)stepRotV.Value));
                    if (DroneRotKey % (int)e.KeyCode != 0) DroneRotKey *= (int)e.KeyCode;
                    if (DroneRotKey != 1) UseDrone(213, true);
                    break;
                case Keys.Left:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", -(float)stepRotH.Value));
                    if (DroneRotKey % (int)e.KeyCode != 0) DroneRotKey *= (int)e.KeyCode;
                    if (DroneRotKey != 1) UseDrone(213, true);
                    break;
                case Keys.Down:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", -(float)stepRotV.Value));
                    if (DroneRotKey % (int)e.KeyCode != 0) DroneRotKey *= (int)e.KeyCode;
                    if (DroneRotKey != 1) UseDrone(213, true);
                    break;
                case Keys.Right:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", (float)stepRotH.Value));
                    if (DroneRotKey % (int)e.KeyCode != 0) DroneRotKey *= (int)e.KeyCode;
                    if (DroneRotKey != 1) UseDrone(213, true);
                    break;
                case Keys.RMenu:
                    DroneTurbo = !DroneTurbo;
                    // Disable hotkey for drone switch
                    // if(btnDroneSwitch.Enabled)
                    // {
                    //     btnDroneSwitch.Enabled = false;
                    //     SwitchDrone();
                    // }
                    break;
                case Keys.Insert:
                    if (e.Shift) {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle",  (int)DroneFeatureToggle.DropPivot));
                        btnDropPivot.Enabled = false;
                    }
                    else
                    {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 251));
                        btnDrop.Enabled = false;
                    }
                    break;
                case Keys.PageDown:
                    if (e.Control) {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 14));
                        btnOIS.Enabled = false;
                    } 
                    else
                    {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 250));
                        btnHandRotate.Enabled = false;
                    }
                    break;
                case Keys.Home:
                    if (e.Control) {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 254));
                        btnEnable.Enabled = false;
                    }
                    else if (e.Shift)
                    {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle",  (int)DroneFeatureToggle.AvatarAutoFocus));
                        btnAvAutoFocus.Enabled = false;
                    }
                    else if (e.Alt)
                    {
                        this.ToggleDoFOff();
                        btnDoFOff.Enabled = false;
                    }
                    else
                    {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (int)DroneFeatureToggle.DoF));
                        btnDoF.Enabled = false;
                    }
                    break;
                // Disable hotkey for Portrait toggle
                // case Keys.PageUp:
                //     osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 222));
                //     btnPortrait.Enabled = false;
                case Keys.PageUp:
                    if (e.Control) {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 241));
                        btnTrackself.Enabled = false;
                    } else {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 242));
                        btnTrackPivot.Enabled = false;
                    }
                    break;
                case Keys.Delete:
                    this.ToggleFocusPeaking();
                    btnFocusPeaking.Enabled = false;
                    break;
            }
        }

        private void GlobalKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.OemMinus: TimerZoomOut.Enabled = false; btnZoomOut.Enabled = true; break;
                case Keys.Oemplus:TimerZoomIn.Enabled = false; btnZoomIn.Enabled = true; break;
                case Keys.OemOpenBrackets: TimerEVm.Enabled = false; btnEVm.Enabled = true; break;
                case Keys.Oem6: TimerEVp.Enabled = false; btnEVp.Enabled = true; break;
                case Keys.Oem1: TimerApShallow.Enabled = false; btnApShallow.Enabled = true; break;
                case Keys.Oem7: TimerApGrea.Enabled = false; btnApGreat.Enabled = true; break;
                case Keys.D9: TimerFocusClo.Enabled = false; btnFocusClo.Enabled = true; break;
                case Keys.D0: TimerFocusFur.Enabled = false; btnFocusFur.Enabled = true; break;
                case Keys.D7:
                    TimerSpeedSlower.Enabled = false;
                    btnSpeedSlower.Enabled = true;
                    break;
                case Keys.D8:
                    TimerSpeedFaster.Enabled = false;
                    btnSpeedFaster.Enabled = true;
                    break;
                case Keys.D1:
                    TimerQDollySpeedSlower.Enabled = false;
                    btnQDollySpeedSlower.Enabled = true;
                    break;
                case Keys.D2:
                    TimerQDollySpeedFaster.Enabled = false;
                    btnQDollySpeedFaster.Enabled = true;
                    break;
                case Keys.I:
                    if (DroneKey % (int)e.KeyCode == 0)
                    {
                        DroneKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
                    }
                    if (DroneKey == 1) UseDrone((int)DroneFeatureToggle.Move, false);
                    break;
                case Keys.J:
                    if (DroneKey % (int)e.KeyCode == 0)
                    {
                        DroneKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
                    }
                    if (DroneKey == 1) UseDrone((int)DroneFeatureToggle.Move, false);
                    break;
                case Keys.K:
                    if (DroneKey % (int)e.KeyCode == 0)
                    {
                        DroneKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
                    }
                    if (DroneKey == 1) UseDrone((int)DroneFeatureToggle.Move, false);
                    break;
                case Keys.L:
                    if (DroneKey % (int)e.KeyCode == 0)
                    {
                        DroneKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
                    }
                    if (DroneKey == 1) UseDrone((int)DroneFeatureToggle.Move, false);
                    break;
                case Keys.O:
                    if (DroneKey % (int)e.KeyCode == 0)
                    {
                        DroneKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCLDroneV", 0f));
                    }
                    if (DroneKey == 1) UseDrone((int)DroneFeatureToggle.Move, false);
                    break;
                case Keys.U:
                    if (DroneKey % (int)e.KeyCode == 0)
                    {
                        DroneKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCLDroneV", 0f));
                    }
                    if (DroneKey == 1) UseDrone((int)DroneFeatureToggle.Move, false);
                    break;
                case Keys.Up:
                    if (DroneRotKey % (int)e.KeyCode == 0)
                    {
                        DroneRotKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
                    }
                    if (DroneRotKey == 1) UseDrone(213, false);
                    break;
                case Keys.Left:
                    if (DroneRotKey % (int)e.KeyCode == 0)
                    {
                        DroneRotKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
                    }
                    if (DroneRotKey == 1) UseDrone(213, false);
                    break;
                case Keys.Down:
                    if (DroneRotKey % (int)e.KeyCode == 0)
                    {
                        DroneRotKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
                    }
                    if (DroneRotKey == 1) UseDrone(213, false);
                    break;
                case Keys.Right:
                    if (DroneRotKey % (int)e.KeyCode == 0)
                    {
                        DroneRotKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
                    }
                    if (DroneRotKey == 1) UseDrone(213, false);
                    break;
                case Keys.RMenu:
                    // Disable drone switch
                    // btnDroneSwitch.Enabled = true;
                    break;
                case Keys.Insert:
                    if (e.Shift) {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
                        btnDropPivot.Enabled = true;
                    } else {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
                        btnDrop.Enabled = true;
                    }
                    break;
                case Keys.PageDown:
                    if (e.Control) {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
                        btnOIS.Enabled = true;
                    } else {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
                        btnHandRotate.Enabled = true;
                    }
                    break;
                case Keys.Home:
                    if (e.Control)
                    {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
                        btnEnable.Enabled = true;
                    }
                    else if (e.Shift)
                    {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
                        btnAvAutoFocus.Enabled = true;
                    }
                    else if (e.Alt)
                    {
                        this.CustomFeatureToggleReset();
                        btnDoFOff.Enabled = true;
                    }
                    else
                    {
                        // Reset both feature toggles in case a modifier key was unpressed before KeyUp
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
                        this.CustomFeatureToggleReset();
                        btnDoF.Enabled = true;
                    }
                    break;
                // Disable hotkey for Portrait toggle
                // case Keys.PageUp:
                //     osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
                //     btnPortrait.Enabled = true;
                case Keys.PageUp:
                    if (e.Control) {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
                        btnTrackself.Enabled = true;
                    } else {
                        osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
                        btnTrackPivot.Enabled = true;
                    }
                    break;
                case Keys.Delete:
                    this.DroneFeatureToggleReset();
                    btnFocusPeaking.Enabled = true;
                    break;
            }
        }
        private void DroneFeatureToggleReset()
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (int)DroneFeatureToggle.Reset));
        }
        private void CustomFeatureToggleReset()
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCL_Custom/FeatureToggle", (int)CustomFeatureToggle.Reset));
        }

        private void UseDrone(int t, bool b)
        {
            //t = 212, 213
            b = !b;

            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (b) ? 0 : t));

            // Set optional custom parameter to move drone without interruption from other toggles
            if (t == (int)DroneFeatureToggle.Move)
            {
                osc.Send(new OscMessage("/avatar/parameters/VRCL_Custom/DroneMove", (b) ? 0 : t));
            }

            btnDroneForward.Enabled = b;
            btnDroneBackward.Enabled = b;
            btnDroneHold.Enabled = b;
            btnDroneLeft.Enabled = b;
            btnDroneRight.Enabled = b;
            btnDroneRotUp.Enabled = b;
            btnDroneRotDown.Enabled = b;
            btnDroneRotHold.Enabled = b;
            btnDroneRotLeft.Enabled = b;
            btnDroneRotRight.Enabled = b;
        }

        // Like UseDrone(), but optionally does not update the UI
        private void UseDrone(int t, bool b, bool ui)
        {
            //t = 212, 213
            b = !b;

            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (b) ? 0 : t));

            // Set optional custom parameter to move drone without interruption from other toggles
            if (t == (int)DroneFeatureToggle.Move)
            {
                osc.Send(new OscMessage("/avatar/parameters/VRCL_Custom/DroneMove", (b) ? 0 : t));
            }

            if (ui)
            {
                btnDroneForward.Enabled = b;
                btnDroneBackward.Enabled = b;
                btnDroneHold.Enabled = b;
                btnDroneLeft.Enabled = b;
                btnDroneRight.Enabled = b;
                btnDroneRotUp.Enabled = b;
                btnDroneRotDown.Enabled = b;
                btnDroneRotHold.Enabled = b;
                btnDroneRotLeft.Enabled = b;
                btnDroneRotRight.Enabled = b;
            }
        }

        private void OSCZoom()
        {
            this.lbZoomPer.Text = ((int)Math.Round(this.sldZoom.Value * DivPer)).ToString() + "%";
            osc.Send(new OscMessage("/avatar/parameters/VRCLZoomRadial", this.sldZoom.Value * Div));
        }

        private void OSCZoomReset()
        {
            this.lbZoomPer.Text = ((int)Math.Round(this.DefaultSldZoom * DivPer)).ToString() + "%";
            osc.Send(new OscMessage("/avatar/parameters/VRCLZoomRadial", this.DefaultSldZoom * Div));
        }

        private void ToggleZoom()
        {
            this.ZoomToggle = !this.ZoomToggle;
            this.sldZoom.Value = (this.ZoomToggle ? (int)this.stepZoomA.Value : (int)this.stepZoomB.Value) * 100;
            this.OSCZoom();
        }

        private void OSCEV()
        {
            this.lbEV.Text = ((int)Math.Round(this.sldEV.Value * DivPer)).ToString() + "%";
            osc.Send(new OscMessage("/avatar/parameters/VRCLExposureRadial", this.sldEV.Value * Div));
        }

        private void OSCAp()
        {
            this.lbApPer.Text = ((int)Math.Round(this.sldAp.Value * DivPer)).ToString() + "%";
            osc.Send(new OscMessage("/avatar/parameters/VRCLApertureRadial", this.sldAp.Value * Div));

        }

        private void OSCFocus()
        {
            this.lbFocus.Text = ((int)Math.Round(this.sldFocus.Value * DivPer)).ToString() + "%";
            osc.Send(new OscMessage("/avatar/parameters/VRCLFocusRadial", this.sldFocus.Value * Div));
        }

        private void ToggleFocusAp()
        {
            this.FocusApToggle = !this.FocusApToggle;
            this.sldFocus.Value = (this.FocusApToggle ? (int)this.stepFocusA.Value : (int)this.stepFocusB.Value) * 100;
            this.sldAp.Value = (this.FocusApToggle ? (int)this.stepApertureA.Value : (int)this.stepApertureB.Value) * 100;
            this.OSCFocus();
            this.OSCAp();
        }

        private void OSCSpeed()
        {
            this.lbSpeed.Text = ((int)Math.Round(this.sldSpeed.Value * DivPer)).ToString() + "%";
            osc.Send(new OscMessage("/avatar/parameters/VRCLInt_DroneSpeed", this.sldSpeed.Value * Div));
        }

        private void ToggleDroneSpeed()
        {
            this.DroneSpeedToggle = !this.DroneSpeedToggle;
            this.sldSpeed.Value = (this.DroneSpeedToggle ? (int) this.stepSpeedA.Value : (int) this.stepSpeedB.Value) * 100;
            this.OSCSpeed();
        }

        private void OSCQDollySpeed()
        {
            this.lbQDollySpeed.Text = ((int)Math.Round(this.sldQDollySpeed.Value * DivPer)).ToString() + "%";
            osc.Send(new OscMessage($"/avatar/parameters/{QDollyParamRedChairSpeed}", this.sldQDollySpeed.Value * Div));
        }

        private void ToggleFocusPeaking()
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (int)DroneFeatureToggle.FocusPeakingZebra));
        }

        private void ToggleDoFOff()
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCL_Custom/FeatureToggle", (int)CustomFeatureToggle.DoFOff));
        }

        private void ToggleQDollyChairMovement()
        {
            QDollyChairMovement = !QDollyChairMovement;
            osc.Send(new OscMessage($"/avatar/parameters/{QDollyParamChairMovement}", QDollyChairMovement));
        }

        //------------------------------------------------------------------------------------

        #region Zoom Control

        private void sldZoom_Scroll(object sender, EventArgs e)
        {
            OSCZoom();
        }

        private void TimerZoomOut_Tick(object sender, EventArgs e)
        {
            ZoomDecrease();
        }

        private void btnZoomOut_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerZoomOut.Enabled = true;
        }

        private void btnZoomOut_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerZoomOut.Enabled = false;
        }
        private void btnZoomReset_MouseDown(object sender, MouseEventArgs e)
        {
            OSCZoomReset();
        }
        private void TimerZoomIn_Tick(object sender, EventArgs e)
        {
            ZoomIncrease();
        }
        private void ZoomIncrease()
        {
            int max = this.sldZoom.Maximum;
            if (this.sldZoom.Value + (int)this.stepZoom.Value > max) this.sldZoom.Value = max;
            else this.sldZoom.Value += (int)this.stepZoom.Value;
            OSCZoom();
        }

        private void ZoomDecrease()
        {
            int min = this.sldZoom.Minimum;
            if (this.sldZoom.Value - (int)this.stepZoom.Value < min) this.sldZoom.Value = min;
            else this.sldZoom.Value -= (int)this.stepZoom.Value;
            OSCZoom();
        }

        private void btnZoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerZoomIn.Enabled = true;
        }

        private void btnZoomIn_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerZoomIn.Enabled = false;
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Exposure Control

        private void sldEV_Scroll(object sender, EventArgs e)
        {
            OSCEV();
        }

        private void TimerEVm_Tick(object sender, EventArgs e)
        {
            if (this.sldEV.Value - (int)this.stepEV.Value < 0) this.sldEV.Value = 0;
            else this.sldEV.Value -= (int)this.stepEV.Value;
            OSCEV();
        }

        private void btnEVm_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerEVm.Enabled = true;
        }

        private void btnEVm_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerEVm.Enabled = false;
        }

        private void TimerEVp_Tick(object sender, EventArgs e)
        {
            if (this.sldEV.Value + (int)this.stepEV.Value > Multi) this.sldEV.Value = Multi;
            else this.sldEV.Value += (int)this.stepEV.Value;
            OSCEV();
        }

        private void btnEVp_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerEVp.Enabled = true;
        }

        private void btnEVp_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerEVp.Enabled = false;
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Aperture Control

        private void sldAp_Scroll(object sender, EventArgs e)
        {
            OSCAp();
        }

        private void TimerApShallow_Tick(object sender, EventArgs e)
        {
            int min = this.sldAp.Minimum;
            if (this.sldAp.Value - (int)this.stepAp.Value < min) this.sldAp.Value = min;
            else this.sldAp.Value -= (int)this.stepAp.Value;
            OSCAp();
        }

        private void btnApShallow_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerApShallow.Enabled = true;
        }

        private void btnApShallow_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerApShallow.Enabled = false;
        }

        private void TimerApGrea_Tick(object sender, EventArgs e)
        {
            int max = this.sldAp.Maximum;
            if (this.sldAp.Value + (int)this.stepAp.Value > max) this.sldAp.Value = max;
            else this.sldAp.Value += (int)this.stepAp.Value;
            OSCAp();
        }

        private void btnApGreat_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerApGrea.Enabled = true;
        }

        private void btnApGreat_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerApGrea.Enabled = false;
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Focus Control

        private void sldFocus_Scroll(object sender, EventArgs e)
        {
            OSCFocus();
        }

        private void TimerFocusClo_Tick(object sender, EventArgs e)
        {
            this.FocusDecrease();
        }

        private void btnFocusClo_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerFocusClo.Enabled = true;
        }

        private void btnFocusClo_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerFocusClo.Enabled = false;
        }

        private void TimerFocusFur_Tick(object sender, EventArgs e)
        {
            this.FocusIncrease();
        }

        private void FocusIncrease()
        {
            int max = this.sldFocus.Maximum;
            if (this.sldFocus.Value + (int)this.stepFocus.Value > max) this.sldFocus.Value = max;
            else this.sldFocus.Value += (int)this.stepFocus.Value;
            OSCFocus();
        }

        private void FocusDecrease()
        {
            int min = this.sldFocus.Minimum;
            if (this.sldFocus.Value - (int)this.stepFocus.Value < min) this.sldFocus.Value = min;
            else this.sldFocus.Value -= (int)this.stepFocus.Value;
            OSCFocus();
        }

        private void btnFocusFur_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerFocusFur.Enabled = true;
        }

        private void btnFocusFur_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerFocusFur.Enabled = false;
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Speed Control

        private void sldSpeed_Scroll(object sender, EventArgs e)
        {
            OSCSpeed();
        }

        private void TimerSpeedSlower_Tick(object sender, EventArgs e)
        {
            SpeedDecrease();
        }

        private void btnSpeedSlower_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerSpeedSlower.Enabled = true;
        }

        private void btnSpeedSlower_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerSpeedSlower.Enabled = false;
        }

        private void TimerSpeedFaster_Tick(object sender, EventArgs e)
        {
            SpeedIncrease();
        }

        private void btnSpeedFaster_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerSpeedFaster.Enabled = true;
        }

        private void btnSpeedFaster_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerSpeedFaster.Enabled = false;
        }

        private void SpeedDecrease()
        {
            if (this.sldSpeed.Value - (int)this.stepSpeed.Value < 0) this.sldSpeed.Value = 0;
            else this.sldSpeed.Value -= (int)this.stepSpeed.Value;
            OSCSpeed();
        }

        private void SpeedIncrease()
        {
            if (this.sldSpeed.Value + (int)this.stepSpeed.Value > Multi) this.sldSpeed.Value = Multi;
            else this.sldSpeed.Value += (int)this.stepSpeed.Value;
            OSCSpeed();
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Dolly Speed Control

        private void sldQDollySpeed_Scroll(object sender, EventArgs e)
        {
            OSCQDollySpeed();
        }

        private void TimerQDollySpeedSlower_Tick(object sender, EventArgs e)
        {
            if (this.sldQDollySpeed.Value - (int)this.stepQDollySpeed.Value < -Multi) this.sldQDollySpeed.Value = -Multi;
            else this.sldQDollySpeed.Value -= (int)this.stepQDollySpeed.Value;
            OSCQDollySpeed();
        }

        private void btnQDollySpeedSlower_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerQDollySpeedSlower.Enabled = true;
        }

        private void btnQDollySpeedSlower_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerQDollySpeedSlower.Enabled = false;
        }

        private void TimerQDollySpeedFaster_Tick(object sender, EventArgs e)
        {
            if (this.sldQDollySpeed.Value + (int)this.stepQDollySpeed.Value > Multi) this.sldQDollySpeed.Value = Multi;
            else this.sldQDollySpeed.Value += (int)this.stepQDollySpeed.Value;
            OSCQDollySpeed();
        }

        private void btnQDollySpeedFaster_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerQDollySpeedFaster.Enabled = true;
        }

        private void btnQDollySpeedFaster_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerQDollySpeedFaster.Enabled = false;
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Control Panel - Enable

        private void btnEnable_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 254));
        }

        private void btnEnable_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Control Panel - DoF

        private void btnDoF_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (int)DroneFeatureToggle.DoF));
        }

        private void btnDoF_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Control Panel - DoF

        private void btnAvAutoFocus_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (int)DroneFeatureToggle.AvatarAutoFocus));
        }

        private void btnAvAutoFocus_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Control Panel - OIS

        private void btnOIS_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 14));
        }

        private void btnOIS_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Control Panel - Portait

        private void btnPortrait_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 222));
        }

        private void btnPortrait_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Control Panel - Drop

        private void btnDrop_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 251));
        }

        private void btnDrop_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Control Panel - Drop

        private void btnDropPivot_MouseDown(object sender, MouseEventArgs e) {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle",  (int)DroneFeatureToggle.DropPivot));
        }

        private void btnDropPivot_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Control Panel - TrackSelf

        private void btnTrackself_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 241));
        }

        private void btnTrackself_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Control Panel - TrackPivot

        private void btnTrackPivot_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 242));
        }

        private void btnTrackPivot_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Control Panel - DC

        private void btnDC_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 224));
        }

        private void btnDC_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Control Panel - Drone Turbo

        private void btnDroneTurbo_MouseDown(object sender, MouseEventArgs e)
        {
            DroneTurbo = !DroneTurbo;
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Panel - Hand Rotate

        private void btnHandRotate_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 250));
        }

        private void btnHandRotate_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        #endregion

        //------------------------------------------------------------------------------------

        #region Drone Panels

        private void btnDroneForward_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", (float)stepMoveV.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (int)DroneFeatureToggle.Move));
        }

        private void BtnDroneBackward_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", -(float)stepMoveV.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (int)DroneFeatureToggle.Move));
        }
        private void btnDroneHold_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        private void btnDroneLeft_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", -(float)stepMoveH.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (int)DroneFeatureToggle.Move));
        }

        private void btnDroneRight_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", (float)stepMoveH.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (int)DroneFeatureToggle.Move));
        }

        private void btnDroneRotUp_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", (float)stepRotV.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 213));
        }

        private void btnDroneRotDown_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", -(float)stepRotV.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 213));
        }

        private void btnDroneRotHold_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        private void btnDroneRotLeft_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", -(float)stepRotH.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 213));
        }

        private void btnDroneRotRight_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", (float)stepRotH.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 213));
        }

        #endregion

        //------------------------------------------------------------------------------------

        private void btnShortkey_Click(object sender, EventArgs e)
        {
            this.ToggleShortkey();
        }

        private void ToggleShortkey()
        {
            if (btnShortkey.Text.Contains("Enable"))
            {
                AssignHotKey();
                btnShortkey.Text = btnShortkey.Text.Replace("Enable", "Disable");
                controllerIndexList.Enabled = false;
                controllerRefreshIdentifyBtn.Text = "Identify";
            }
            else
            {
                gh.KeyDown -= GlobalKeyDown;
                gh.KeyUp -= GlobalKeyUp;

                if (controller != null)
                {
                    controller.Close();
                }

                btnShortkey.Text = btnShortkey.Text.Replace("Disable", "Enable");
                controllerIndexList.Enabled = true;
                controllerRefreshIdentifyBtn.Text = "Refresh";
            }
        }

        private void btnDroneSwitch_Click(object sender, EventArgs e)
        {
            SwitchDrone();
        }

        private void controllerIndexList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string controller = this.controllerIndexList.Text;
            if (controller == "Disabled")
            {
                controllerIndex = -1;
            }
            else
            {
                // Controller 1, ..., Controller 4
                controllerIndex = Int32.Parse(controller.Split(' ')[1]);
            }
        }

        private void controllerRefreshIdentifyBtn_Click(object sender, EventArgs e)
        {
            if (controllerRefreshIdentifyBtn.Text == "Refresh")
            {
                RefreshControllerList();
            }
            else if (controller != null)
            {
                controller.LeftRumble.Rumble(0.25f, 500);
            }
        }

        private void btnFocusPeaking_MouseDown(object sender, MouseEventArgs e)
        {
            this.ToggleFocusPeaking();
        }
        private void btnDoFOff_MouseDown(object sender, MouseEventArgs e)
        {
            this.ToggleDoFOff();
        }

        // Generic handler for toggle buttons that require a feature toggle reset
        private void btnDroneFeatureToggleReset_MouseUp(object sender, MouseEventArgs e)
        {
            this.DroneFeatureToggleReset();
        }

        private void btnDroneSpeedToggle_Click(object sender, EventArgs e)
        {
            ToggleDroneSpeed();
        }

        private void btnToggleFocusAp_Click(object sender, EventArgs e)
        {
            ToggleFocusAp();
        }

        private void checkBoxLimitFocusAp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxLimitFocusAp.Checked)
            {
                this.sldFocus.Minimum = (int)Math.Min(this.stepFocusA.Value, this.stepFocusB.Value) * 100;
                this.sldFocus.Maximum = (int)Math.Max(this.stepFocusA.Value, this.stepFocusB.Value) * 100;
                this.sldAp.Minimum = (int)Math.Min(this.stepApertureA.Value, this.stepApertureB.Value) * 100;
                this.sldAp.Maximum = (int)Math.Max(this.stepApertureA.Value, this.stepApertureB.Value) * 100;
            }
            else
            {
                this.sldFocus.Minimum = 0;
                this.sldFocus.Maximum = 10000;
                this.sldAp.Minimum = 0;
                this.sldAp.Maximum = 10000;
            }
        }

        private void btnToggleZoom_Click(object sender, EventArgs e)
        {
            ToggleZoom();
        }

        private void checkBoxLimitZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxLimitZoom.Checked)
            {
                this.sldZoom.Minimum = (int)Math.Min(this.stepZoomA.Value, this.stepZoomB.Value) * 100;
                this.sldZoom.Maximum = (int)Math.Max(this.stepZoomA.Value, this.stepZoomB.Value) * 100;
            }
            else
            {
                this.sldZoom.Minimum = 0;
                this.sldZoom.Maximum = 10000;
            }
        }
    }
}