using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{
    public GameObject botonGO;
    public CoheteScript coheteScript; // referenciando al script de cohete
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        botonGO.SetActive(false);
        coheteScript.Despegue(); // poniendo la funcion en la variable de boton
        
    }

    void OnMouseUp()
    {
        botonGO.SetActive(true);
    }

   
}
