# QuickNote Attribute for Unity
> [!NOTE]
> Add the [QuickNote] attribute above any field in your script to create a customizable note in the inspector.
> This is particularly helpful for adding important reminders that can be reused across different parts of your code.

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

Usage


Constructors
Basic QuickNote

csharp
Copiar código
[QuickNote(string textID, string HEX_text = "#C0C0C0")]
Displays a quick note with specified text ID, optional text color, and a foldout arrow.
QuickNote with Text Alignment

csharp
Copiar código
[QuickNote(string textID, GUIalignment textAlignment, string HEX_text = "#C0C0C0")]
Displays a quick note with specified text ID, text alignment, optional text color, and a foldout arrow.
Parameters
string textID

A unique identifier for the note. This allows you to repeat the same note across different scripts.

string HEX_text = "#C0C0C0"

(Optional) Defines the color of the note text using a HEX code. Defaults to a light gray color.

GUIalignment textAlignment

(Optional) Specifies the alignment of the note text. Uses the GUIalignment enum.
