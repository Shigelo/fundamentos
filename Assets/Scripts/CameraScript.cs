using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed;
    public Vector3 cameraPosition;

    private void FixedUpdate() 
    {
        Vector3 playerPosition = target.position + cameraPosition;
        Vector3 position = Vector3.Lerp(transform.position, playerPosition, cameraSpeed * Time.deltaTime);

        transform.position = position;
    }
}
