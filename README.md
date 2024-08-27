# Unity-Attributes-Essentials
Welcome to the Unity Attributes Essentials package! 🎮

This package provides a collection of essential custom attributes for Unity, designed to enhance your workflow and improve the organization of your scripts. Included are attributes such as Headers, Help Boxes, and Hyperlinks to make your code more readable and maintainable.

I'll be regularly updating this repository as I upload YouTube videos explaining the basics of these attributes and how to effectively use them in your Unity projects. Stay tuned for more content and features!

PD: The videos are in spanish, if I recieve enough support on this package I will consider doing english versions too! =)

Happy coding! 🚀

## Changelog
- Added 3 new Attributes 26 / August / 2024
  * LineDecorator Attribute
  * Quick Note Attribute
  * Notes Attribute
    
- Added 7 new Attributes 19 / August / 2024
  * Header 1 Attribute
  * Header 2 Attribute
  * Header 3 Attribute
  * Subtitle Attribute
  * HelpBox Attribute
  * URL Attribute
  * Hyperlink Attribute

## Documentation
### H1, H2, H3 Attributes
Attributes designed to enhance the visual organization of fields in the Unity Inspector by creating styled headers. 
These headers allow for better separation and labeling of different sections within the inspector, improving the readability and structure of your scripts.

> [!IMPORTANT]
> For the sake of order, I did not put all the documentation in the README.
> 
> I divided it into other pages for each attribute. 
> [Documentation here](Docs/HeaderAttributes.md)

#### Captures
  
  ![](Captures/Capture1B.jpg)
  
# Subtitle Attribute
> [!IMPORTANT]
> For the sake of order, I did not put all the documentation in the README.
> 
> I divided it into other pages for each attribute. 
> [Documentation here](Docs/HeaderAttributes.md)
- Captures

  ![](Captures/Capture3A.jpg)
  ![](Captures/Capture3B.jpg)
  
# Hyperlink Attribute
It will make the property clickeable that will take you to a webpage
It contains a tooltip where you can put f.e. where the link is going to take you

It takes only 2 params and the las tone its optional (The tooltip), you can type in whatever you want
either way it will show the default tooltip "Click to go to the link"

This attribute wont allow multiple usage on one property
```c#
//A way to use it customizing the tooltip

[Hyperlink("https://github.com/FabRuju/Unity-Attributes-Essentials", "This is a Hyperlink on a Variable")]
public int someVariable;
```
```c#
//A way to use it without customizing the tooltip

[Hyperlink("https://github.com/FabRuju/Unity-Attributes-Essentials")]
public int someVariable;
```
- Captures

  ![](Captures/Capture4A.jpg)
  ![](Captures/Capture4B.jpg)
  
# HelpBox Attribute
It creates a Field bellow the property with a HelpBox
It uses an optional param which is HelpBoxMessageType which is an enum that I will explain bellow
The default value of this last param is set to Tooltip

This attribute wont allow multiple usage on one property

```c#
//This is a normal HelpBox with your text

[HelpBox("This is a HelpBox")]
public int someVariable;
```
```c#
//This is a HelpBox with a custom MessageType

[HelpBox("Wowsy, another HelpBox XD", HelpBoxMessageType)]
public int someVariable;
```

# What is HelpBoxMessageType?
It is a enum holding various types of built-in HelpBox skins

```c#
HelpBoxMessageType.EmptyBox => //No skin, a simple box drawed bellow the property
HelpBoxMessageType.WarningBox = //A warning skin, (The yellow Unity icon that sometimes is shown at the console)
HelpBoxMessageType.ErrorBox = //An error skin, (The red Unity icon that sometimes is shown at the console)
HelpBoxMessageType.InfoBox =  //The info skin (The gray Unity icon that is shown with Debug.Log)
```
- Captures

  ![](Captures/Capture5A.jpg)
  ![](Captures/Capture5B.jpg)

# LineDecorator Attribute

### About:
LineDecorator is a custom Unity attribute that allows you to draw a stylized line in the Unity Inspector, 
providing better visual organization and separation of properties. 
This attribute is useful for enhancing the readability of your inspector fields, especially in complex scripts.

### Features
* Customizable Line Style: Choose from predefined line styles to match your aesthetic or organizational needs.
* Custom Line Color: Specify a custom line color using a HEX code (default: #C0C0C0).
* Adjustable Spacing: Optionally add vertical spacing around the line to create more distinct sections in the inspector.

* Parameters
```c#
LineSkin lineStyle => //Enum to define the line's style
int spacing => //Integer to define the vertical space above and below the line.
string HEX_LineColor = "#C0C0C0" => //Optional parameter to define the line's color using a HEX code.
```
This attribute will create a Decorated Line Separator  
Uses a param which is LineSkin, it is an enum that I will explain bellow
It is possible to customize the spacing
You can customize the color of the decorator, but this last param its optional
Just like the other attributes you need to input the HEX color using '#' at the begining

This attribute allow multiple usage on one property

```c#
[LineDecorator(LineSkin lineStyle, string HEX_LineColor = "#C0C0C0")]

[LineDecorator(LineSkin lineStyle, int spacing, string HEX_LineColor = "#C0C0C0")]
```

# What is LineSkin
Enum holding various types of line skins (designs).

It contains 12 different designs.

```c#
LineSkin.Custom1  => //Skin 1
LineSkin.Custom2  => //Skin 2
LineSkin.Custom3  => //Skin 3
...
LineSkin.Custom12 => //Skin 12
```

# Coming Soon ...
