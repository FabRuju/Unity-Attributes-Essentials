using System.Reflection;
using System.Security.Policy;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

#region H1 Drawer

[CustomPropertyDrawer(typeof(H1Attribute))]
public class H1Drawer : DecoratorDrawer
{
    //Variables
    private int textSize = 20;
    private float bottomSpacing = EditorGUIUtility.singleLineHeight;

    public override void OnGUI(Rect position)
    {
        //Gets the property attribute for the editor
        H1Attribute header = attribute as H1Attribute;
        //Codes a Rect
        Rect headerRect = new Rect(position.xMin, position.yMin + header.spacing, position.width, textSize * 2);
        //Draw Rect for BG
        EditorGUI.DrawRect(headerRect, header.HEX_Background);
        //Creates GUIStyle
        GUIStyle headerStyle = new GUIStyle(GUI.skin.label) 
        { 
            alignment = (TextAnchor) header.alignment,
            fontSize = textSize,
            normal = { textColor = header.HEX_Color },
            fontStyle = FontStyle.Bold
        };
        //Labels it
        GUI.Label(headerRect, header.text, headerStyle);
    }

    public override float GetHeight()
    {
        //Gets the property attribute for the editor
        H1Attribute header = attribute as H1Attribute;
        //Returns the wanted height
        return header.spacing + textSize + textSize + bottomSpacing;
    }
}
#endregion



#region H2 Drawer

[CustomPropertyDrawer(typeof(H2Attribute))]
public class H2Drawer : DecoratorDrawer
{
    //Variables
    private int textSize = 16;
    private float bottomSpacing = EditorGUIUtility.singleLineHeight;

    public override void OnGUI(Rect position)
    {
        //Gets the property attribute for the editor
        H2Attribute header = attribute as H2Attribute;
        //Codes a Rect
        Rect headerRect = new Rect(position.xMin, position.yMin + header.spacing, position.width, textSize * 2);
        //Draw Rect for BG
        EditorGUI.DrawRect(headerRect, header.HEX_Background);
        //Creates GUIStyle
        GUIStyle headerStyle = new GUIStyle(GUI.skin.label)
        {
            alignment = (TextAnchor) header.alignment,
            fontSize = textSize,
            normal = { textColor = header.HEX_Color },
            fontStyle = FontStyle.Bold
        };
        //Labels it
        GUI.Label(headerRect, header.text, headerStyle);
    }

    public override float GetHeight()
    {
        //Gets the property attribute for the editor
        H2Attribute header = attribute as H2Attribute;
        //Returns the wanted height
        return header.spacing + textSize + textSize + bottomSpacing;
    }
}
#endregion



#region H3 Drawer

[CustomPropertyDrawer(typeof(H3Attribute))]
public class H3Drawer : DecoratorDrawer
{
    //Variables
    private int textSize = 13;
    private float bottomSpacing = EditorGUIUtility.singleLineHeight;

    public override void OnGUI(Rect position)
    {
        //Gets the property attribute for the editor
        H3Attribute header = attribute as H3Attribute;
        //Codes a Rect
        Rect headerRect = new Rect(position.xMin, position.yMin + header.spacing, position.width, textSize * 2);
        //Draw Rect for BG
        EditorGUI.DrawRect(headerRect, header.HEX_Background);
        //Creates GUIStyle
        GUIStyle headerStyle = new GUIStyle(GUI.skin.label)
        {
            alignment = (TextAnchor)header.alignment,
            fontSize = textSize,
            normal = { textColor = header.HEX_Color },
            fontStyle = FontStyle.Bold
        };
        //Labels it
        GUI.Label(headerRect, header.text, headerStyle);
    }

    public override float GetHeight()
    {
        //Gets the property attribute for the editor
        H3Attribute header = attribute as H3Attribute;
        //Returns the wanted height
        return header.spacing + textSize + textSize + bottomSpacing;
    }
}
#endregion



#region Subtitle Drawer

[CustomPropertyDrawer(typeof(SubtitleAttribute))]
public class SubtitleDrawer : DecoratorDrawer
{
    //Variables
    private int textSize = 10;

    public override void OnGUI(Rect position)
    {
        //Gets the property attribute for the editor
        SubtitleAttribute subtitle = attribute as SubtitleAttribute;
        //Codes a Rect
        Rect headerRect = new Rect(position.xMin, position.yMin - EditorGUIUtility.singleLineHeight, position.width, textSize * 2);
        //Codes a Rect Offset
        RectOffset offset = GUI.skin.button.border;
        //Loads a Texture for the BG
        Texture2D _myBGTexture = Resources.Load<Texture2D>("Textures/LightBoxSkin");
        //Creates GUIStyle
        GUIStyle headerStyle = new GUIStyle(GUI.skin.label)
        {
            alignment = (TextAnchor)subtitle.alignment,
            fontSize = textSize,
            normal = { textColor = subtitle.HEX_Color },         
            fontStyle = FontStyle.Normal,
            border = offset
        };
        //If DrawBox is active
        if(subtitle.DrawBox)
            headerStyle.normal.background = _myBGTexture;

        GUI.Label(headerRect, subtitle.text, headerStyle);
    }

    public override float GetHeight()
    {
        //Returns the wanted height
        return textSize + textSize;
    }
}
#endregion



#region URL Drawer

[CustomPropertyDrawer(typeof(HelpBoxAttribute))]
public class HelpBoxDrawer : PropertyDrawer
{
    //Variables
    private int textSize = 10;
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // Attribute 
        HelpBoxAttribute helpBoxAttrib = attribute as HelpBoxAttribute;
        // Calculate the height for the property
        var propertyHeight = EditorGUI.GetPropertyHeight(property, label, false);
        // Rect for property
        Rect propertyRect = new Rect(position.x, position.y, position.width, propertyHeight);
        //Debug.Log(propertyHeight + " HELP BOX");
        // Draws whole property
        EditorGUI.PropertyField(propertyRect, property, label, true);
        // Rect for URL
        Rect helpBoxRect = new Rect(position.x, position.y + propertyHeight +
            EditorGUIUtility.standardVerticalSpacing, position.width, textSize * 6);
        EditorGUI.HelpBox(helpBoxRect, helpBoxAttrib.text, (MessageType) helpBoxAttrib.type);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        // Return the total height (property height + decorator height)
        return EditorGUI.GetPropertyHeight(property, label, true) + textSize * 6 +
            EditorGUIUtility.standardVerticalSpacing;
    }
}
#endregion
