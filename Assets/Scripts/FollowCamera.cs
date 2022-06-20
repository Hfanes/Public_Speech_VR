using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform cameraTransform;
    public float distanceFromCamera;
    private float camRotationSpeed = 50f;

    void Update()
    {
        Vector3 resultingPosition = cameraTransform.position + cameraTransform.forward * distanceFromCamera;
        transform.position = Vector3.Lerp(transform.position, resultingPosition, 0.01f);


        Quaternion newCamRotation = Quaternion.LookRotation(transform.position - cameraTransform.transform.position);
        newCamRotation = Quaternion.Slerp(transform.rotation, newCamRotation, camRotationSpeed * Time.smoothDeltaTime); //spherical lerp smoothing
        transform.rotation = newCamRotation;
    }
}
