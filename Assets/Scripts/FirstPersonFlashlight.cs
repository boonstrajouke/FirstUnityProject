using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonFlashlight : MonoBehaviour
{
    public KeyCode flashLightOnOff = KeyCode.F;
    public KeyCode otherFlashLightOnOff = KeyCode.G;
    [SerializeField] GameObject FlashlightLight;
    [SerializeField] GameObject OtherFlashlightLight;
    private bool FlashlightActive = false;
    private bool OtherFlashLightActive = false;

    // Start is called before the first frame update
    void Start()
    {
        FlashlightLight.gameObject.SetActive(false);
        OtherFlashlightLight.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(flashLightOnOff))
        {
            if (FlashlightActive == false)
            {
                FlashlightLight.gameObject.SetActive(true);
                FlashlightActive = true;
            }
            else
            {
                FlashlightLight.gameObject.SetActive(false);
                FlashlightActive = false;
            }
        }
        if (Input.GetKeyDown(otherFlashLightOnOff))
        {
            if (OtherFlashLightActive == false)
            {
                OtherFlashlightLight.gameObject.SetActive(true);
                OtherFlashLightActive = true;
            }
            else
            {
                OtherFlashlightLight.gameObject.SetActive(false);
                OtherFlashLightActive = false;
            }
        }
    }
}
