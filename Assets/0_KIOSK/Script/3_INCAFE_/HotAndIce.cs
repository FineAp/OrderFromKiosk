using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotAndIce : MonoBehaviour
{
    public GameObject[] hot = new GameObject[5];
    public GameObject[] ice = new GameObject[5];

    public void Hot()
    {
        hot[0].SetActive(true);
        ice[0].SetActive(false);
        hot[1].SetActive(true);
        ice[1].SetActive(false);
        hot[2].SetActive(true);
        ice[2].SetActive(false);
        hot[3].SetActive(true);
        ice[3].SetActive(false);
        hot[4].SetActive(true);
        ice[4].SetActive(false);
        hot[5].SetActive(true);
        ice[5].SetActive(false);

    }

    public void Ice()
    {
         ice[0].SetActive(true);
        hot[0].SetActive(false);
         ice[1].SetActive(true);
        hot[1].SetActive(false);
         ice[2].SetActive(true);
        hot[2].SetActive(false);
         ice[3].SetActive(true);
        hot[3].SetActive(false);
         ice[4].SetActive(true);
        hot[4].SetActive(false);
         ice[5].SetActive(true);
        hot[5].SetActive(false);
   
    }
}
