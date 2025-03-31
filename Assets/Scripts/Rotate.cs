using UnityEngine;

public class Rotate : Transformator
{
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {
        Rotate(_rotateSpeed);
    }
}
