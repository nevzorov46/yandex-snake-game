using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float moveSpeed = 5f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
    }
}
