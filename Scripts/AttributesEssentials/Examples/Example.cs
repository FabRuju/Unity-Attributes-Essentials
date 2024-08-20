using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Setup Viejo
public class Example : MonoBehaviour
{
    //[Header("Hola, soy un Header")]
    [H1("Hi, this is a big size Header", GUIalignment.MidCenter, "#D0D0D0", "#6A6A6A")]
    [Subtitle("And I'm its subtitle", GUIalignment.MidCenter, "#D0D0D0")]
    [H2("This is a medium size Header", GUIalignment.MidCenter, "#D0D0D0", "#6A6A6A")]
    [Subtitle("With its subtitle", GUIalignment.MidCenter, "#D0D0D0")]
    [H3("This is a small header", GUIalignment.MidCenter, "#D0D0D0", "#6A6A6A")]
    [Subtitle("Use subtitles only on H1, H2, H3 attributes!", GUIalignment.MidCenter,"#D0D0D0")]    
    [URL("My example URL. It will link you to a Stackoverflow string page", 
        "https://stackoverflow.com/questions/15433188/what-is-the-difference-between-r-n-r-and-n")]
    [HelpBox("This is a HelpBox, you can use it to clearify or specify things up =)", HelpBoxMessageType.WarningBox)]
    [Hyperlink("https://docs.unity3d.com/ScriptReference/GUIStyle.html", "This is a Hyperlink on a Variable")]
    public int _myVariableA;
    public int _myVariableB;
    public int _myVariableC;
    public Color _myColor1;
    public Texture2D _myTexture1;

    [Header("Mis variables 1")]
    public int _myVariableD;
    public int _myVariableE;
    public int _myVariableF;

    // Start is called before the first frame update
    void Start()
    {
        //Do stuff
    }

    // Update is called once per frame
    void Update()
    {
        //Do stuff
    }

    public void myFunction()
    {

    }
}
#endregion
