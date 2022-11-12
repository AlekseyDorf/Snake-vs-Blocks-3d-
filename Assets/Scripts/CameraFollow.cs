using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    
    void Update()
    {
        Vector3 transformPosition = transform.position;
        transformPosition.z = target.position.z - 4;
        transform.position = transformPosition;
    }
}
