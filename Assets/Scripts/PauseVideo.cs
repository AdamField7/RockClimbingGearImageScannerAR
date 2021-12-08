using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class PauseVideo : MonoBehaviour
{
    public Camera ARCamera;
    VideoPlayer vid;

    private void Start()
    {
        vid = gameObject.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = ARCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;
                if (Physics.Raycast(ray, out hitObject))
                {
                    if(hitObject.transform.tag == "Prefab")
                    {
                        vid = hitObject.transform.GetComponent<VideoPlayer>();
                        if (vid.isPaused == false)
                        {
                            vid.Pause();
                        }
                        else
                        {
                            vid.Play();
                        }
                    }
                }
            }
        }
    }
}