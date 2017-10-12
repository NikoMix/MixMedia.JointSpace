# MixMedia.JointSpace
Library to interact with Philips TVs running the JointSpace Interface.

Supported TV Series and Procedure to activate JointSpace for your TV can be found here http://jointspace.sourceforge.net/download.html

## Getting Started
Wrapper is built into seperate Managers, which need a HttpClient injected, since the Implementation can differ by Platform

Available Wrappers:
- Ambilight Manager
If your Philips TV got Ambilight, JointSpace will make Configuration, Topology and Measurements available.
This can be used to Sync Philips Hue Lights with your Ambilight.

- Audio Manager
Enables you to get Information about the current Volumen, change it or mute the output.

- Channel Manager
Provides Access to Channel Information and switch between them.

- Input Manager
Has only one Method to send Keys to the TV. Like Standby, Numbers, Menu Controls.
Often used to build virtual Keyboards in Apps.

- Source Manager
Provides Access to Source Management. Example: Switch from HDMI1 to HDMI2 Source

- System Manager
Provides Informations about the System Setup, like Menu Language, Model Description etc.