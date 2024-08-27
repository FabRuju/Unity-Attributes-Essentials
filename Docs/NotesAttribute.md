# Notes Attribute for Unity
> [!NOTE]
> Add the [Notes] attribute above any field in your script to create a detailed, editable note section in the inspector.
> This is useful for adding longer explanations or documentation that can be organized and edited directly in Unity.

### About
Notes is a custom Unity attribute that allows you to add detailed, multiline notes directly in the Inspector. 
This attribute is ideal for writing longer notes, instructions, or documentation that can be edited and organized with ease.

### Features
* Foldable Notes Section: Displays a foldout in the Inspector labeled "Notes." When unfolded, it reveals a TextArea where you can enter multiline text.
* Modifiable Text: The TextArea allows for larger text input, including line breaks and spacing, making it ideal for detailed notes.
* Customizable Text Color: Set the note's text color using a HEX code (default: #C0C0C0).
* Text Alignment: Align the note text using the GUIalignment enum.
* Unique Text ID: Assign a unique ID to each note, making it easy to reuse or reference the same note across different scripts.
* Sub-Foldout for Note Management: The foldout includes a sub-foldout that, when opened, reveals a button to delete all non-visible notes.

### Constructors
```java
//Displays a foldout labeled "Notes" with specified text ID, text alignment, optional text color,
//and a multiline TextArea for detailed input.
[Notes(string textID, GUIalignment textAlignment, string HEX_text = "#C0C0C0")]
```
```java
//Displays a foldout labeled "Notes" with specified text ID, optional text color, and a multiline
//TextArea for detailed input.
[Notes(string textID, string HEX_text = "#C0C0C0")]
```

### Parameters
A unique identifier for the note. This allows you to repeat or reference the same note across different scripts.
```cpp
string textID;
```
(Optional) Specifies the alignment of the note text within the TextArea. Uses the GUIalignment enum.
```javascript
GUIalignment textAlignment;
```
(Optional) Defines the color of the note text using a HEX code. Defaults to a light gray color.
```cpp
string HEX_text;
```

### Example
```cpp
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [Notes("DesignNotes", GUIalignment.MiddleLeft, "#FFAA00")]
    public string designNotes;

    [Notes("ImplementationDetails", "#00FF00")]
    public string implementationDetails;

    [Notes("TestingPlan", GUIalignment.UpperRight, "#FFD700")]
    public string testingPlan;

    // Other fields...
}
```

> [!IMPORTANT]
> ### Sub-Foldout and Note Deletion
> **Sub-Foldout:** Each Notes foldout includes a sub-foldout that, when opened, reveals a button to delete all notes that are not currently visible in the Inspector. This feature is designed to help manage and organize your notes efficiently.

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
[About this enum](#guialignment-enum)
