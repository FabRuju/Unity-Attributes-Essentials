# Unity-Attributes-Essentials
Welcome to the Unity Attributes Essentials package! 🎮

This package provides a collection of essential custom attributes for Unity, designed to enhance your workflow and improve the organization of your scripts. Included are attributes such as Headers, Help Boxes, and Hyperlinks to make your code more readable and maintainable.

I'll be regularly updating this repository as I upload YouTube videos explaining the basics of these attributes and how to effectively use them in your Unity projects. Stay tuned for more content and features!

PD: The videos are in spanish, if I recieve enough support on this package I will consider doing english versions too! =)

Happy coding! 🚀

# Changelog
- Added 7 new Attributes 19 / August / 2024
  * Header 1 Attribute
  * Header 2 Attribute
  * Header 3 Attribute
  * Subtitle Attribute
  * HelpBox Attribute
  * URL Attribute
  * Hyperlink Attribute

# Usage
H1 Attribute Constructors

```c#
//You can use it just like Unity's [Header("")], it is bigger tho

[H1("This is a header 1")]
public int someVariable;
```
```c#
/*You can customize the Text and BackgroundColor, the HEX strings are OPTIONAL
  to place, you can even only put the HEX_TextColor if you want*/

[H1("This is a header 1", "#HEX_TextColor", "#HEX_BackgroundColor")]
public int someVariable;

[H1("This is a header 1", "#HEX_TextColor")]
public int someVariable;
```
```c#
/*You can customize the TopSpacing as well like this, the HEX strings are OPTIONAL
  to place, you can even only put the HEX_TextColor if you want*/

[H1("This is a header 1", (float) spacing, "#HEX_TextColor", "#HEX_BackgroundColor")]
public int someVariable;

[H1("This is a header 1", (float) spacing, "#HEX_TextColor")]
public int someVariable;

[H1("This is a header 1", (float) spacing)]
public int someVariable;
```
```c#
/*You can customize the Alignment as well like this, the HEX strings are OPTIONAL
  to place, you can even only put the HEX_TextColor if you want. I'm covering what
  GUIalignment is and how to use it below*/

[H1("This is a header 1", GUIalignment, "#HEX_TextColor", "#HEX_BackgroundColor")]
public int someVariable;

[H1("This is a header 1", GUIalignment, "#HEX_TextColor")]
public int someVariable;

[H1("This is a header 1", GUIalignment)]
public int someVariable;
```
```c#
/*Or you can customize all at once like this, the HEX strings are OPTIONAL
  to place, you can even only put the HEX_TextColor if you want. I'm covering what
  GUIalignment is and how to use it below*/

[H1("This is a header 1", (float) spacing, GUIalignment, "#HEX_TextColor", "#HEX_BackgroundColor")]
public int someVariable;

[H1("This is a header 1", (float) spacing, GUIalignment, "#HEX_TextColor")]
public int someVariable;

[H1("This is a header 1", (float) spacing, GUIalignment)]
public int someVariable;
```

H1, H2, H3 works the same way. So it is pretty much the same

* For example *

```c#
[H1("This is a header 1", (float) spacing, GUIalignment, "#HEX_TextColor", "#HEX_BackgroundColor")]
public int someVariable;

[H2("This is a header 2, a little bit smaller than header 1", (float) spacing, GUIalignment, "#HEX_TextColor")]
public int someVariable;

[H3("This is a header 3, the smallest of all of the Headers", (float) spacing, GUIalignment)]
public int someVariable;
```
BE CAREFUL, both the Text and Background HEX colors won't work if you dont put "#" at the begining
For example: "#FFFFFF"

#  What is GUIalignment
It is a enum holding various types of built-in alignments

```c#
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

# Subtitle Attribute
The structure is simillar to H1, H2, H3 attributes
it doesnt have a spacing param and instead of HEX_BackgroundColor param, 
there is a bool that toggles a Box at the background
This bool's default value is true, but you can change it

This attribute gives either H1 or H2 or H3 a subtitle below.
The attribute MUST go BELOW either H1 or H2 or H3 attribute, or it will glitch through the inspector properties

Examples:

```c#
[H1("Title")]
[Subtitle("This is a header 1 subtitle", GUIalignment, "#HEX_TextColor", false)]
public int someVariable;

[H3("Title Header 3")]
[Subtitle("With its subtitle", GUIalignment, "#HEX_TextColor")]
public int someVariable;

[H3("Another Header3")]
[Subtitle("This time I won't specify alignment", "#HEX_TextColor")]
public int someVariable;

[H2("A Header 2")]
[Subtitle("And now I don't want the Box", "#HEX_TextColor", false)]
public int someVariable;
```
