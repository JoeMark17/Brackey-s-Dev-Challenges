using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorsAnimations : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI easyText;
    public string[] easyCharacter;

    private void Awake()
    {
        //easyText.color = new Color32(255, 128, 0, 255);
        easyCharacter = new string[easyText.text.Length];
        
        for (int i = 0; i < easyText.text.Length; i++)
        {
            easyText.color = UnityEngine.Random.ColorHSV();
            easyCharacter[i] = easyText.text.Substring (i, 1);
            Debug.Log(easyCharacter[i]);

            easyText.SetText($"{easyCharacter[i].AddColor(Color.red)}");

           // easyCharacter[i].color = UnityEngine.Random.ColorHSV();

        }
 
    }
}
