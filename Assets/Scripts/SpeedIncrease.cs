using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpeedIncrease : MonoBehaviour
{
    public static SpeedIncrease instance;

    public float acceleration = 5f;

    public float roadSpeed = .5f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        StartCoroutine(Sequence());
    }

    IEnumerator Sequence()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            acceleration += .2f;
            roadSpeed += .1f;
        }
    }
}
