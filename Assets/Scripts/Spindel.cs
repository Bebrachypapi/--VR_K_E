using UnityEngine;

public class Spindel : MonoBehaviour
{
    public bool isRotate;
    void Start()
    {
        
    }
    public void Start_Stop()
    {
        isRotate=!isRotate;
    }
    void Update()
    {
        if (isRotate)
        {
            gameObject.transform.Rotate(0,1,0);
        }
    }
}
