using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public GameObject[] sound = new GameObject[5];


    void Start()
    {
        Invoke("One", 0.1f);
        Invoke("Two", 4f);
        Invoke("Three", 8.4f);
        Invoke("Four", 11.5f);
        Invoke("Five",16f);
    }

    void One()
    {
        Instantiate(sound[0]);
    }

    void Two()
    {
        Instantiate(sound[1]);
    }

    void Three()
    {
        Instantiate(sound[2]);
    }

    void Four()
    {
        Instantiate(sound[3]);
    }
    void Five()
    {
        Instantiate(sound[4]);
    }

}
