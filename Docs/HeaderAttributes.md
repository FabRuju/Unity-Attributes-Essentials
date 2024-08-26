# H1, H2, H3 Header Attributes for Unity
H1, H2 and H3 are custom Unity attributes designed to enhance the visual organization of fields in the Unity Inspector by creating styled headers. 
These headers allow for better separation and labeling of different sections within the inspector, improving the readability and structure of your scripts.

## Features
* Customizable Text Color: Set the header text color using a HEX code (default: #C0C0C0).
* Custom Background Color: Define the background color of the header using a HEX code (default: #38383800).
* Adjustable Spacing: Optionally adjust the vertical spacing around the header to create more distinct sections.
* Text Alignment: Align the header text according to your preference (left, center, right).

## Usage
The three attributes have the same features, parameters and same constructors
Just add either [H1] or [H2] or [H3] attribute above any field in your script to create a styled header in the inspector.

## Constructors
ddd 
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
## Parameters
```c#
string text: The header text to display.
float headerSpacing: Optional parameter to define the vertical space above and below the header.
GUIalignment textAlignment: Parameter to align the header text (e.g., TextAnchor.UpperLeft, TextAnchor.MiddleCenter).
string HEX_text = "#C0C0C0": Optional parameter to define the color of the header text using a HEX code.
string HEX_BG = "#38383800": Optional parameter to define the background color of the header using a HEX code.
```
