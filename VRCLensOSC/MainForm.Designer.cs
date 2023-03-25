namespace VRCLensOSC
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sldZoom = new System.Windows.Forms.TrackBar();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.lbZoomPer = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbZoomLen = new System.Windows.Forms.Label();
            this.stepZoom = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbEV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stepEV = new System.Windows.Forms.NumericUpDown();
            this.btnEVp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEVm = new System.Windows.Forms.Button();
            this.sldEV = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbApF = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbApPer = new System.Windows.Forms.Label();
            this.stepAp = new System.Windows.Forms.NumericUpDown();
            this.btnApGreat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnApShallow = new System.Windows.Forms.Button();
            this.sldAp = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lbFocus = new System.Windows.Forms.Label();
            this.stepFocus = new System.Windows.Forms.NumericUpDown();
            this.btnFocusFur = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnFocusClo = new System.Windows.Forms.Button();
            this.sldFocus = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stepMoveH = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDroneForward = new System.Windows.Forms.Button();
            this.btnDroneLeft = new System.Windows.Forms.Button();
            this.btnDroneBackward = new System.Windows.Forms.Button();
            this.btnDroneRight = new System.Windows.Forms.Button();
            this.btnDroneHold = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.stepMoveV = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDroneSwitch = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.stepMoveVUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPortrait = new System.Windows.Forms.Button();
            this.btnOIS = new System.Windows.Forms.Button();
            this.btnDoF = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnTrackself = new System.Windows.Forms.Button();
            this.btnDC = new System.Windows.Forms.Button();
            this.btnHandRotate = new System.Windows.Forms.Button();
            this.btnTrackPivot = new System.Windows.Forms.Button();
            this.btnAvAutoFocus = new System.Windows.Forms.Button();
            this.btnDroneTurbo = new System.Windows.Forms.Button();
            this.btnDropPivot = new System.Windows.Forms.Button();
            this.btnResetZoom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.stepRotV = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDroneRotUp = new System.Windows.Forms.Button();
            this.btnDroneRotLeft = new System.Windows.Forms.Button();
            this.btnDroneRotDown = new System.Windows.Forms.Button();
            this.btnDroneRotRight = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.stepRotH = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDroneRotHold = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.controllerRefreshIdentifyBtn = new System.Windows.Forms.Button();
            this.controllerIndexList = new System.Windows.Forms.ComboBox();
            this.btnShortkey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.NumericUpDown();
            this.IPAddr = new System.Windows.Forms.TextBox();
            this.TimerZoomIn = new System.Windows.Forms.Timer(this.components);
            this.TimerZoomOut = new System.Windows.Forms.Timer(this.components);
            this.TimerEVm = new System.Windows.Forms.Timer(this.components);
            this.TimerEVp = new System.Windows.Forms.Timer(this.components);
            this.TimerApShallow = new System.Windows.Forms.Timer(this.components);
            this.TimerApGrea = new System.Windows.Forms.Timer(this.components);
            this.TimerFocusClo = new System.Windows.Forms.Timer(this.components);
            this.TimerFocusFur = new System.Windows.Forms.Timer(this.components);
            this.oscListener = new System.ComponentModel.BackgroundWorker();
            this.lbVer = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.stepMinMoveHV = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sldZoom)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepZoom)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldEV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldAp)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldFocus)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMoveH)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMoveV)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMoveVUpDown)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepRotV)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepRotH)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMinMoveHV)).BeginInit();
            this.SuspendLayout();
            // 
            // sldZoom
            // 
            this.sldZoom.Location = new System.Drawing.Point(142, 8);
            this.sldZoom.Maximum = 10000;
            this.sldZoom.Name = "sldZoom";
            this.sldZoom.Size = new System.Drawing.Size(278, 45);
            this.sldZoom.TabIndex = 0;
            this.sldZoom.TabStop = false;
            this.sldZoom.Value = 1200;
            this.sldZoom.Scroll += new System.EventHandler(this.sldZoom_Scroll);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(72, 3);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(71, 53);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.Text = "Zoom Out\n( - )";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomOut_MouseDown);
            this.btnZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomOut_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoom";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(463, 3);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(72, 53);
            this.btnZoomIn.TabIndex = 3;
            this.btnZoomIn.Text = "Zoom In\n( + )";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomIn_MouseDown);
            this.btnZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomIn_MouseUp);
            // 
            // lbZoomPer
            // 
            this.lbZoomPer.AutoSize = true;
            this.lbZoomPer.Location = new System.Drawing.Point(417, 13);
            this.lbZoomPer.Name = "lbZoomPer";
            this.lbZoomPer.Size = new System.Drawing.Size(27, 13);
            this.lbZoomPer.TabIndex = 4;
            this.lbZoomPer.Text = "12%";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.lbZoomLen);
            this.panel.Controls.Add(this.stepZoom);
            this.panel.Controls.Add(this.btnZoomIn);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.lbZoomPer);
            this.panel.Controls.Add(this.btnZoomOut);
            this.panel.Controls.Add(this.sldZoom);
            this.panel.Location = new System.Drawing.Point(10, 59);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(632, 60);
            this.panel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Strength";
            // 
            // lbZoomLen
            // 
            this.lbZoomLen.AutoSize = true;
            this.lbZoomLen.Location = new System.Drawing.Point(417, 34);
            this.lbZoomLen.Name = "lbZoomLen";
            this.lbZoomLen.Size = new System.Drawing.Size(29, 13);
            this.lbZoomLen.TabIndex = 8;
            this.lbZoomLen.Text = "- mm";
            // 
            // stepZoom
            // 
            this.stepZoom.Location = new System.Drawing.Point(591, 18);
            this.stepZoom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stepZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepZoom.Name = "stepZoom";
            this.stepZoom.Size = new System.Drawing.Size(35, 20);
            this.stepZoom.TabIndex = 7;
            this.stepZoom.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbEV);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.stepEV);
            this.panel2.Controls.Add(this.btnEVp);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnEVm);
            this.panel2.Controls.Add(this.sldEV);
            this.panel2.Location = new System.Drawing.Point(10, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 60);
            this.panel2.TabIndex = 10;
            // 
            // lbEV
            // 
            this.lbEV.AutoSize = true;
            this.lbEV.Location = new System.Drawing.Point(417, 23);
            this.lbEV.Name = "lbEV";
            this.lbEV.Size = new System.Drawing.Size(27, 13);
            this.lbEV.TabIndex = 10;
            this.lbEV.Text = "50%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Strength";
            // 
            // stepEV
            // 
            this.stepEV.Location = new System.Drawing.Point(591, 18);
            this.stepEV.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stepEV.Name = "stepEV";
            this.stepEV.Size = new System.Drawing.Size(35, 20);
            this.stepEV.TabIndex = 7;
            this.stepEV.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnEVp
            // 
            this.btnEVp.Location = new System.Drawing.Point(463, 3);
            this.btnEVp.Name = "btnEVp";
            this.btnEVp.Size = new System.Drawing.Size(72, 53);
            this.btnEVp.TabIndex = 3;
            this.btnEVp.Text = "EV +\n( ] )";
            this.btnEVp.UseVisualStyleBackColor = true;
            this.btnEVp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEVp_MouseDown);
            this.btnEVp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEVp_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Exposure";
            // 
            // btnEVm
            // 
            this.btnEVm.Location = new System.Drawing.Point(72, 3);
            this.btnEVm.Name = "btnEVm";
            this.btnEVm.Size = new System.Drawing.Size(71, 53);
            this.btnEVm.TabIndex = 1;
            this.btnEVm.Text = "EV -\n( [ )";
            this.btnEVm.UseVisualStyleBackColor = true;
            this.btnEVm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEVm_MouseDown);
            this.btnEVm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEVm_MouseUp);
            // 
            // sldEV
            // 
            this.sldEV.Location = new System.Drawing.Point(142, 8);
            this.sldEV.Maximum = 10000;
            this.sldEV.Name = "sldEV";
            this.sldEV.Size = new System.Drawing.Size(278, 45);
            this.sldEV.TabIndex = 0;
            this.sldEV.TabStop = false;
            this.sldEV.Value = 5000;
            this.sldEV.Scroll += new System.EventHandler(this.sldEV_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbApF);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lbApPer);
            this.panel3.Controls.Add(this.stepAp);
            this.panel3.Controls.Add(this.btnApGreat);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnApShallow);
            this.panel3.Controls.Add(this.sldAp);
            this.panel3.Location = new System.Drawing.Point(10, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 60);
            this.panel3.TabIndex = 10;
            // 
            // lbApF
            // 
            this.lbApF.AutoSize = true;
            this.lbApF.Location = new System.Drawing.Point(417, 31);
            this.lbApF.Name = "lbApF";
            this.lbApF.Size = new System.Drawing.Size(16, 13);
            this.lbApF.TabIndex = 10;
            this.lbApF.Text = "-F";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(540, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Strength";
            // 
            // lbApPer
            // 
            this.lbApPer.AutoSize = true;
            this.lbApPer.Location = new System.Drawing.Point(417, 12);
            this.lbApPer.Name = "lbApPer";
            this.lbApPer.Size = new System.Drawing.Size(21, 13);
            this.lbApPer.TabIndex = 8;
            this.lbApPer.Text = "0%";
            // 
            // stepAp
            // 
            this.stepAp.Location = new System.Drawing.Point(591, 18);
            this.stepAp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stepAp.Name = "stepAp";
            this.stepAp.Size = new System.Drawing.Size(35, 20);
            this.stepAp.TabIndex = 7;
            this.stepAp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnApGreat
            // 
            this.btnApGreat.Location = new System.Drawing.Point(463, 3);
            this.btnApGreat.Name = "btnApGreat";
            this.btnApGreat.Size = new System.Drawing.Size(72, 53);
            this.btnApGreat.TabIndex = 3;
            this.btnApGreat.Text = "Greatest\n( \' )";
            this.btnApGreat.UseVisualStyleBackColor = true;
            this.btnApGreat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnApGreat_MouseDown);
            this.btnApGreat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnApGreat_MouseUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(3, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Aperture";
            // 
            // btnApShallow
            // 
            this.btnApShallow.Location = new System.Drawing.Point(72, 3);
            this.btnApShallow.Name = "btnApShallow";
            this.btnApShallow.Size = new System.Drawing.Size(71, 53);
            this.btnApShallow.TabIndex = 1;
            this.btnApShallow.Text = "Shallow\n( ; )";
            this.btnApShallow.UseVisualStyleBackColor = true;
            this.btnApShallow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnApShallow_MouseDown);
            this.btnApShallow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnApShallow_MouseUp);
            // 
            // sldAp
            // 
            this.sldAp.Location = new System.Drawing.Point(142, 8);
            this.sldAp.Maximum = 10000;
            this.sldAp.Name = "sldAp";
            this.sldAp.Size = new System.Drawing.Size(278, 45);
            this.sldAp.TabIndex = 0;
            this.sldAp.TabStop = false;
            this.sldAp.Scroll += new System.EventHandler(this.sldAp_Scroll);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.lbFocus);
            this.panel4.Controls.Add(this.stepFocus);
            this.panel4.Controls.Add(this.btnFocusFur);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.btnFocusClo);
            this.panel4.Controls.Add(this.sldFocus);
            this.panel4.Location = new System.Drawing.Point(10, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(632, 60);
            this.panel4.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(540, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Strength";
            // 
            // lbFocus
            // 
            this.lbFocus.AutoSize = true;
            this.lbFocus.Location = new System.Drawing.Point(417, 23);
            this.lbFocus.Name = "lbFocus";
            this.lbFocus.Size = new System.Drawing.Size(21, 13);
            this.lbFocus.TabIndex = 8;
            this.lbFocus.Text = "0%";
            // 
            // stepFocus
            // 
            this.stepFocus.Location = new System.Drawing.Point(591, 18);
            this.stepFocus.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stepFocus.Name = "stepFocus";
            this.stepFocus.Size = new System.Drawing.Size(35, 20);
            this.stepFocus.TabIndex = 7;
            this.stepFocus.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnFocusFur
            // 
            this.btnFocusFur.Location = new System.Drawing.Point(463, 3);
            this.btnFocusFur.Name = "btnFocusFur";
            this.btnFocusFur.Size = new System.Drawing.Size(72, 53);
            this.btnFocusFur.TabIndex = 3;
            this.btnFocusFur.Text = "Further\n( 0 )";
            this.btnFocusFur.UseVisualStyleBackColor = true;
            this.btnFocusFur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFocusFur_MouseDown);
            this.btnFocusFur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFocusFur_MouseUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(3, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Focus";
            // 
            // btnFocusClo
            // 
            this.btnFocusClo.Location = new System.Drawing.Point(72, 3);
            this.btnFocusClo.Name = "btnFocusClo";
            this.btnFocusClo.Size = new System.Drawing.Size(71, 53);
            this.btnFocusClo.TabIndex = 1;
            this.btnFocusClo.Text = "Closer\n( 9 )";
            this.btnFocusClo.UseVisualStyleBackColor = true;
            this.btnFocusClo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFocusClo_MouseDown);
            this.btnFocusClo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFocusClo_MouseUp);
            // 
            // sldFocus
            // 
            this.sldFocus.Location = new System.Drawing.Point(142, 8);
            this.sldFocus.Maximum = 10000;
            this.sldFocus.Name = "sldFocus";
            this.sldFocus.Size = new System.Drawing.Size(278, 45);
            this.sldFocus.TabIndex = 0;
            this.sldFocus.TabStop = false;
            this.sldFocus.Scroll += new System.EventHandler(this.sldFocus_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDroneForward, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDroneLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDroneBackward, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDroneRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDroneHold, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 190);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stepMoveH);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(3, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 56);
            this.panel1.TabIndex = 12;
            // 
            // stepMoveH
            // 
            this.stepMoveH.DecimalPlaces = 2;
            this.stepMoveH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepMoveH.Location = new System.Drawing.Point(2, 28);
            this.stepMoveH.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepMoveH.Name = "stepMoveH";
            this.stepMoveH.Size = new System.Drawing.Size(58, 20);
            this.stepMoveH.TabIndex = 1;
            this.stepMoveH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Left/Right";
            // 
            // btnDroneForward
            // 
            this.btnDroneForward.Location = new System.Drawing.Point(68, 3);
            this.btnDroneForward.Name = "btnDroneForward";
            this.btnDroneForward.Size = new System.Drawing.Size(59, 56);
            this.btnDroneForward.TabIndex = 6;
            this.btnDroneForward.Text = "Forward\n( I )";
            this.btnDroneForward.UseVisualStyleBackColor = true;
            this.btnDroneForward.Click += new System.EventHandler(this.btnDroneForward_Click);
            // 
            // btnDroneLeft
            // 
            this.btnDroneLeft.Location = new System.Drawing.Point(3, 66);
            this.btnDroneLeft.Name = "btnDroneLeft";
            this.btnDroneLeft.Size = new System.Drawing.Size(59, 56);
            this.btnDroneLeft.TabIndex = 7;
            this.btnDroneLeft.Text = "Left\n( J )";
            this.btnDroneLeft.UseVisualStyleBackColor = true;
            this.btnDroneLeft.Click += new System.EventHandler(this.btnDroneLeft_Click);
            // 
            // btnDroneBackward
            // 
            this.btnDroneBackward.Location = new System.Drawing.Point(68, 129);
            this.btnDroneBackward.Name = "btnDroneBackward";
            this.btnDroneBackward.Size = new System.Drawing.Size(59, 57);
            this.btnDroneBackward.TabIndex = 8;
            this.btnDroneBackward.Text = "Backward\n( K )";
            this.btnDroneBackward.UseVisualStyleBackColor = true;
            this.btnDroneBackward.Click += new System.EventHandler(this.BtnDroneBackward_Click);
            // 
            // btnDroneRight
            // 
            this.btnDroneRight.Location = new System.Drawing.Point(133, 66);
            this.btnDroneRight.Name = "btnDroneRight";
            this.btnDroneRight.Size = new System.Drawing.Size(60, 56);
            this.btnDroneRight.TabIndex = 9;
            this.btnDroneRight.Text = "Right\n( L )";
            this.btnDroneRight.UseVisualStyleBackColor = true;
            this.btnDroneRight.Click += new System.EventHandler(this.btnDroneRight_Click);
            // 
            // btnDroneHold
            // 
            this.btnDroneHold.Location = new System.Drawing.Point(68, 66);
            this.btnDroneHold.Name = "btnDroneHold";
            this.btnDroneHold.Size = new System.Drawing.Size(59, 56);
            this.btnDroneHold.TabIndex = 12;
            this.btnDroneHold.Text = "Stop";
            this.btnDroneHold.UseVisualStyleBackColor = true;
            this.btnDroneHold.Click += new System.EventHandler(this.btnDroneHold_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.stepMoveV);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(59, 56);
            this.panel5.TabIndex = 11;
            // 
            // stepMoveV
            // 
            this.stepMoveV.DecimalPlaces = 2;
            this.stepMoveV.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepMoveV.Location = new System.Drawing.Point(2, 26);
            this.stepMoveV.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepMoveV.Name = "stepMoveV";
            this.stepMoveV.Size = new System.Drawing.Size(58, 20);
            this.stepMoveV.TabIndex = 1;
            this.stepMoveV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fo/Back";
            // 
            // btnDroneSwitch
            // 
            this.btnDroneSwitch.Location = new System.Drawing.Point(133, 129);
            this.btnDroneSwitch.Name = "btnDroneSwitch";
            this.btnDroneSwitch.Size = new System.Drawing.Size(60, 58);
            this.btnDroneSwitch.TabIndex = 13;
            this.btnDroneSwitch.Text = "Drone Switch (unused)";
            this.btnDroneSwitch.UseVisualStyleBackColor = true;
            this.btnDroneSwitch.Click += new System.EventHandler(this.btnDroneSwitch_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.stepMoveVUpDown);
            this.panel8.Location = new System.Drawing.Point(133, 129);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(60, 58);
            this.panel8.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Up (O) /\r\nDown (U)";
            // 
            // stepMoveVUpDown
            // 
            this.stepMoveVUpDown.DecimalPlaces = 2;
            this.stepMoveVUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepMoveVUpDown.Location = new System.Drawing.Point(0, 35);
            this.stepMoveVUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepMoveVUpDown.Name = "stepMoveVUpDown";
            this.stepMoveVUpDown.Size = new System.Drawing.Size(60, 20);
            this.stepMoveVUpDown.TabIndex = 0;
            this.stepMoveVUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.Controls.Add(this.btnPortrait, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOIS, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDoF, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEnable, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDrop, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnTrackself, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnDC, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnHandRotate, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnTrackPivot, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnAvAutoFocus, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnDroneTurbo, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnDropPivot, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnResetZoom, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(423, 310);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(219, 215);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // btnPortrait
            // 
            this.btnPortrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnPortrait.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPortrait.Location = new System.Drawing.Point(165, 3);
            this.btnPortrait.Name = "btnPortrait";
            this.btnPortrait.Size = new System.Drawing.Size(49, 47);
            this.btnPortrait.TabIndex = 3;
            this.btnPortrait.Text = "Portrait\n";
            this.btnPortrait.UseVisualStyleBackColor = true;
            this.btnPortrait.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPortrait_MouseDown);
            this.btnPortrait.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPortrait_MouseUp);
            // 
            // btnOIS
            // 
            this.btnOIS.Location = new System.Drawing.Point(111, 3);
            this.btnOIS.Name = "btnOIS";
            this.btnOIS.Size = new System.Drawing.Size(48, 47);
            this.btnOIS.TabIndex = 2;
            this.btnOIS.Text = "Stabiliz\r\n(Ctrl+\r\nPgDn)";
            this.btnOIS.UseVisualStyleBackColor = true;
            this.btnOIS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOIS_MouseDown);
            this.btnOIS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOIS_MouseUp);
            // 
            // btnDoF
            // 
            this.btnDoF.Location = new System.Drawing.Point(57, 3);
            this.btnDoF.Name = "btnDoF";
            this.btnDoF.Size = new System.Drawing.Size(48, 47);
            this.btnDoF.TabIndex = 1;
            this.btnDoF.Text = "DoF (Hom)";
            this.btnDoF.UseVisualStyleBackColor = true;
            this.btnDoF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDoF_MouseDown);
            this.btnDoF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDoF_MouseUp);
            // 
            // btnEnable
            // 
            this.btnEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnEnable.Location = new System.Drawing.Point(3, 3);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(48, 47);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Enable\r\n(Ctrl+\r\nHome)";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEnable_MouseDown);
            this.btnEnable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEnable_MouseUp);
            // 
            // btnDrop
            // 
            this.btnDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnDrop.Location = new System.Drawing.Point(3, 109);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(48, 47);
            this.btnDrop.TabIndex = 4;
            this.btnDrop.Text = "Drop\n( INS )";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDrop_MouseDown);
            this.btnDrop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDrop_MouseUp);
            // 
            // btnTrackself
            // 
            this.btnTrackself.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnTrackself.Location = new System.Drawing.Point(57, 109);
            this.btnTrackself.Name = "btnTrackself";
            this.btnTrackself.Size = new System.Drawing.Size(48, 47);
            this.btnTrackself.TabIndex = 5;
            this.btnTrackself.Text = "Tr.Self (Ctrl+PgUp)";
            this.btnTrackself.UseVisualStyleBackColor = true;
            this.btnTrackself.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTrackself_MouseDown);
            this.btnTrackself.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTrackself_MouseUp);
            // 
            // btnDC
            // 
            this.btnDC.Location = new System.Drawing.Point(3, 56);
            this.btnDC.Name = "btnDC";
            this.btnDC.Size = new System.Drawing.Size(48, 47);
            this.btnDC.TabIndex = 6;
            this.btnDC.Text = "Movie Mode";
            this.btnDC.UseVisualStyleBackColor = true;
            this.btnDC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDC_MouseDown);
            this.btnDC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDC_MouseUp);
            // 
            // btnHandRotate
            // 
            this.btnHandRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnHandRotate.Location = new System.Drawing.Point(111, 109);
            this.btnHandRotate.Name = "btnHandRotate";
            this.btnHandRotate.Size = new System.Drawing.Size(48, 47);
            this.btnHandRotate.TabIndex = 7;
            this.btnHandRotate.Text = "Hand Rotate\n(PgDn)";
            this.btnHandRotate.UseVisualStyleBackColor = true;
            this.btnHandRotate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHandRotate_MouseDown);
            this.btnHandRotate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHandRotate_MouseUp);
            // 
            // btnTrackPivot
            // 
            this.btnTrackPivot.Location = new System.Drawing.Point(57, 162);
            this.btnTrackPivot.Name = "btnTrackPivot";
            this.btnTrackPivot.Size = new System.Drawing.Size(48, 50);
            this.btnTrackPivot.TabIndex = 8;
            this.btnTrackPivot.Text = "Track Pivot (PgUp)";
            this.btnTrackPivot.UseVisualStyleBackColor = true;
            // 
            // btnAvAutoFocus
            // 
            this.btnAvAutoFocus.Location = new System.Drawing.Point(57, 56);
            this.btnAvAutoFocus.Name = "btnAvAutoFocus";
            this.btnAvAutoFocus.Size = new System.Drawing.Size(48, 47);
            this.btnAvAutoFocus.TabIndex = 9;
            this.btnAvAutoFocus.Text = "Av AF (Shift+Home)";
            this.btnAvAutoFocus.UseVisualStyleBackColor = true;
            this.btnAvAutoFocus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAvAutoFocus_MouseDown);
            this.btnAvAutoFocus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAvAutoFocus_MouseUp);
            // 
            // btnDroneTurbo
            // 
            this.btnDroneTurbo.Location = new System.Drawing.Point(3, 162);
            this.btnDroneTurbo.Name = "btnDroneTurbo";
            this.btnDroneTurbo.Size = new System.Drawing.Size(48, 48);
            this.btnDroneTurbo.TabIndex = 10;
            this.btnDroneTurbo.Text = "Drone Turbo (R Alt)";
            this.btnDroneTurbo.UseVisualStyleBackColor = true;
            this.btnDroneTurbo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDroneTurbo_MouseDown);
            // 
            // btnDropPivot
            // 
            this.btnDropPivot.Location = new System.Drawing.Point(165, 109);
            this.btnDropPivot.Name = "btnDropPivot";
            this.btnDropPivot.Size = new System.Drawing.Size(51, 47);
            this.btnDropPivot.TabIndex = 11;
            this.btnDropPivot.Text = "Drop P (Shift+Ins)";
            this.btnDropPivot.UseVisualStyleBackColor = true;
            this.btnDropPivot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDropPivot_MouseDown);
            this.btnDropPivot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDropPivot_MouseUp);
            // 
            // btnResetZoom
            // 
            this.btnResetZoom.Location = new System.Drawing.Point(111, 56);
            this.btnResetZoom.Name = "btnResetZoom";
            this.btnResetZoom.Size = new System.Drawing.Size(48, 47);
            this.btnResetZoom.TabIndex = 12;
            this.btnResetZoom.Text = "ResetZoom (Shf =)";
            this.btnResetZoom.UseVisualStyleBackColor = true;
            this.btnResetZoom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomReset_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(10, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 215);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drone Move";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(216, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 215);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drone Rotate";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDroneRotUp, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDroneRotLeft, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDroneRotDown, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnDroneRotRight, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnDroneRotHold, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDroneSwitch, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(196, 190);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.stepRotV);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(59, 56);
            this.panel7.TabIndex = 12;
            // 
            // stepRotV
            // 
            this.stepRotV.DecimalPlaces = 2;
            this.stepRotV.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepRotV.Location = new System.Drawing.Point(2, 26);
            this.stepRotV.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepRotV.Name = "stepRotV";
            this.stepRotV.Size = new System.Drawing.Size(58, 20);
            this.stepRotV.TabIndex = 1;
            this.stepRotV.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Up/Down";
            // 
            // btnDroneRotUp
            // 
            this.btnDroneRotUp.Location = new System.Drawing.Point(68, 3);
            this.btnDroneRotUp.Name = "btnDroneRotUp";
            this.btnDroneRotUp.Size = new System.Drawing.Size(59, 56);
            this.btnDroneRotUp.TabIndex = 6;
            this.btnDroneRotUp.Text = "Up\n( ↑ )";
            this.btnDroneRotUp.UseVisualStyleBackColor = true;
            this.btnDroneRotUp.Click += new System.EventHandler(this.btnDroneRotUp_Click);
            // 
            // btnDroneRotLeft
            // 
            this.btnDroneRotLeft.Location = new System.Drawing.Point(3, 66);
            this.btnDroneRotLeft.Name = "btnDroneRotLeft";
            this.btnDroneRotLeft.Size = new System.Drawing.Size(59, 56);
            this.btnDroneRotLeft.TabIndex = 7;
            this.btnDroneRotLeft.Text = "Left\n( ← )";
            this.btnDroneRotLeft.UseVisualStyleBackColor = true;
            this.btnDroneRotLeft.Click += new System.EventHandler(this.btnDroneRotLeft_Click);
            // 
            // btnDroneRotDown
            // 
            this.btnDroneRotDown.Location = new System.Drawing.Point(68, 129);
            this.btnDroneRotDown.Name = "btnDroneRotDown";
            this.btnDroneRotDown.Size = new System.Drawing.Size(59, 57);
            this.btnDroneRotDown.TabIndex = 8;
            this.btnDroneRotDown.Text = "Down\n( ↓ )";
            this.btnDroneRotDown.UseVisualStyleBackColor = true;
            this.btnDroneRotDown.Click += new System.EventHandler(this.btnDroneRotDown_Click);
            // 
            // btnDroneRotRight
            // 
            this.btnDroneRotRight.Location = new System.Drawing.Point(133, 66);
            this.btnDroneRotRight.Name = "btnDroneRotRight";
            this.btnDroneRotRight.Size = new System.Drawing.Size(60, 56);
            this.btnDroneRotRight.TabIndex = 9;
            this.btnDroneRotRight.Text = "Right\n( → )";
            this.btnDroneRotRight.UseVisualStyleBackColor = true;
            this.btnDroneRotRight.Click += new System.EventHandler(this.btnDroneRotRight_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.stepRotH);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(3, 129);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(59, 57);
            this.panel6.TabIndex = 11;
            // 
            // stepRotH
            // 
            this.stepRotH.DecimalPlaces = 2;
            this.stepRotH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepRotH.Location = new System.Drawing.Point(2, 28);
            this.stepRotH.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepRotH.Name = "stepRotH";
            this.stepRotH.Size = new System.Drawing.Size(58, 20);
            this.stepRotH.TabIndex = 1;
            this.stepRotH.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Left/Right";
            // 
            // btnDroneRotHold
            // 
            this.btnDroneRotHold.Location = new System.Drawing.Point(68, 66);
            this.btnDroneRotHold.Name = "btnDroneRotHold";
            this.btnDroneRotHold.Size = new System.Drawing.Size(59, 56);
            this.btnDroneRotHold.TabIndex = 13;
            this.btnDroneRotHold.Text = "Stop";
            this.btnDroneRotHold.UseVisualStyleBackColor = true;
            this.btnDroneRotHold.Click += new System.EventHandler(this.btnDroneRotHold_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.controllerRefreshIdentifyBtn);
            this.groupBox3.Controls.Add(this.controllerIndexList);
            this.groupBox3.Controls.Add(this.btnShortkey);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Controls.Add(this.Port);
            this.groupBox3.Controls.Add(this.IPAddr);
            this.groupBox3.Location = new System.Drawing.Point(10, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(632, 49);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // controllerRefreshIdentifyBtn
            // 
            this.controllerRefreshIdentifyBtn.Location = new System.Drawing.Point(439, 16);
            this.controllerRefreshIdentifyBtn.Name = "controllerRefreshIdentifyBtn";
            this.controllerRefreshIdentifyBtn.Size = new System.Drawing.Size(55, 23);
            this.controllerRefreshIdentifyBtn.TabIndex = 6;
            this.controllerRefreshIdentifyBtn.Text = "Refresh";
            this.controllerRefreshIdentifyBtn.UseVisualStyleBackColor = true;
            this.controllerRefreshIdentifyBtn.Click += new System.EventHandler(this.controllerRefreshIdentifyBtn_Click);
            // 
            // controllerIndexList
            // 
            this.controllerIndexList.FormattingEnabled = true;
            this.controllerIndexList.Location = new System.Drawing.Point(354, 17);
            this.controllerIndexList.Name = "controllerIndexList";
            this.controllerIndexList.Size = new System.Drawing.Size(79, 21);
            this.controllerIndexList.TabIndex = 5;
            this.controllerIndexList.Text = "Controller 1";
            this.controllerIndexList.SelectedIndexChanged += new System.EventHandler(this.controllerIndexList_SelectedIndexChanged);
            // 
            // btnShortkey
            // 
            this.btnShortkey.Location = new System.Drawing.Point(249, 14);
            this.btnShortkey.Name = "btnShortkey";
            this.btnShortkey.Size = new System.Drawing.Size(99, 25);
            this.btnShortkey.TabIndex = 4;
            this.btnShortkey.Text = "Enable Shortkey";
            this.btnShortkey.UseVisualStyleBackColor = true;
            this.btnShortkey.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developed By :  Arizen  \nForEstu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(171, 14);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(73, 25);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(101, 16);
            this.Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(64, 20);
            this.Port.TabIndex = 1;
            this.Port.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            // 
            // IPAddr
            // 
            this.IPAddr.Location = new System.Drawing.Point(6, 16);
            this.IPAddr.Name = "IPAddr";
            this.IPAddr.Size = new System.Drawing.Size(86, 20);
            this.IPAddr.TabIndex = 0;
            this.IPAddr.Text = "127.0.0.1";
            // 
            // TimerZoomIn
            // 
            this.TimerZoomIn.Interval = 10;
            this.TimerZoomIn.Tick += new System.EventHandler(this.TimerZoomIn_Tick);
            // 
            // TimerZoomOut
            // 
            this.TimerZoomOut.Interval = 10;
            this.TimerZoomOut.Tick += new System.EventHandler(this.TimerZoomOut_Tick);
            // 
            // TimerEVm
            // 
            this.TimerEVm.Interval = 10;
            this.TimerEVm.Tick += new System.EventHandler(this.TimerEVm_Tick);
            // 
            // TimerEVp
            // 
            this.TimerEVp.Interval = 10;
            this.TimerEVp.Tick += new System.EventHandler(this.TimerEVp_Tick);
            // 
            // TimerApShallow
            // 
            this.TimerApShallow.Interval = 10;
            this.TimerApShallow.Tick += new System.EventHandler(this.TimerApShallow_Tick);
            // 
            // TimerApGrea
            // 
            this.TimerApGrea.Interval = 10;
            this.TimerApGrea.Tick += new System.EventHandler(this.TimerApGrea_Tick);
            // 
            // TimerFocusClo
            // 
            this.TimerFocusClo.Interval = 10;
            this.TimerFocusClo.Tick += new System.EventHandler(this.TimerFocusClo_Tick);
            // 
            // TimerFocusFur
            // 
            this.TimerFocusFur.Interval = 10;
            this.TimerFocusFur.Tick += new System.EventHandler(this.TimerFocusFur_Tick);
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.Location = new System.Drawing.Point(593, 512);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(59, 13);
            this.lbVer.TabIndex = 5;
            this.lbVer.Text = "Ver. 1.1.0b";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.stepMinMoveHV);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Location = new System.Drawing.Point(133, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(60, 57);
            this.panel9.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Min Move";
            // 
            // stepMinMoveHV
            // 
            this.stepMinMoveHV.DecimalPlaces = 2;
            this.stepMinMoveHV.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepMinMoveHV.Location = new System.Drawing.Point(3, 26);
            this.stepMinMoveHV.Name = "stepMinMoveHV";
            this.stepMinMoveHV.Size = new System.Drawing.Size(54, 20);
            this.stepMinMoveHV.TabIndex = 1;
            this.stepMinMoveHV.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 530);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "VRCLensOSC";
            ((System.ComponentModel.ISupportInitialize)(this.sldZoom)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepZoom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldEV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldAp)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldFocus)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMoveH)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMoveV)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMoveVUpDown)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepRotV)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepRotH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMinMoveHV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sldZoom;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Label lbZoomPer;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbZoomLen;
        private System.Windows.Forms.NumericUpDown stepZoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown stepEV;
        private System.Windows.Forms.Button btnEVp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEVm;
        private System.Windows.Forms.TrackBar sldEV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbApPer;
        private System.Windows.Forms.NumericUpDown stepAp;
        private System.Windows.Forms.Button btnApGreat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnApShallow;
        private System.Windows.Forms.TrackBar sldAp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbFocus;
        private System.Windows.Forms.NumericUpDown stepFocus;
        private System.Windows.Forms.Button btnFocusFur;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnFocusClo;
        private System.Windows.Forms.TrackBar sldFocus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDroneForward;
        private System.Windows.Forms.Button btnDroneLeft;
        private System.Windows.Forms.Button btnDroneBackward;
        private System.Windows.Forms.Button btnDroneRight;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown stepMoveV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnPortrait;
        private System.Windows.Forms.Button btnOIS;
        private System.Windows.Forms.Button btnDoF;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDroneRotUp;
        private System.Windows.Forms.Button btnDroneRotLeft;
        private System.Windows.Forms.Button btnDroneRotDown;
        private System.Windows.Forms.Button btnDroneRotRight;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown stepRotH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.NumericUpDown Port;
        private System.Windows.Forms.TextBox IPAddr;
        private System.Windows.Forms.Button btnTrackself;
        private System.Windows.Forms.Timer TimerZoomIn;
        private System.Windows.Forms.Timer TimerZoomOut;
        private System.Windows.Forms.Timer TimerEVm;
        private System.Windows.Forms.Timer TimerEVp;
        private System.Windows.Forms.Timer TimerApShallow;
        private System.Windows.Forms.Timer TimerApGrea;
        private System.Windows.Forms.Timer TimerFocusClo;
        private System.Windows.Forms.Timer TimerFocusFur;
        private System.Windows.Forms.Label lbApF;
        private System.Windows.Forms.Button btnDroneHold;
        private System.Windows.Forms.Button btnDroneRotHold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShortkey;
        private System.Windows.Forms.Button btnDC;
        private System.ComponentModel.BackgroundWorker oscListener;
        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.Button btnHandRotate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown stepMoveH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown stepRotV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDroneSwitch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown stepMoveVUpDown;
        private System.Windows.Forms.Button btnTrackPivot;
        private System.Windows.Forms.Button btnAvAutoFocus;
        private System.Windows.Forms.Button btnDroneTurbo;
        private System.Windows.Forms.Button btnDropPivot;
        private System.Windows.Forms.Button btnResetZoom;
        private System.Windows.Forms.ComboBox controllerIndexList;
        private System.Windows.Forms.Button controllerRefreshIdentifyBtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown stepMinMoveHV;
        private System.Windows.Forms.Label label14;
    }
}

