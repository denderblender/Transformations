using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        ChangeScale();
    }

    private void ChangeScale()
    {
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
