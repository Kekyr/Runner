using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    private Transform _target;
    private Vector3 _offset = new Vector3(0.01f, 3.3f, -4f);
    private Vector3 _cameraVelocity;
    private float _smoothTime = 0.001f;


    private void Start()
    {
        _target = FindObjectOfType<PlayerMovement>().transform;
    }

    
    private void FixedUpdate()
    {
        var targetPosition = _target.TransformPoint(_offset);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _cameraVelocity, _smoothTime);
    }
}
