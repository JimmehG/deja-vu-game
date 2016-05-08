using UnityEngine;
using System.Collections;

public class MouseFollow : MonoBehaviour
{
    public GameObject follower;



    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.x += 0.5f;
        mouse.y -= 0.5f;
        mouse.z = -9;
        transform.position = mouse;
    }
}
