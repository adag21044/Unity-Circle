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
        // Move the object left in world space
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime, Space.World);
    }
}
