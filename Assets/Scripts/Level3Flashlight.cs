using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Flashlight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        // Doesn't work the correct way
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        // */


        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        float midPoint = (transform.position = Camera.main.transform.position).magnitude * 1;

        transform.LookAt(mouseRay.origin + mouseRay.direction * midPoint);
        // transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}
