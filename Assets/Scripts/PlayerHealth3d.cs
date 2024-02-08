using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth3d : MonoBehaviour
{
    private Rigidbody rigidBodyComponent;
    public int health;
    public int maxHealth = 10;
    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
