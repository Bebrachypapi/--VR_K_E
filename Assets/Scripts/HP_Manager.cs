using UnityEngine;
using TMPro;

public class HP_Manager : MonoBehaviour
{
    public int HP = 10;
    public TMP_Text label_hp;
    
    void Start()
    {
        label_hp.text = HP.ToString();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Target")
        {
            HP--;
            
            if (HP < 0) HP = 0;
            
            label_hp.text = HP.ToString();
        }
    }
}