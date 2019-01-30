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
    public GameObject cajadeArenaobj;
    public GameObject plantitaobj;
    public GameObject iluminationObjectinterior;

    //INVENTARIO*************
    public static bool caja_de_arena_cristalizada = false;
    public static bool plantita_con_escafandra = false;
    public static bool ilumination = false;

    //Variables Radio.
    public static bool PiezaRadio1 = false;
    public static bool PiezaRadio2 = false;
    public static bool PiezaRadio3 = false;
    //aire
    public static bool zonaSegura = false;

    // Start is called before the first frame update
    void Start()
    {
        cajadeArenaobj.SetActive(false);
        plantitaobj.SetActive(false);
        iluminationObjectinterior.SetActive(false);

        crystalCount = 200;
        aireRestante = 40;
    }

    // Update is called once per frame
    void Update()
    {
        print(globalvariables.aireRestante.ToString());
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
