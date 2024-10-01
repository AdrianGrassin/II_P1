using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movimiento : MonoBehaviour
{
    public float velocidad = 1.0f; // Velocidad de movimiento
    public Vector3 direccion = new Vector3(0, 1, 0); // Dirección de movimiento (por defecto hacia arriba)

    void Update()
    {
        // Mover el objeto en la dirección especificada a una velocidad determinada
        transform.position += direccion * velocidad * Time.deltaTime;
    }
}
