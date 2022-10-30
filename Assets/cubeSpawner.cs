using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeSpawner : MonoBehaviour
{
    public GameObject cubeToSpawn;
    private float t;
    // Start is called before the first frame update
    void Start()
    {
        t = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - t > 2f)
        {
            GameObject.Instantiate(cubeToSpawn, new Vector3(Random.Range(-10f, 10f), transform.position.y, 0), Quaternion.identity);
            t = Time.time;
        }
    }
}
