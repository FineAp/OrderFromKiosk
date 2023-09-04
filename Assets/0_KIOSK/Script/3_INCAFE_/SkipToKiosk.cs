using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipToKiosk : MonoBehaviour
{
   public GameObject[] skips = new GameObject[4];

   public void Skips()
   {
    skips[0].SetActive(false);
    Destroy(skips[1]);
    skips[2].SetActive(false);

    skips[3].SetActive(true);
   }
}
