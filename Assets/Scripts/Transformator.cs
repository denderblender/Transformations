using UnityEngine;

public class Transformator : MonoBehaviour
{
    protected void Move(float moveSpeed)
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    protected void Rotate(float rotateSpeed)
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    protected void Scale(float scaleSpeed)
    {
        transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
    }
}