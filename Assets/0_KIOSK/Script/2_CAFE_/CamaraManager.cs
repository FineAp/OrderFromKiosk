using UnityEngine;

public class CamaraManager : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = offset + target.transform.position;
    }
}
