using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private int i;

    void Start()
    {
        i = 3; 
    }

    void Update()
    {
        i++;
        Debug.Log($"{gameObject.name}:{i}".Replace(" ", ""));
    }
}