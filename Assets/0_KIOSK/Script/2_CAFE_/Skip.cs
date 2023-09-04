using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip : MonoBehaviour
{
    public GameObject on;
    public GameObject off;
    public GameObject player;
    public GameObject sound;
    public GameObject leftDoor;
    public GameObject rightDoor;


    public float doorSpeed;

    int playerSpeed = 2;
    int playerRotation = 30;

    public void skip()
    {
        on.SetActive(false);
        off.SetActive(true);
        Destroy(player);
        Destroy(sound);

        StartCoroutine("DoorCoroutine");
        
        Destroy(leftDoor, 1f);
        Destroy(rightDoor, 1f);

    }
    
    IEnumerator DoorCoroutine()
    {
        int count = 10;
        for(float i = 0f; i <= count; i+= 0.01f)
        {
            leftDoor.transform.Translate(doorSpeed * Time.deltaTime, 0f, 0f);
            rightDoor.transform.Translate(-doorSpeed * Time.deltaTime, 0f, 0f);

            // print(i);
            yield return null;
        }
    }
}
