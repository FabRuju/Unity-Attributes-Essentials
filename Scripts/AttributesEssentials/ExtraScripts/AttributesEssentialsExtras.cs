using UnityEditor;
using UnityEngine;

public enum GUIalignment
{
    #region Upper Alignment
    UpLeft = TextAnchor.UpperLeft,
    UpCenter = TextAnchor.UpperCenter,
    UpRight = TextAnchor.UpperRight,
    #endregion

    #region Middle Alignment
    MidLeft = TextAnchor.MiddleLeft,
    MidCenter = TextAnchor.MiddleCenter,
    MidRight = TextAnchor.MiddleRight,
    #endregion

    #region Bottom Alignment
    BottomLeft = TextAnchor.LowerLeft,
    BottomCenter = TextAnchor.LowerCenter,
    BottomRight = TextAnchor.LowerRight
    #endregion
}

public enum HelpBoxMessageType
{
    EmptyBox = MessageType.None,
    WarningBox = MessageType.Warning,
    ErrorBox = MessageType.Error,
    InfoBox = MessageType.Info
}

public enum GUIFontStyle
{
    NormalStyle = FontStyle.Normal,
    BoldStyle = FontStyle.Bold,
    ItalicStyle = FontStyle.Italic,
    Bold_Italic_Style = FontStyle.BoldAndItalic
}

public class Craft
{
    public static Texture2D MyTexture2D(Color color, int width, int height)
    {
        var texture = new Texture2D(width, height);
        var pix = new Color[width * height];
        for (int i = 0; i < pix.Length; i++)
        {
            pix[i] = color;
        }
        texture.SetPixels(pix);
        texture.Apply();
        return texture;
    }
}

