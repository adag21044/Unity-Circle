using UnityEngine;

public class CircleDataTransmitter : MonoBehaviour
{
    [SerializeField] private CircleInputController circleInputController;
    [SerializeField] private CircleScoreController circleScoreController;

    public bool GetIsTouching()
    {
        return circleInputController.isTouching;
    }

    public void IncreaseScoreValue()
    {
        circleScoreController.IncreaseScore();
    }
}
