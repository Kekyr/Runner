using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    private Transform target;
    private Vector3 offset = new Vector3(0.01f, 3.3f, -4f);
    private Vector3 cameraVelocity;
    private float smoothTime = 0.001f;


    private void Start()
    {
        target = FindObjectOfType<PlayerMovement>().transform;
    }

    
    private void FixedUpdate()
    {
        var targetPosition = target.TransformPoint(offset);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref cameraVelocity, smoothTime);
    }
}
