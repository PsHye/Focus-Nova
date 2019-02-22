using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalvariables : MonoBehaviour
{
    public static float aireRestante;
    public static int crystalCount;
    public Text crystalText;
    public Text toxicityText;
    
    public static bool zonaSegura = false;

    void Start()
    {
        crystalCount = 200;
        aireRestante = 40;
    }

    
    void Update()
    {
        if (!zonaSegura)
        {
           aireRestante -= 0.01f;
        } 
        
        
        crystalText.text = crystalCount.ToString();
        toxicityText.text = Mathf.RoundToInt(aireRestante).ToString();
        if (aireRestante <= 0)
        {
            aireRestante = 0;
        }
    }
}
