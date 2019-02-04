using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalvariables : MonoBehaviour
{
    public static float aireRestante;//PASAR A INT POR CADA SEGUNDO QUE PASA
    public static int crystalCount;
    public Text crystalText;
    public Text toxicityText;
    
    
    //aire
    public static bool zonaSegura = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
        crystalCount = 200;
        aireRestante = 40;
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(globalvariables.aireRestante.ToString());
        if (!zonaSegura)
        {
            aireRestante -= 0.01f;
        }
        else
        {
            aireRestante = 40f;
        }
        
        crystalText.text = crystalCount.ToString();
        toxicityText.text = Mathf.Round(aireRestante).ToString();
        if (aireRestante <= 0)
        {
            aireRestante = 0;
        }
    }
}
