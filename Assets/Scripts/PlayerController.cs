using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float rotationAngle;
    [SerializeField] float rotationSpeed;
    [SerializeField] AudioSource coinCollect;
    [SerializeField] AudioSource carCrash;

    private float horizontalInput = 0f;

    void Update()
    {
        Movement(horizontalInput);
        Rotation();
    }

    public void SetHorizontalInput(float input)
    {
        horizontalInput = input; // Set input based on button press
    }

    void Movement(float direction)
    {
        Vector2 pos = transform.position;

        pos += new Vector2(direction * speed * Time.deltaTime, 0);

        pos.x = Mathf.Clamp(pos.x, -1.8f, 1.8f);

        transform.position = pos;
    }

    void Rotation()
    {
        if (horizontalInput < 0) // Left
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, rotationAngle), rotationSpeed * Time.deltaTime);
        }
        else if (horizontalInput > 0) // Right
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -rotationAngle), rotationSpeed * Time.deltaTime);
        }
        else // Neutral
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), rotationSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            coinCollect.Play();
        } else if (collision.tag == "ObstacleCar")
        {
            carCrash.Play();
        }
    }
}
