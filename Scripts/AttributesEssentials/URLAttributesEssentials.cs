using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region TextURL Attribute

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class URLAttribute : PropertyAttribute
{
    #region Variables 

    public readonly string text, url; //String for the text shown on inspector and the URL where it would guide
    public readonly Color HEX_Color; //Color of the text   
    public readonly GUIalignment alignment; //Enum with the TextAnchor Options
    public readonly bool DrawBox;

    #endregion

    #region URL Constructor with Text , Hyperlink, bool drawBox
    public URLAttribute(string text, string urlHyperlink, bool drawBox = true)
    {
        //Sets Text
        this.text = text;
        //sets URL
        url = urlHyperlink;
        //Sets Alignment
        alignment = GUIalignment.MidLeft;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString("#8299F3", out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets Bool
        DrawBox = drawBox;
    }
    #endregion

    #region URL Constructor with Text , Hyperlink, alignment, bool drawBox
    public URLAttribute(string text, string urlHyperlink, GUIalignment textAlignment, bool drawBox = true)
    {
        //Sets Text
        this.text = text;
        //sets URL
        url = urlHyperlink;
        //Sets Alignment
        alignment = textAlignment;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString("#8299F3", out Color _myHEXColor) ? _myHEXColor : Color.gray;
        //Sets Bool
        DrawBox = drawBox;
    }
    #endregion
}
#endregion

#region Property URL
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class HyperlinkAttribute : PropertyAttribute
{
    #region Variables 

    public readonly string url, Tooltip; //String for the text shown on inspector and the URL where it would guide
    public readonly Color HEX_Color; //Color of the text   

    #endregion

    #region Hyperlink Constructor with Hyperlink, bool drawBox
    public HyperlinkAttribute(string urlHyperlink, string tooltip = "Click to go to the link")
    {
        //sets URL
        url = urlHyperlink;
        //Sets Tooltip
        Tooltip = tooltip;
        //Sets Text Color
        HEX_Color = ColorUtility.TryParseHtmlString("#8299F3", out Color _myHEXColor) ? _myHEXColor : Color.gray;
    }
    #endregion
}
#endregion
