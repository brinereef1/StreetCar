using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundLooping : MonoBehaviour
{
    [SerializeField] MeshRenderer bg;
    [SerializeField] float speed;

    private void Awake()
    {
        bg = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        speed = SpeedIncrease.instance.roadSpeed;
        bg.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
    }

   
}
