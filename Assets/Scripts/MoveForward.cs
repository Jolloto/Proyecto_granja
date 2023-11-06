using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float verticalInput;
    [SerializeField] private float speed = 10f;

    
    public void Update()
    {
        // Movimiento hacia delante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
