# VRCLensOSC

## Installation

Download version 1.0.9f: https://cafe.naver.com/steamindiegame/8490301

And buy from Booth to support the creator: https://booth.pm/en/items/4049205?BOOTH-APP-CLIENT-VERSION=BOOTH-APP-CLIENT-VERSIONsavik%27%3C%2F

The original version on Booth (1.0.9b) has minor issues with hotkey overlapping that was fixed by ForEstu in 1.0.9f. You can download 1.0.9b at https://cafe.naver.com/steamindiegame/7077159.

Or build from source (1.0.9b): https://github.com/liArizenil/VRCLensOSC

## Setup

Optional: to use the Switch (Y) toggle to toggle between forward/back and up/down movement, add a `VRCLDroneSwitch` parameter to your avatar: https://www.youtube.com/watch?v=j7kir6nPkyg

1. Add a `VRCLDroneSwitch` Int parameter to Expression Menu parameters (default `0`, Saved unchecked)
2. Add a `VRCLDroneSwitch` Int parameter to FX Layer parameters (default `0`)
3. Open FX Layer in Animator. In the `vCNP_Drone 212-214 i234` layer:
    1. Add a transition from `MoveH` to `MoveV` (right click `MoveH` > Make Transition > click `MoveV`). Select the new transition and add a condition, `VRCLDroneSwitch Equals 6`. Uncheck "Has Exit Time" and set the Transition Duration to `0`.
    2. Select the existing transition from `MoveV` to `MoveH`. Add a condition, `VRCLDroneSwitch NotEqual 6`.
    3. Add a transition from `RotateH` to `RotateV`. Select the new transition and add a condition, `VRCLDroneSwitch Equals 6`. Uncheck "Has Exit Time" and set the Transition Duration to `0`.
    4. Select the existing transition from `RotateV` to `RotateH`. Add a condition, `VRCLDroneSwitch NotEqual 6`.
4. Upload avatar. If the toggle doesn't work in game, delete your `%UserProfile%\AppData\LocalLow\VRChat\VRChat\OSC` folder and re-swap into your avatar.

## Usage

- Run VRCLensOSC.exe
- Enable OSC in VRChat (Action Menu: Options > OSC > Enabled)
- Click "Connect" in VRCLensOSC
- Click "Enable Shortkey" to enable keyboard shortcuts

### Drone Movement

- Enable "Hand Rotate" to rotate drone using mouse
- Adjust drone speed using "Fo/Back", "Left/Right" number inputs. Ranges from `0` (slowest) to `1.0` (fastest), default is `0.50`. E.g., to make drone move slower, change these to `0.1`.

## Compatibility

- Last tested with VRCLens v1.8.0

## Build from source

Requirements:

- Visual Studio 2017+ with .NET desktop development tools
  - Or Build Tools for Visual Studio 2017 (https://visualstudio.microsoft.com/vs/older-downloads/) and NuGet (https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-nuget-cli)
- .NET Framework 4.7.2: https://dotnet.microsoft.com/en-us/download/visual-studio-sdks

```cmd
nuget restore

msbuild /property:Configuration=Release
```
