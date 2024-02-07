using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;

    private bool jumpKeyWasPressed;
    private float horizontalInput;
    [SerializeField] private float horizontalSpeed = 4;
    private Rigidbody rigidBodyComponent;
    private int superJumpsRemaining;
    public int health;
    public int maxHealth = 10;

    // public static Vector3 lastCheckPointPos = new Vector3(0, 2, 0);

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            jumpKeyWasPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");

        /*
        // Mouse direction to rotate entire player
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        // */
    }

    // FixedUpdate is called once every physic update
    private void FixedUpdate()
    {
        rigidBodyComponent.velocity = new Vector3(horizontalInput, rigidBodyComponent.velocity.y, 0);
        rigidBodyComponent.velocity = new Vector3(horizontalInput * horizontalSpeed, rigidBodyComponent.velocity.y, 0);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }

        if (jumpKeyWasPressed)
        {
            float jumpPower = 5f;
            if (superJumpsRemaining > 0)
            {
                jumpPower *= 1.5f;
                superJumpsRemaining--;
            }
            rigidBodyComponent.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            Destroy(other.gameObject);
            superJumpsRemaining++;
            // System.Threading.Thread.Sleep(2000);
        }

        if (other.gameObject.layer == 10)
        {
            // Screen fade out
            // Wait a few seconds
            // // System.Threading.Thread.Sleep(2000);
            // New scene loads in via fade in
            Application.LoadLevel(1);
            // GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
        }

        if (other.gameObject.layer == 12)
        {
            Application.LoadLevel(2);
        }

        if (other.gameObject.layer == 11)
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.layer == 13)
        {
            // Application.LoadLevel(3);
            SceneManager.LoadScene(3);
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            {
                Scene thisScene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(thisScene.name);
            }
        }
    }
}
