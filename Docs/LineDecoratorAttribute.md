# LineDecorator Attribute
> [!NOTE]
> Simply add the [LineDecorator] attribute above any field in your script to draw a line in the inspector.

### About:
LineDecorator is a custom Unity attribute that allows you to draw a stylized line in the Unity Inspector, 
providing better visual organization and separation of properties. 
This attribute is useful for enhancing the readability of your inspector fields, especially in complex scripts.

### Features
* Customizable Line Style: Choose from predefined line styles to match your aesthetic or organizational needs.
* Custom Line Color: Specify a custom line color using a HEX code (default: #C0C0C0).
* Adjustable Spacing: Optionally add vertical spacing around the line to create more distinct sections in the inspector.

### Parameters
1 - Enum to define the line's style
```javascript
LineSkin lineStyle;
```
2 - Integer to define the vertical space above and below the line.
```cpp
int spacing;
```
3 - Optional parameter to define the line's color using a HEX code. [About this enum](#lineskin-enum)
```java
string HEX_LineColor = "#C0C0C0";
```

### Constructor
Draws a line with the specified style and color.
```javascript
[LineDecorator(LineSkin lineStyle, string HEX_LineColor = "#C0C0C0")]
```
Draws a line with the specified style, spacing, and color.
```javascript
[LineDecorator(LineSkin lineStyle, int spacing, string HEX_LineColor = "#C0C0C0")]
```

### Example
```cpp
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [LineDecorator(LineSkin.Custom1, "#FF5733")]
    public int exampleField1;

    [LineDecorator(LineSkin.Custom8, 10)]
    public float exampleField2;

    [LineDecorator(LineSkin.Custom5, 20, "#00FF00")]
    public string exampleField3;

    // Other fields...
}

```
## LineSkin Enum
Enum holding various types of line skins (designs).
It contains 12 different designs.

```c#
LineSkin.Custom1  => //Skin 1
LineSkin.Custom2  => //Skin 2
LineSkin.Custom3  => //Skin 3
...
LineSkin.Custom12 => //Skin 12
```
