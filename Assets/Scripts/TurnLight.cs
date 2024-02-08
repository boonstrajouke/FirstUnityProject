using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{
    public GameObject light;
    private bool on = false;

    // Use this for initialization
    void OnTriggerStay(Collider collider)
    {
        if (gameObject.layer == 15)
        {
            light.SetActive(true);
            on = true;
        }
        else if (gameObject.layer == 15 && Input.GetKeyDown(KeyCode.E) && on)
        {
            light.SetActive(false);
            on = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
