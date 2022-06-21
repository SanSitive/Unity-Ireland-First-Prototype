using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartForce : MonoBehaviour
{

    private float startForce = 8;

    private float ceilBound = 4;
    
    private Rigidbody objectRb;
    private float slowForce = 2;

    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
        Vector3 randomForce = GenerateRandomForce();
        objectRb.AddForce(randomForce, ForceMode.Impulse);
        objectRb.AddTorque(randomForce);
    }

    // Update is called once per frame
    void Update()
    {
        //If object's vertical position is above a certain height, slow down
        if(transform.position.y > ceilBound)
        {
            transform.Translate(transform.position.x, ceilBound, transform.position.z);
            Vector3 oppositeDirection = new Vector3(transform.position.x, -transform.position.y, transform.position.z);
            Debug.Log($"Force = {slowForce} and opposite direction = {oppositeDirection}");
            objectRb.AddForce(-oppositeDirection , ForceMode.Impulse);
        }

    }

    

    Vector3 GenerateRandomForce()
    {
        float randomX = Random.Range(-startForce, startForce);
        float randomY = Random.Range(-startForce, startForce);
        float randomZ = Random.Range(-startForce, startForce);
        return new Vector3(randomX, randomY, randomZ);
    }
}
