using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform CameraTransform;
    Vector3 velocity = Vector3.zero;

    [Range(0, 1)]
    public float smoothTime;

    public Vector3 positionOffset;

    private void Awake(){

        CameraTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void LateUpdate(){

        Vector3 CameraPosition = CameraTransform.position + positionOffset;
        transform.position = Vector3.SmoothDamp(transform.position, CameraPosition, ref velocity, smoothTime);


    }
}
