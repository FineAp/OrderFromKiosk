using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEffect : MonoBehaviour
{
    public Text tx;
    public string m_text;

    public float textSpeed;
    public float startCount = 0f;


    void Awake()
    {
        Invoke("TextTypingCoroutine", startCount);

    }
    public void TextTypingCoroutine()
    {
        StartCoroutine(_typing());
    }
    IEnumerator _typing()
    {
        yield return new WaitForSeconds(0f);
        for (int i = 0; i <= m_text.Length; i++)
        {
            tx.text = m_text.Substring(0, i);
            yield return new WaitForSeconds(textSpeed);

        }
    }

}
