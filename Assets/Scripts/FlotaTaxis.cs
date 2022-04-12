using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaTaxis : MonoBehaviour
{
    //Una flota de taxis tiene una cantidad determinada de unidades.
    //Se calcula que cada unidad recorre unos 90 km por día y que cada litro de combustible permite recorrer 15 km.
    //Se calcula también que los días de lluvia se trabaja más, llegando a un recorrido de 110 km por unidad.
    //Teniendo en cuenta que el litro de combustible cuesta $130, 

    // debemos hacer un programa que nos permita calcular 
    // el costo del combustible para una flota completa de taxis en un período de días determinado.

    //El programa debe devolver la información calculada mediante un mensaje en el siguiente formato:
    //“Una flota de[cantidadDeUnidades] unidades trabajando durante[periodoDeDias] días implicará un gasto de[costoTotalCombustible]
    //pesos en concepto de combustible”.

    public int cantidadUnidades; 
    public int cantidadDias; 
    public int cantidadDiasLluvia;

    void Start()
    {

        int costoTotalCombustible = 6 * 130;
        int costoTotalCombustibleLluvia = 8 * 130;
        int calculo = cantidadUnidades * costoTotalCombustible;

        if (cantidadDias < 5)
        {
            Debug.Log("Error");
        }
        else if (cantidadDiasLluvia < 0)
        {
            Debug.Log("Error");
        }
        else if (cantidadDiasLluvia > cantidadDias)
        {
            Debug.Log("Error");
        }
        else if (cantidadDias >= 5)
        {
             if(cantidadDiasLluvia > 0)
            {
                int resta = cantidadDias - cantidadDiasLluvia;
                int calculo2 = costoTotalCombustibleLluvia * cantidadUnidades;
                int costoDiasConLluvia = calculo2 * cantidadDiasLluvia;
                int costoDiasSinLluvia = calculo * resta;
                int costoDiasSinLLuviaYConLluvia = costoDiasSinLluvia + costoDiasConLluvia;
                Debug.Log($"Una flota de {cantidadUnidades} unidades trabajando durante {cantidadDias} dias implicara un gasto de ${costoDiasSinLLuviaYConLluvia} pesos en concepto de combustible");

            } else if (cantidadDiasLluvia == 0)
            {
                Debug.Log($"Una flota de {cantidadUnidades} unidades trabajando durante {cantidadDias} dias implicara un gasto de ${calculo * cantidadDias} pesos en concepto de combustible");
            }
        }
        else
        {
            Debug.Log("Error");
        }

        
           

        
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
