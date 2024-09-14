using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInputController : MonoBehaviour
{
    public bool isTouching = false;

    private void Update()
    {
        HandleCircleInput();
    }

    private void HandleCircleInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isTouching = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isTouching = false;
        }
    }

    public bool GetIsTouching()
    {
        return isTouching;
    }
}
