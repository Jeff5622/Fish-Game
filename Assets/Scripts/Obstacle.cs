using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject prefab;

    public float spawnRate = 1f;

    public float min = -1f;

    public float max = 1f;
    // Start is called before the first frame update
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    // Update is called once per frame
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    
    private void Spawn()
    {
        GameObject Obstacle = Instantiate(prefab, transform.position, Quaternion.identity);
        Obstacle.transform.position += Vector3.up * Random.Range(min, max);
    }
}

