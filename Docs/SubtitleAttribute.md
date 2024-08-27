# SubtitleAttribute for Unity
> [!NOTE]
> This setup helps in structuring your inspector layout by grouping related fields under clear headings and descriptive subtitles.

> [!IMPORTANT]
> Add the [SubtitleAttribute] directly below any of this attributes to create a styled subtitle in the inspector:
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
[SubtitleAttribute(string text, string HEX_text = "#C0C0C0", bool drawBox = true)]
```
```c#
//Displays a subtitle with specified text, text alignment, optional text color, and an option to draw a surrounding box.
[SubtitleAttribute(string text, GUIalignment textAlignment, string HEX_text = "#C0C0C0", bool drawBox = true)]
```
### Parameters
The subtitle text to display below the H1 header.
```c#
string text
```
Specifies the alignment of the subtitle text. Uses the GUIalignment enum, which mirrors Unity's TextAnchor options.
```c#
GUIalignment textAlignment
```
The GUIalignment enum specifies how the subtitle text is aligned within its container. It includes the following options:
```c#
GUIalignment Enum
```
(Optional) Defines the color of the subtitle text using a HEX code. Defaults to a light gray color.
```c#
string HEX_text = "#C0C0C0"
```
(Optional) Determines whether the subtitle is enclosed within a box. Setting this to false will display the text without a box. Defaults to true.
```c#
bool drawBox = true
```

GUIalignment.UpperLeft
GUIalignment.UpperCenter
GUIalignment.UpperRight
GUIalignment.MiddleLeft
GUIalignment.MiddleCenter
GUIalignment.MiddleRight
GUIalignment.LowerLeft
GUIalignment.LowerCenter
GUIalignment.LowerRight
