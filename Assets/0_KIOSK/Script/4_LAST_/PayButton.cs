using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PayButton : MonoBehaviour
{
    
    public Text tx;
    public string m_text;

    public float textSpeed;
    public float startCount = 0f;
    public float destroyTime = 7f;


    public GameObject retryBTN;
    public GameObject payBTN;
    private GameObject bankAnim;
    Animator anim;

    void Awake()
    {
        bankAnim = GameObject.Find("Text_Bank");
        anim = bankAnim.GetComponent<Animator>();
    }
    public void ButtonPay()
    {
        Destroy(retryBTN);
        payBTN.SetActive(true);

        Invoke("TextTypingCoroutine", startCount);
        Destroy(payBTN,destroyTime);
        Invoke("Animation", destroyTime);


    }
    public void Animation()
    {
        anim.SetTrigger("isBank");
        print("Start Anim");
        
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
