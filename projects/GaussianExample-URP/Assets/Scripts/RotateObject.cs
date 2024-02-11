using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float speed = 40;
    void Update()
    {
        transform.Rotate(0,speed*Time.deltaTime,0);
    }
}
