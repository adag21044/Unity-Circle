using System.Collections;
using UnityEngine;

public class LineSpawner : MonoBehaviour
{
    [SerializeField] private GameObject lastLinePrefab;
    [SerializeField] private GameObject linePrefab;
    private GameObject newLineObject;
    [SerializeField] private float spawnTime;

    private void Start()
    {
        StartCoroutine(CreateNewLineObject());
    }

    IEnumerator CreateNewLineObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);

            // Instantiate the new line object
            //newLineObject = Instantiate(linePrefab, lastLinePrefab.transform.GetChild(0).transform.GetChild(0).GetComponent<Transform>().position, transform.rotation);
            newLineObject = Instantiate(linePrefab, lastLinePrefab.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);

            // Set the new line as the last line
            lastLinePrefab = newLineObject;
        }
    }
}
