using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    // I would make these adjustable via the Inspector
    [SerializeField] float MouseZoomSpeed = 15.0f;
    [SerializeField] float TouchZoomSpeed = 0.1f;
    [SerializeField] float ZoomMinBound = 0.1f;
    [SerializeField] float ZoomMaxBound = 179.9f;
    [SerializeField] Camera cam;

    public Slider slider;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
   

    // Use this for initialization
    void Start()
    {
        if(!cam) cam = GetComponent<Camera>();
        
        slider.minValue = ZoomMinBound;
        slider.maxValue = ZoomMaxBound;
        slider.value = cam.fieldOfView;
        slider.onValueChanged.AddListener(OnSliderValueChanged);

        obj1.SetActive(false);
        obj2.SetActive(false);
        obj3.SetActive(true);
        obj4.SetActive(true);
        obj5.SetActive(true);
        obj6.SetActive(false);
        obj7.SetActive(true);
        obj11.SetActive(false);
        
    }

    private void OnSliderValueChanged(float newValue)
    {
        cam.fieldOfView = newValue;
    }

    void LateUpdate()
    {   
        var scroll = -Input.GetAxis("Mouse ScrollWheel");

        Zoom(scroll, MouseZoomSpeed);

        slider.value = cam.fieldOfView;
    }

    public void FOV()
    {
        obj1.SetActive(true);
        obj3.SetActive(false);
        obj4.SetActive(false);
        obj5.SetActive(false);
        obj6.SetActive(true);
        obj7.SetActive(false);
    }

    public void Resolution()
    {
        obj1.SetActive(false);
        obj3.SetActive(false);
        obj4.SetActive(false);
        obj5.SetActive(false);
        obj6.SetActive(true);
        obj7.SetActive(false);
        obj9.SetActive(true);
        obj10.SetActive(true);
    }

    public void Grapichs()
    {
        obj11.SetActive(true);
        obj3.SetActive(false);
        obj4.SetActive(false);
        obj5.SetActive(false);
        obj6.SetActive(true);
        obj7.SetActive(false);
    }

    public void Back()
    {
        obj8.SetActive(false);
    }

    public void Back2()
    {
        obj3.SetActive(true);
        obj4.SetActive(true);
        obj5.SetActive(true);
        obj6.SetActive(false);
        obj7.SetActive(true);
        obj1.SetActive(false);
        obj9.SetActive(false);
        obj10.SetActive(false);
        obj11.SetActive(false);
    }

    public void FullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        Debug.Log("FullScreen");
    }

    public void BorderlessWindow(bool is_fullscene)
    {
        Screen.fullScreen = is_fullscene;

        Debug.Log("Borderless Window");
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    void Zoom(float deltaMagnitudeDiff, float speed)
    {
        cam.fieldOfView += deltaMagnitudeDiff * speed;

        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, ZoomMinBound, ZoomMaxBound);
    }
}