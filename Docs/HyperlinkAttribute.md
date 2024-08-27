# Hyperlink Attribute for Unity
> [!NOTE]
> Add the [Hyperlink] attribute above any field in your script to turn the property name into a clickable hyperlink in the inspector.

> [!IMPORTANT]
> This attribute works once per property

### About
Hyperlink is a custom Unity attribute that turns a property's label in the Inspector into a clickable hyperlink. 
This attribute is particularly useful for adding documentation links, references, or external resources directly within your scripts, making it easier for users to access relevant information.

### Features
* Clickable Property Name: The property label becomes a clickable hyperlink in the Unity Inspector.
* Customizable Tooltip: Optionally add a tooltip that appears when hovering over the hyperlink.
* Styled Text: The hyperlink is styled with blue text to clearly indicate its functionality.

### Constructor
```javascript
[Hyperlink(string urlHyperlink, string tooltip)]
```

### Parameters
1 - The URL that the property name will link to when clicked.
```c#
string urlHyperlink;
```
2 - (Optional) A tooltip that appears when hovering over the hyperlink. This parameter provides additional context or instructions. 
    The default value is "Click to go to the link."
```c#
string tooltip;
```

### Example
```cpp
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [Hyperlink("https://unity.com", "Visit Unity's official website")]
    public string unityLink;

    [Hyperlink("https://docs.unity3d.com", "Access Unity's Documentation")]
    public string docsLink;

    [Hyperlink("https://github.com", "Go to GitHub")]
    public string githubLink;

    // Other fields...
}

```
