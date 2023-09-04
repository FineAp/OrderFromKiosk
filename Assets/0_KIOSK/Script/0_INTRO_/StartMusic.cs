using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMusic : MonoBehaviour
{
    public GameObject bgm;

    void FixedUpdate()
    {
        Scene scene = SceneManager.GetActiveScene();
    
        if(scene.name ==("2__CAFE__"))
        {
            Destroy(bgm);
        }
        else
        {
            DontDestroyOnLoad(bgm);
        }
    }
    
}
