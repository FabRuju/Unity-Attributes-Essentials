# H1, H2, H3 Header Attributes for Unity
> [!NOTE]
> The three attributes have the same features, parameters and same constructors.
>
> Just add either [H1] or [H2] or [H3] attribute above any field in your script to create a styled header in the inspector.

### About 
H1, H2 and H3 are custom Unity attributes designed to enhance the visual organization of fields in the Unity Inspector by creating styled headers. 
These headers allow for better separation and labeling of different sections within the inspector, improving the readability and structure of your scripts.

### Features
* Customizable Text Color: Set the header text color using a HEX code (default: #C0C0C0).
* Custom Background Color: Define the background color of the header using a HEX code (default: #38383800).
* Adjustable Spacing: Optionally adjust the vertical spacing around the header to create more distinct sections.
* Text Alignment: Align the header text according to your preference (left, center, right).

### Constructors
```csharp
//Creates a header with the specified text, text color, and background color.
[H1(string text, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")]
```
```cpp
//Creates a header with the specified text, spacing, text color, and background color.
[H1(string text, float headerSpacing, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")]
```
```cpp
//Creates a header with the specified text, text alignment, text color, and background color.
[H1(string text, GUIalignment textAlignment, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")]
```
```cpp
//Creates a header with the specified text, spacing, text alignment, text color, and background color.
[H1(string text, float headerSpacing, GUIalignment textAlignment, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")]
```
### Parameters
1 - The header text to display.
```cpp 
string text;
```
2 - Parameter to define the vertical space above and below the header.
```cpp 
float headerSpacing;
```
3 - Parameter (Enum) to align the header text (e.g., UpperLeft, MiddleCenter). [About this enum](#guialignment-enum)
```javascript
GUIalignment textAlignment;
```
4 - Optional parameter to define the color of the header text using a HEX code.
```cpp 
string HEX_text = "#C0C0C0";
```
5 - Optional parameter to define the background color of the header using a HEX code.
```cpp 
string HEX_BG = "#38383800";
```
> [!CAUTION]
> BE CAREFUL, HEX colors won't work if you dont put "#" at the begining

### Examples
```cpp
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [H1("Main Settings", "#FFFFFF", "#000000")]
    public int exampleField1;

    [H1("Advanced Settings", 10, "#FF5733", "#38383800")]
    public float exampleField2;

    [H1("Additional Options", GUIalignment.MiddleCenter, "#00FF00", "#1E1E1E00")]
    public string exampleField3;

    [H1("Final Section", 20, GUIalignment.UpperRight, "#FFD700", "#222222FF")]
    public bool exampleField4;

    // Other fields...
}
```

## GUIalignment Enum
```javascript
GUIalignment.UpLeft => //Allign text to the UpperLeft part
GUIalignment.UpCenter => //Allign tex to the UpperCenter part
GUIalignment.UpRight => //Allign text to the UpperRight part

GUIalignment.MidLeft => //Allign text to the MiddleLeft part
GUIalignment.MidCenter => //Allign text to the MiddleCenter part
GUIalignment.MidRight => //Allign text to the MiddleRight part

GUIalignment.BottomLeft => //Allign text to the LowerLeft part
GUIalignment.BottomCenter => //Allign text to the LowerCenter part
GUIalignment.BottomRight => //Allign text to the LowerRight part
```
