using UnityEngine;

public class LineMovementControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.5f;

    private void Update()
    {
        MoveLine();
    }

    private void MoveLine()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
