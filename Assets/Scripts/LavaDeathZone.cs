using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDeathZone : MonoBehaviour
{
    public Player playerHealth;
    public int damage = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
