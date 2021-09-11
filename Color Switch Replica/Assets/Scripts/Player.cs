using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement Properties")]
    [SerializeField] private float jumpForce = 10f;

    [Header("Colour Properties")]
    [SerializeField] private string currentColour;
    [SerializeField] private Color[] colours;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        sr = this.GetComponent<SpriteRenderer>();

        ChangeColour();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void ChangeColour()
    {
        int index = Random.Range(0, colours.Length);

        switch (index)
        {
            case 0:
                currentColour = "Red";
                sr.color = colours[0];
                break;
            case 1:
                currentColour = "Blue";
                sr.color = colours[1];
                break;
            case 2:
                currentColour = "Yellow";
                sr.color = colours[2];
                break;
            case 3:
                currentColour = "Green";
                sr.color = colours[3];
                break;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(currentColour))
        {
            Debug.Log("I can pass");
        }
        else
        {
            Debug.Log("Game Over");
        }
    }

}
