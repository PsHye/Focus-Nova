using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class AireRestanteVignete : MonoBehaviour
{
    PostProcessVolume m_Volume;
    Vignette m_Vignette;

    public float frecuencia = 5f; //frecuencia en la que hace el Sin

    void Start()
    {
        m_Vignette = ScriptableObject.CreateInstance<Vignette>();
        m_Vignette.enabled.Override(true); //se hace override a los parametros que se quiere editar
        m_Vignette.opacity.Override(0);

        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, m_Vignette); //se lo pasa a una lista de lo que queremos editar
    }

    void Update()
    {
        if (globalvariables.aireRestante < 10f)
        {
            m_Vignette.opacity.value = Mathf.Clamp(Mathf.Sin(Time.time * frecuencia), 0, .6f);
        }
        else //cuando aire restante vuelva a 40 necesitamos reiniciar el valor de viñeta
        {
            m_Vignette.opacity.value = 0f;
        }
        
        //m_Vignette.intensity.value = Mathf.Clamp(Mathf.Sin(Time.time * frecuencia) , 0, .35f);
        //m_Vignette.intensity.value = Mathf.Clamp(Mathf.Sin(Time.realtimeSinceStartup) * 3, 0, .35f);
    }

    void OnDestroy()
    {
        RuntimeUtilities.DestroyVolume(m_Volume, true, true);
    }

}
