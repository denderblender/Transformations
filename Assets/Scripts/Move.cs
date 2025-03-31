using UnityEngine;

public class Move : Transformator
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        Move(_moveSpeed);
    }
}
