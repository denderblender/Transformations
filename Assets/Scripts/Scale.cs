using UnityEngine;

public class Scale : Transformator
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        Scale(_scaleSpeed);
    }
}
