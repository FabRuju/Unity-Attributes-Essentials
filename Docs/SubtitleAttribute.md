# SubtitleAttribute for Unity
> [!NOTE]
> This setup helps in structuring your inspector layout by grouping related fields under clear headings and descriptive subtitles.

> [!IMPORTANT]
> Add the [Subtitle] attribute directly below any of this attributes to create a styled subtitle in the inspector:
> * H1
> * H2
> * H3

### About
SubtitleAttribute is a custom Unity attribute designed to display descriptive subtitles directly below H1 headers in the Unity Inspector. This attribute enhances the organization and readability of your inspector by providing additional context or instructions for specific sections of your scripts.

### Features
* Customizable Text Color: Set the subtitle text color using a HEX code (default: #C0C0C0).
* Optional Box Display: Choose whether to display the subtitle within a box for better visual separation.
* Text Alignment: Align the subtitle text using the GUIalignment enum, which offers flexibility in positioning the text (left, center, right).

### Constructors
```c#
//Displays a subtitle with specified text, optional text color, and an option to draw a surrounding box.
[Subtitle(string text, string HEX_text = "#C0C0C0", bool drawBox = true)]
```
```c#
//Displays a subtitle with specified text, text alignment, optional text color, and an option to draw a surrounding box.
[Subtitle(string text, GUIalignment textAlignment, string HEX_text = "#C0C0C0", bool drawBox = true)]
```
### Parameters
1 - The subtitle text to display below the H1 header.
```c#
string text
```
2 - Specifies the alignment of the subtitle text. Uses the GUIalignment enum, which mirrors Unity's TextAnchor options.
    
   [About this enum](#guialignment-enum)
```c#
GUIalignment textAlignment
```
3 - The GUIalignment enum specifies how the subtitle text is aligned within its container. It includes the following options:
```c#
GUIalignment Enum
```
4 - (Optional) Defines the color of the subtitle text using a HEX code. Defaults to a light gray color.
```c#
string HEX_text = "#C0C0C0"
```
5 - (Optional) Determines whether the subtitle is enclosed within a box. Setting this to false will display the text without a box. Defaults to true.
```c#
bool drawBox = true
```
> [!CAUTION]
> BE CAREFUL, HEX colors won't work if you dont put "#" at the begining

### Example
```cpp
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [H1("Player Settings", "#FFFFFF", "#000000")]
    [Subtitle("Configure the basic player settings below.", "#AAAAAA", true)]
    public int health;

    [H2("Player Settings", "#FFFFFF", "#000000")]
    [Subtitle("Adjust movement parameters.", GUIalignment.MiddleCenter, "#00FF00", false)]
    public float speed;
    
    [H1("Enemy Settings", "#FF0000", "#1E1E1E")]
    [Subtitle("Set enemy behavior and stats.", GUIalignment.UpperRight, "#FFD700", true)]
    public int enemyCount;

    [H3("Player Settings", "#FFFFFF", "#000000")]
    [Subtitle("Spawn rate details.", "#CCCCCC")]
    public float spawnRate;
    
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

