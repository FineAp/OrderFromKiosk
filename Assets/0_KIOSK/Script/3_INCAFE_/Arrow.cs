using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ArrowDestroy", 13.0f);
        Destroy(arrow, 30f);    
    }

    void ArrowDestroy()
    {
        arrow.SetActive(true);
        
    }
}
