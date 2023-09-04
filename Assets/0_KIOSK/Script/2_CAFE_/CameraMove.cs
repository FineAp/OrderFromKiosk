using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float delTime;
    public float camSpeed = 0.01f;
    public GameObject cam;
    public GameObject delButton;
    
    public void ButtonDownCamMove()
    {
        StartCoroutine("CamMoveCoroutine");
        Destroy(delButton, delTime);
    }



    IEnumerator CamMoveCoroutine()
    {
        int count = 27;
        for (float i = 0f; i <= count; i += 0.1f)
        {
            
            cam.transform.Translate(0f, 0f, camSpeed * Time.deltaTime);
            // cam.transform.Rotate(1f * Time.deltaTime, 0f, 0f);
            if (i <= 9.4f)
            {
                Debug.Log(i);
                cam.transform.Rotate(-15f * Time.deltaTime, 0f, 0f);
                if (i <= 0.8f)
                {
                    cam.transform.Translate(0.87f * Time.deltaTime, 0f, 0f);
                }
                else
                {
                    cam.transform.Translate(0f, 0f, 0f);
                }
            }

            else
            {
                Debug.Log(i);
                cam.transform.Rotate(0f, 0f, 0f);
            }
            yield return null;
        }
    }
}
