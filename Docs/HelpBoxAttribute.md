# HelpBoxAttribute for Unity
### About
HelpBoxAttribute is a custom Unity attribute designed to display informative, warning, or error messages directly in the Inspector. 
This attribute is useful for providing context, instructions, or alerts to users working with your scripts.

### Features
Customizable Message Text: Define the text to be displayed in the help box.
Message Types: Choose from different message types to indicate the nature of the message (information, warning, error or none).

## Usage
Add the [HelpBoxAttribute] above any field in your script to display a help box in the inspector.

Constructor
csharp
Copiar código
[HelpBoxAttribute(string helpBoxText, HelpBoxMessageType helpBoxType = HelpBoxMessageType.InfoBox)]
Parameters:
string helpBoxText: The text to display inside the help box.
HelpBoxMessageType helpBoxType = HelpBoxMessageType.InfoBox: Optional parameter to specify the type of message (default is InfoBox).
HelpBoxMessageType Enum
InfoBox: Displays a blue information box.
WarningBox: Displays a yellow warning box.
ErrorBox: Displays a red error box.
