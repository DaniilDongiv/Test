using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    [SerializeField]
    private CarController _car;

    [SerializeField]
    private Vector3 _positionCamera;

    void Start()
    {
        _car = FindObjectOfType<CarController>();
    }

    
    void LateUpdate()
    {
        transform.position = _car.transform.position + _positionCamera;
    }
}
