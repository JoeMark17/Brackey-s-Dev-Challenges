using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorsAnimations : MonoBehaviour
{
    [SerializeField]
    TMP_Text easyText;
    public string easyCharacter;

    private void Awake()
    {
        //easyText.color = new Color32(255, 128, 0, 255);
        easyCharacter = easyText.text;
        StartCoroutine(TypeSentence(easyCharacter));

        //Debug.Log(easyCharacter);
        
        
        // for (int i = 0; i < easyText.text.Length; i++)
        // {
        //     easyCharacter[i] = easyText.text.Substring (i, 1);
        //     Debug.Log(easyCharacter[i]);

            

        //    // easyCharacter[i].color = UnityEngine.Random.ColorHSV();

        // }
 
    }
    IEnumerator TypeSentence (string textAnimation)
    {
        foreach (char letter in textAnimation)
        {
            Debug.Log(letter);
            yield return null;
        }

    }
    
}
