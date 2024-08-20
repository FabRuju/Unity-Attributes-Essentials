using UnityEditor;
using UnityEngine;

#region URL Drawer

[CustomPropertyDrawer(typeof(URLAttribute))]
public class URLDrawer : PropertyDrawer
{
    //Variables
    private int textSize = 10;
    private string HSpacing = "         ";
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        //Attribute 
        URLAttribute myURL = attribute as URLAttribute;
        // Calculate the height for the property
        var propertyHeight = EditorGUI.GetPropertyHeight(property, label, true);
        // Draw the property
        Rect propertyRect = new Rect(position.x, position.y, position.width, propertyHeight);
        EditorGUI.PropertyField(propertyRect, property, label, true);
        //Loads a Texture for the BG
        Texture2D _myBGTexture = Resources.Load<Texture2D>("Textures/LightBoxSkin");
        //Loads a Texture for HyperLink
        Texture2D _myURLTexture = Resources.Load<Texture2D>("Textures/Hyperlink");
        // Rect for URL
        Rect URLRect = new Rect(position.x, position.y + propertyHeight +
            EditorGUIUtility.standardVerticalSpacing, position.width, textSize * 3);
        //Debug.Log(propertyHeight + " URL BOX");
        // Rect for IMG
        Rect imgRect = new Rect(URLRect.x + 9, URLRect.y + 9, 12, 12);
        //Rect to Fake Underline
        Rect underlineRect = new Rect(URLRect.x, URLRect.y + 6, position.width, textSize * 2);
        //Codes a Rect Offset
        RectOffset offset = GUI.skin.button.border;
        //Creates GUIStyle
        GUIStyle urlStyle = new GUIStyle(GUI.skin.label)
        {
            alignment = (TextAnchor)myURL.alignment,
            fontSize = textSize,
            normal =
            {
                textColor = myURL.HEX_Color,
                background = myURL.DrawBox ? _myBGTexture : Craft.MyTexture2D(new Color(1, 1, 1, 0), 2, 2),
            },
            fontStyle = FontStyle.Italic,
            border = offset
        };
        //Creates a string that will hold the "_" char to fake underlining
        string underline = "";
        //Extends the "_" until it reaches text lenght and adjust the lines
        int counter = 0;
        for (int i = 0; i < myURL.text.Length; i++)
        {
            if (counter == 7)
            {
                counter = 0; underline += "";
            }
            else
                underline += "_";
            counter++;
        }
        //Handles the click event
        if (GUI.Button(URLRect, ""))
            Application.OpenURL(myURL.url);
        //Draws de URL Icon
        GUI.DrawTexture(imgRect, _myURLTexture);
        //Labels the Text
        GUI.Label(URLRect, HSpacing + myURL.text, urlStyle);
        //Labels the Underline
        GUI.Label(underlineRect, HSpacing + underline, urlStyle);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        // Return the total height (property height + decorator height)
        return EditorGUI.GetPropertyHeight(property, label, true) + textSize * 3 +
            EditorGUIUtility.standardVerticalSpacing * 3;
    }
}
#endregion



#region Hyperlink Drawer
[CustomPropertyDrawer(typeof(HyperlinkAttribute))]
public class HyperlinkDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // Attribute
        HyperlinkAttribute _hyperlinkAttrib = attribute as HyperlinkAttribute;
        // Calculate the height for the property
        var propertyHeight = EditorGUI.GetPropertyHeight(property, label, true);
        //Creates GUIStyle
        GUIStyle hyperlinkStyle = new GUIStyle(GUI.skin.label)
        {
            normal = { textColor = _hyperlinkAttrib.HEX_Color },
            fontStyle = FontStyle.Italic
        };
        // Calculate the rects for the label and the property field
        Rect labelRect = new Rect(position.x, position.y, position.width / 4, position.height);
        // Calculates the rect for the underline
        Rect underlineRect = new Rect(position.x, position.y + 2, position.width, EditorGUIUtility.singleLineHeight);
        //Creates an "empty" GUIContent with only a space
        GUIContent _myContent = new GUIContent(" ", _hyperlinkAttrib.Tooltip);
        // Draws the lines
        int counter = 0; string underline = "";
        for (int i = 0; i < label.text.Length; i++)
        {
            if (counter == 7)
            {
                counter = 0; underline += "";
            }
            else
                underline += "_";
            counter++;
        }
        // Handles the click and creates a button
        if (GUI.Button(labelRect, " ", hyperlinkStyle))
            Application.OpenURL(_hyperlinkAttrib.url);
        // Draw the custom label
        GUI.Label(labelRect, label, hyperlinkStyle);
        // Labels the Underline
        EditorGUI.LabelField(underlineRect, underline, hyperlinkStyle);
        // Draw the property field without a label
        EditorGUI.PropertyField(position, property, _myContent);
        // Draw the clickable label using a Button styled as a label        
    }
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label);
    }
}
#endregion
