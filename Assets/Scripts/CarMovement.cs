using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        speed = SpeedIncrease.instance.acceleration;

        transform.Translate(new Vector2(0, -speed * Time.deltaTime));

        if (transform.position.y < -7)
        {
            Destroy(this.gameObject);
        }
    }

    
}
