using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objeto que la c�mara seguir�
    public float smoothSpeed = 0.125f; // Velocidad de suavizado del movimiento de la c�mara
    public Vector3 offset; // Desplazamiento de la c�mara con respecto al objeto

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
