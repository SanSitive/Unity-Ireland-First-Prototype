using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject balls;
    private float squareBound = 3;
    public int ballNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<ballNumber; i++)
        {
            Instantiate(balls, GenerateRandomPos(),balls.transform.rotation);
        }
        
    }

    // Generate random position
    Vector3 GenerateRandomPos()
    {
        float randomX = Random.Range(-squareBound, squareBound);
        float randomZ = Random.Range(-squareBound, squareBound);
        float randomY = Random.Range(0, squareBound);
        return new Vector3(randomX, randomY, randomZ);
    }
}
