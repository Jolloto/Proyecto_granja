using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 30f;
    [SerializeField] private float bottomBound = -10f;

    // Update is called once per frame
    void Update()
    {
        // Comida

        if (transform.position.z > topBound) 
        {
            Destroy(gameObject);
        }

        //Animales

        if (transform.position.z < bottomBound) 
        {Destroy(gameObject); }
    }
}
