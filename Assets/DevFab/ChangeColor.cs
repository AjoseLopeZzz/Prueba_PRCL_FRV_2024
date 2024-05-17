using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Light luz; // Referencia a la luz que quieres cambiar
    public string nombreColor = "white";
    public float intensidadLuz = 1f;

    [SerializeField] private Slider _slider;
    

    void Start()
    {
        // Aquí puedes asignar la luz desde el inspector si quieres
        // Si la referencia no está asignada desde el inspector, la buscamos automáticamente
        if (luz == null)
        {
            luz = GetComponent<Light>();
        }
        _slider.onValueChanged.AddListener((e) =>
        {
            intensidadLuz = e;
        });
    }

    void Update()
    {
        // Cambiar el color y la intensidad de la luz
        //CambiarColorPorNombre(nombreColor); // Cambia "orange" por el nombre del color que desees
        CambiarIntensidad(intensidadLuz); // Cambia 1.5f por el valor de intensidad que desees
    }

    public void CambiarColorPorNombre(string nombreColor)
    {
        Debug.Log("Deberia funcionar");
        Color color;
        if (ColorUtility.TryParseHtmlString(nombreColor, out color))
        {
            luz.color = color;
        }
        else
        {
            Debug.LogWarning("El nombre del color especificado no es válido.");
        }
    }

    void CambiarIntensidad(float intensidad)
    {
        luz.intensity = intensidad;
    }
    public void SwitchBombillo()
    {
        luz.enabled = !luz.enabled;
    }
    
}
