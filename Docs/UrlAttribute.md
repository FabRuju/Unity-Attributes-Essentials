# URL Attribute for Unity
> [!NOTE]
> Add the [URL] attribute above any field in your script to create a clickable URL box in the inspector.

### About
URL is a custom Unity attribute that creates an interactive box in the Inspector, containing a clickable link icon next to custom text. When the box is clicked, the user is redirected to a specified URL. 
This attribute is ideal for adding reference links, documentation, or external resources directly in your scripts, making them easily accessible.

### Features
Clickable URL Box: Displays a box with a link icon and custom text. Clicking the box redirects the user to the specified URL.
Customizable Text Alignment: Align the text within the box using the GUIalignment enum.
Optional Box Display: Choose whether to display the text within a box for better visual clarity.

### Constructors
```java
//Displays a box with the specified text, a clickable link icon, and an optional surrounding box.
[URL(string text, string urlHyperlink, bool drawBox)]
```
```java
//Displays a box with the specified text, a clickable link icon, optional text alignment, and an optional surrounding box.
[URL(string text, string urlHyperlink, GUIalignment textAlignment, bool drawBox)]
```

### Parameters
1 - The custom text to display inside the clickable box.
```cpp
string text
```
2 - The URL that the box will link to when clicked.
```cpp
string urlHyperlink
```
3 - (Optional) Specifies the alignment of the text within the box. Uses the GUIalignment enum.
```javascript
GUIalignment textAlignment
```
4 - (Optional) Determines whether the text and link icon are enclosed within a box. Defaults to true.
```cpp
bool drawBox = true
```

### Example
```cpp
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [URL("Unity Official Website", "https://unity.com", true)]
    public string unityLink;

    [URL("Unity Documentation", "https://docs.unity3d.com", GUIalignment.MiddleCenter, true)]
    public string docsLink;

    [URL("GitHub Repository", "https://github.com", GUIalignment.UpperRight, false)]
    public string githubLink;

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
