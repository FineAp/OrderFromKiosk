using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManag : MonoBehaviour
{
    public void ToIntro()
    {
        SceneManager.LoadScene("0__INTRO__");
    }

    public void ToMain()
    {
        SceneManager.LoadScene("1__MAIN__");
    }

    public void ToInGame()
    {
        SceneManager.LoadScene("2__CAFE__");

    }

    public void ToInCafe()
    {
        SceneManager.LoadScene("3__INCAFE__");
    }

    public void Last()
    {
        SceneManager.LoadScene("4__LAST__");
    }


    public void Quits()
    {
        Application.Quit();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cam"))
        {
            SceneManager.LoadScene("3__INCAFE__");
        }
    }

}
