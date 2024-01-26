using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCheckPoint : MonoBehaviour
{
    public Player playerHitCheckPointOne;
    public bool isHit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HitSpawnPoint(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isHit = true;
        }
    }
}
