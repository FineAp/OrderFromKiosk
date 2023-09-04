using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int playerSpeed = 2;
    public float playerRotation = 30f;
    public float moveTime = 18f;
    public float destroyTime= 0;
    
    Animator anim;

    void Start()
    {
        Invoke("Rotations", 18f);
        Destroy(gameObject,destroyTime);
        
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        Invoke("Move", moveTime);
    }
    void Move()
    {
        transform.Translate(0,0,playerSpeed * Time.deltaTime);

        anim.SetTrigger("ToWalk");
        
    }
    void Rotations()
    {
        transform.Rotate(0f, playerRotation, 0f);
    }


}
