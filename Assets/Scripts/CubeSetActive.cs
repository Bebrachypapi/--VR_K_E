using UnityEngine;
using TMPro;

public class CubeSetActive : MonoBehaviour
{
    public TMP_Text label, button_lbl;
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Cude_Act()
    {
        cube.SetActive(!cube.activeSelf);
        if (cube.activeSelf)
        {
            label.text = "Включен";
            button_lbl.text = "Выключить";
        }
        else{
            label.text = "Выключен";
            button_lbl.text = "Включить";
        }
    }
}
