using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.Translate(new Vector2(0, -speed * Time.deltaTime));

        if (transform.position.y < -7)
        {
            Destroy(this.gameObject);
            Debug.Log("destroyed");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerCar")
        {
            Destroy(this.gameObject);
        }
    }
}
