using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCharacterInfo : MonoBehaviour
{
    public Text text;

    void Start()
    {
        Invoke("DebugCharacterInfo", 1);
    }

    void DebugCharacterInfo()
    {
        CharacterInfo characterInfo;
        text.font.GetCharacterInfo(text.text[0], out characterInfo, text.font.fontSize, text.fontStyle);
        Debug.LogFormat("Character '{0}' width = {1} height = {2} advance = {3}",
            text.text[0],
            characterInfo.glyphWidth,
            characterInfo.glyphHeight,
            characterInfo.advance);
    }

    void Update()
    {

    }
}
