using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    public Camera camera1;
    public Camera camera2;
    public GameObject player;
    public Camera myCamera;

    void Start()
    {
        StartCoroutine (Test());
        myCamera.fieldOfView = 70f;
    }
    

    IEnumerator Test()
    {
        camera1.enabled = false;
        camera2.enabled = true;

        yield return new WaitForSeconds(10f);
        Debug.Log("done");

        camera1.enabled = true;
        camera2.enabled = false;
    }
}
