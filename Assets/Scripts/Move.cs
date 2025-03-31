using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        ChangePosition();
    }

    private void ChangePosition()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
