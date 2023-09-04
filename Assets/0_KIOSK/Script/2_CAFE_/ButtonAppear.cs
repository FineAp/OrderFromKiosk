using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonAppear : MonoBehaviour
{
    public GameObject button;
    public GameObject lastText;
    //플레이어와 닿을 시 버튼 생성
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            button.SetActive(true);
            lastText.SetActive(false);
        }
    }
}
