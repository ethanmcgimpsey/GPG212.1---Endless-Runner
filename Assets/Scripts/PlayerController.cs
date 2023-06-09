using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float jumpForce = 5f;

    private Rigidbody playerRigidbody;
    public GameObject gameOver;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // playerRigidbody.velocity = new Vector3(0f, playerRigidbody.velocity.y, moveSpeed);

        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0f, 0f);
        playerRigidbody.velocity = movement * moveSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Zombie")
        {
            Debug.Log("You dead");
            gameOver.SetActive(true);
        }
    }
}
