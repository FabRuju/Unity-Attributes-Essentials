# HelpBoxAttribute for Unity
> [!NOTE]
> This attribute will display bellow the property.
> 
> Add the [HelpBox] attribute above any field in your script to display a help box in the inspector.

> [!WARNING]
> This attribute must be one of the last attributes you add to your property along with other bellow-displayed attributes of this package

### About
HelpBoxAttribute is a custom Unity attribute designed to display informative, warning, or error messages directly in the Inspector. 
This attribute is useful for providing context, instructions, or alerts to users working with your scripts.

### Features
Customizable Message Text: Define the text to be displayed in the help box.
Message Types: Choose from different message types to indicate the nature of the message (information, warning, error or none).

### Constructor
```javascript
[HelpBox(string helpBoxText, HelpBoxMessageType helpBoxType)]
```
### Parameters
1 - The text to display inside the help box.
```csharp
string helpBoxText;
```
2 - Optional parameter to specify the type of message (default is InfoBox). [About this enum](#helpboxmessagetype-enum)
```javascript
HelpBoxMessageType helpBoxType;
```

### Examples
```cpp
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [HelpBox("This is an information box.", HelpBoxMessageType.InfoBox)]
    public int exampleField1;

    [HelpBox("This is a warning box.", HelpBoxMessageType.WarningBox)]
    public float exampleField2;

    [HelpBox("This is an error box.", HelpBoxMessageType.ErrorBox)]
    public string exampleField3;

    // Other fields...
}
```

## HelpBoxMessageType Enum
```javascript
HelpBoxMessageType.InfoBox => //Displays a blue information box.
HelpBoxMessageType.WarningBox => //Displays a yellow warning box.
HelpBoxMessageType.ErrorBox => //Displays a red error box.
HelpBoxMessageType.None => //Displays a simple box with the desired text
```
