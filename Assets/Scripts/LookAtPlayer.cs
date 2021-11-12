using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public GameObject camera;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(camera.transform);
        gameObject.transform.eulerAngles = new Vector3(0, gameObject.transform.eulerAngles.y, 0);
        gameObject.transform.Rotate(Vector3.up, 180);
    }
}
