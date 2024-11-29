using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] cars;

    void Start()
    {
        StartCoroutine("SpawnTimer");
    }

    void Spawncar()
    {
        float randomPos = Random.Range(1.8f, -1.8f);

        Instantiate(cars[Random.Range(0, cars.Length)], new Vector2(randomPos, 7), Quaternion.identity);
    }

    IEnumerator SpawnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Spawncar();
        }
    }
}
