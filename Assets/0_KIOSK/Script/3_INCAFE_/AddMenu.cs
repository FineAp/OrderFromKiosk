using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMenu : MonoBehaviour
{
    public GameObject[] addShout = new GameObject[8];
    public GameObject[] addSizeUp = new GameObject[8];

    bool isShout = false;
    bool isSizeUp = false;

    public void AddShout()
    {
        if (isShout == false)
        {
            addShout[0].SetActive(false);
            addShout[1].SetActive(false);
            addShout[2].SetActive(false);
            addShout[3].SetActive(false);
            addShout[4].SetActive(false);
            addShout[5].SetActive(false);
            addShout[6].SetActive(false);
            addShout[7].SetActive(false);
            addShout[8].SetActive(false);


            isShout = true;
        }

        else if (isShout == true)
        {
            addShout[0].SetActive(true);
            addShout[1].SetActive(true);
            addShout[2].SetActive(true);
            addShout[3].SetActive(true);
            addShout[4].SetActive(true);
            addShout[5].SetActive(true);
            addShout[6].SetActive(true);
            addShout[7].SetActive(true);
            addShout[8].SetActive(true);


            isShout = false;
        }

    }

    public void AddSizeUp()
    {
        if (isSizeUp == false)
        {
            addSizeUp[0].SetActive(false);
            addSizeUp[1].SetActive(false);
            addSizeUp[2].SetActive(false);
            addSizeUp[3].SetActive(false);
            addSizeUp[4].SetActive(false);
            addSizeUp[5].SetActive(false);
            addSizeUp[6].SetActive(false);
            addSizeUp[7].SetActive(false);
            addSizeUp[8].SetActive(false);


            isSizeUp = true;
        }

        else if (isSizeUp == true)
        {
            addSizeUp[0].SetActive(true);
            addSizeUp[1].SetActive(true);
            addSizeUp[2].SetActive(true);
            addSizeUp[3].SetActive(true);
            addSizeUp[4].SetActive(true);
            addSizeUp[5].SetActive(true);
            addSizeUp[6].SetActive(true);
            addSizeUp[7].SetActive(true);
            addSizeUp[8].SetActive(true);


            isSizeUp = false;
        }
    }
}
