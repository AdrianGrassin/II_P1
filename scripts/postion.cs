using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectPositionLogger : MonoBehaviour
{
    void Start()
    {
        // Obtener la posición del objeto
        Vector3 position = transform.position;

        // Mostrar la posición en la consola
        Debug.Log("Posición del objeto " + gameObject.name + ": " + position + "| Tag: " + gameObject.tag);
    }
}