using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteScript : MonoBehaviour
{
    float coheteSpeed = 0; // creando variable
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,coheteSpeed,0);   //Linea de codigo para mover un objeto (translate)
    }

    public void Despegue()
    {
        coheteSpeed = 0.1f; // referenciando variable en la funcion
    }
}
