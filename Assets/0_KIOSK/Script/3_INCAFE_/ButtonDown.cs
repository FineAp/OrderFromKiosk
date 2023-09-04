using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDown : MonoBehaviour
{
    public GameObject takeout;
    public GameObject eatting;

    bool isTakeOut = false;
    bool isEatting = false;

    public void TakeOut()
    {
        if (isTakeOut == false && isEatting == false)
        {
            takeout.SetActive(true);
            isTakeOut = true;
            print(isTakeOut);
        }

        else if (isTakeOut == true)
        {
            print("isTakeOut = true");
            takeout.SetActive(false);
            isTakeOut = false;
        }

        else if (isEatting == true)
        {
            takeout.SetActive(true);
            eatting.SetActive(false);
            isTakeOut = true;
            isEatting = false;
        }

    }

    public void Eatting()
    {
        if (isTakeOut == false && isEatting == false)
        {
            eatting.SetActive(true);
            isEatting = true;
            print(isEatting);
        }

        else if (isEatting == true)
        {
            print("isEatting = true");
            eatting.SetActive(false);
            isEatting = false;
        }

        else if (isTakeOut == true)
        {
            eatting.SetActive(true);
            takeout.SetActive(false);
            isEatting = true;
            isTakeOut = false;
        }

    }
}
