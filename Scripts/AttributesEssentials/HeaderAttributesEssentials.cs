using System;
using UnityEngine;

#region H1Attribute

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class H1Attribute : PropertyAttribute
{
    #region Variables 

    public readonly string text; //String for the text shown on inspector
    public readonly float spacing; //Top Spacing
    public readonly Color HEX_Color, HEX_Background; //Color of the text and color for the background   
    public readonly GUIalignment alignment; //Enum with the TextAnchor Options

    #endregion

    #region H1 Constructor with Text , TextColor, BGColor
    public H1Attribute(string text, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = GUIalignment.MidLeft;
        //Sets Spacing
        spacing = 25;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor : 
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region H1 Constructor with Text, Spacing, TexColor, BGColor
    public H1Attribute(string text, float headerSpacing, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = GUIalignment.MidLeft;
        //Sets spacing
        spacing = headerSpacing;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region H1 Constructor with Text, Alignment, TextColor, BGColor
    public H1Attribute(string text, GUIalignment textAlignment,
        string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = textAlignment;
        //Sets Spacing
        spacing = 25;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region H1 Constructor with Text , Spacing, Alignment, TextColor, BGColor
    public H1Attribute(string text, float headerSpacing, GUIalignment textAlignment, 
        string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Spacing
        spacing = headerSpacing;
        //Sets Alignment
        alignment = textAlignment;        
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion
}
#endregion



#region H2Attribute

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class H2Attribute : PropertyAttribute
{
    #region Variables 

    public readonly string text; //String for the text shown on inspector
    public readonly float spacing; //Top Spacing
    public readonly Color HEX_Color, HEX_Background; //Color of the text and color for the background   
    public readonly GUIalignment alignment; //Enum with the TextAnchor Options

    #endregion

    #region H2 Constructor with Text , TextColor, BGColor
    public H2Attribute(string text, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = GUIalignment.MidLeft;
        //Sets Spacing
        spacing = 15;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region H2 Constructor with Text, Spacing, TexColor, BGColor
    public H2Attribute(string text, float headerSpacing, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = GUIalignment.MidLeft;
        //Sets spacing
        spacing = headerSpacing;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region H2 Constructor with Text, Alignment, TextColor, BGColor
    public H2Attribute(string text, GUIalignment textAlignment,
        string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = textAlignment;
        //Sets Spacing
        spacing = 15;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region H2 Constructor with Text , Spacing, Alignment, TextColor, BGColor
    public H2Attribute(string text, float headerSpacing, GUIalignment textAlignment,
        string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Spacing
        spacing = headerSpacing;
        //Sets Alignment
        alignment = textAlignment;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion
}
#endregion



#region H3Attribute

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class H3Attribute : PropertyAttribute
{
    #region Variables 

    public readonly string text; //String for the text shown on inspector
    public readonly float spacing; //Top Spacing
    public readonly Color HEX_Color, HEX_Background; //Color of the text and color for the background   
    public readonly GUIalignment alignment; //Enum with the TextAnchor Options

    #endregion

    #region H3 Constructor with Text , TextColor, BGColor
    public H3Attribute(string text, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = GUIalignment.MidLeft;
        //Sets Spacing
        spacing = 8;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region H3 Constructor with Text, Spacing, TexColor, BGColor
    public H3Attribute(string text, float headerSpacing, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = GUIalignment.MidLeft;
        //Sets spacing
        spacing = headerSpacing;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region H3 Constructor with Text, Alignment, TextColor, BGColor
    public H3Attribute(string text, GUIalignment textAlignment,
        string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = textAlignment;
        //Sets Spacing
        spacing = 8;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region H3 Constructor with Text , Spacing, Alignment, TextColor, BGColor
    public H3Attribute(string text, float headerSpacing, GUIalignment textAlignment,
        string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Spacing
        spacing = headerSpacing;
        //Sets Alignment
        alignment = textAlignment;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion
}
#endregion


/* Comming SOON
#region TextAttribute

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class TextAttribute : PropertyAttribute
{
    #region Variables 

    public readonly string text; //String for the text shown on inspector
    public readonly float spacing; //Top Spacing
    public readonly int TextSize; //Text Size
    public readonly Color HEX_Color, HEX_Background; //Color of the text and color for the background   
    public readonly GUIalignment alignment; //Enum with the TextAnchor Options

    #endregion

    #region Text Constructor with Text , TextColor, BGColor
    public TextAttribute(string text, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = GUIalignment.MidLeft;
        //Sets Spacing
        spacing = 8;
        //Sets TextSize
        TextSize = 10;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region Text Constructor with Text, TextSize, TexColor, BGColor
    public TextAttribute(string text, int textSize, string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets TextSize
        this.TextSize = textSize;
        //Sets Alignment
        alignment = GUIalignment.MidLeft;
        //Sets spacing
        spacing = 8;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region Text Constructor with Text, Alignment, TextColor, BGColor
    public TextAttribute(string text, GUIalignment textAlignment,
        string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets TextSize
        TextSize = 10;
        //Sets Alignment
        alignment = textAlignment;
        //Sets Spacing
        spacing = 8;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion

    #region Text Constructor with Text , TextSize, Spacing, Alignment, TextColor, BGColor
    public TextAttribute(string text, int textSize, float headerSpacing, GUIalignment textAlignment = GUIalignment.MidLeft,
        string HEX_text = "#C0C0C0", string HEX_BG = "#38383800")
    {
        //Sets Text
        this.text = text;
        //Sets TextSize
        TextSize = textSize;
        //Sets Spacing
        spacing = headerSpacing;
        //Sets Alignment
        alignment = textAlignment;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets BG Color
        HEX_Background = ColorUtility.TryParseHtmlString(HEX_BG, out Color _myHEXbgColor) ? _myHEXbgColor :
            new Color(0.2196079f, 0.2196079f, 0.2196079f, 0);
    }
    #endregion
}
#endregion
*/


#region Subtitle Attribute

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class SubtitleAttribute : PropertyAttribute
{
    #region Variables 

    public readonly string text; //String for the text shown on inspector
    public readonly Color HEX_Color; //Color of the tex and color for the background   
    public readonly GUIalignment alignment; //Enum with the TextAnchor Options
    public readonly bool DrawBox;

    #endregion

    #region Subtitle Constructor with Text , TextColor, bool drawBox
    public SubtitleAttribute(string text, string HEX_text = "#C0C0C0", bool drawBox = true)
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = GUIalignment.MidLeft;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets Bool
        DrawBox = drawBox;
    }
    #endregion

    #region Subtitle Constructor with Text, Alignment, TextColor, bool drawBox
    public SubtitleAttribute(string text, GUIalignment textAlignment,
        string HEX_text = "#C0C0C0", bool drawBox = true)
    {
        //Sets Text
        this.text = text;
        //Sets Alignment
        alignment = textAlignment;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString(HEX_text, out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets Bool
        DrawBox = drawBox;
    }
    #endregion
}
#endregion



#region HelpBox Attribute
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class HelpBoxAttribute : PropertyAttribute
{
    #region Variables

    public readonly string text;
    public readonly HelpBoxMessageType type;

    #endregion

    #region Constructor with text, HelpBoxType
    public HelpBoxAttribute(string helpBoxText, HelpBoxMessageType helpBoxType = HelpBoxMessageType.InfoBox)
    {
        this.text = helpBoxText;
        type = helpBoxType;
    }
    #endregion
}
#endregion