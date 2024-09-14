using UnityEngine;

public class LineRotation : MonoBehaviour
{
    [SerializeField] private float rotationValue;
    [SerializeField] private float randomRotation;

    void Start()
    {
        GenerateRandomRotation();
        SetLineRotation();    
    }
    private void GenerateRandomRotation()
    {
        randomRotation = Random.Range(-rotationValue, randomRotation);
    }

    private void SetLineRotation()
    {
        transform.rotation = Quaternion.Euler(0, 0, randomRotation);
    }
}
