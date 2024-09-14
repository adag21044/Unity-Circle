using UnityEngine;

public class CircleJumpController : MonoBehaviour
{
    [SerializeField] private CircleInputController circleInputController;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float circleJumpForce;

    private void FixedUpdate()
    {
        SetCircleJump();        
    }

    private void SetCircleJump()
    {
        if (circleInputController.GetIsTouching())
        {
            rb.velocity = Vector2.up * circleJumpForce;
        }
    }
}
