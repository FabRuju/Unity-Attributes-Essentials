# QuickNote Attribute for Unity
> [!NOTE]
> Add the [QuickNote] attribute above any field in your script to create a customizable note **in the inspector**.
>
> This is particularly helpful for adding important reminders that can be reused across different parts of your code without having to re-write it all over    again.

> [!WARNING]
> The note can hold up to 60 characters. If you need more space, check notes attribute.

### About
QuickNote is a custom Unity attribute that allows you to add and modify quick notes directly in the Inspector. 
This attribute is particularly useful for adding reminders, instructions, or other important notes that you may need to repeat across multiple scripts.

### Features
* Modifiable Text: Allows you to create a note that can be edited directly in the Inspector.
* Customizable Text Color: Set the note's text color using a HEX code (default: #C0C0C0).
* Text Alignment: Align the note text using the GUIalignment enum.
* Unique Text ID: Assign a unique ID to each note, making it easy to reuse the same note across different scripts.
  
> [!IMPORTANT]
> Foldable UI: Includes a foldout arrow that, when opened, reveals a button to delete all non-visible notes.

> [!CAUTION]
> Be aware that the button will delete **all non-visible notes**, that including non-visible scripts on the inspector

### Constructors
```java
//Displays a quick note with specified text ID, optional text color, and a foldout arrow.
[QuickNote(string textID, string HEX_text = "#C0C0C0")]
```
```java
//Displays a quick note with specified text ID, text alignment, optional text color, and a foldout arrow.
[QuickNote(string textID, GUIalignment textAlignment, string HEX_text = "#C0C0C0")]
```

### Parameters
1 - A unique identifier for the note. This allows you to repeat the same note across different scripts.
```cpp
string textID
```
2 - (Optional) Defines the color of the note text using a HEX code. Defaults to a light gray color.
```cpp
string HEX_text = "#C0C0C0"
```
3 - (Optional) Specifies the alignment of the note text. Uses the GUIalignment enum. [About this enum](#guialignment-enum)
```javascript
GUIalignment textAlignment
```

> [!CAUTION]
> BE CAREFUL, HEX colors won't work if you dont put "#" at the begining

### Example
```cpp
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [QuickNote("ImportantNote", "#FF0000")]
    public string importantNote;

    [QuickNote("Reminder", GUIalignment.MiddleCenter, "#00FF00")]
    public string reminderNote;

    [QuickNote("ToDo", GUIalignment.UpperRight, "#FFD700")]
    public string toDoNote;

    // Other fields...
}
```

> [!IMPORTANT]
> ### Foldout Arrow and Note Deletion
> **Foldout Arrow:** Each QuickNote includes a foldout arrow. When opened, it reveals a button that, when clicked, will delete all notes that are not currently visible in the Inspector. This feature helps in managing and organizing your notes effectively.

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
