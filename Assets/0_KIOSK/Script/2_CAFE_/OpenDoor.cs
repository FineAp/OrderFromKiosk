using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public int closeSpeed = 1;
    public float xDir = 0.1f;
    public float endCorutineTime = 0.1f;

    public GameObject target;

    public void OnCollisionEnter(Collision collision)
    {
        //플레이어와 닿을시 문열림, 플레이어 삭제
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine("DoorCoroutine");
            Destroy(this,endCorutineTime);
            Destroy(target);
        }
        
    }


    //문 자연스럽게 열림
     IEnumerator DoorCoroutine()
    {
        int count = 60;
        for(float i = 0f; i <= count; i+= 0.01f)
        {
            transform.Translate(xDir * Time.deltaTime, 0f, 0f);
            // print(i);
            yield return null;
        }
    }

}
