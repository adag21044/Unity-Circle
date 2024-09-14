using UnityEngine;

public class CircleDataTransmitter : MonoBehaviour
{
    [SerializeField] private CircleInputController circleInputController;

    public bool GetIsTouching()
    {
        return circleInputController.isTouching;
    }
}
