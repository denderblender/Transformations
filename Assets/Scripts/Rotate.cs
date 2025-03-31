using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {
        ChangeRotation();
    }

    private void ChangeRotation()
    {
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
    }
}
