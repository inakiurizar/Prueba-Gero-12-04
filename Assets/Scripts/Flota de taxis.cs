using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flotadetaxis : MonoBehaviour
{
    //Una flota de taxis tiene una cantidad determinada de unidades.
    //Se calcula que cada unidad recorre unos 90 km por día y que cada litro de combustible permite recorrer 15 km.
    //Se calcula también que los días de lluvia se trabaja más, llegando a un recorrido de 110 km por unidad.
    //Teniendo en cuenta que el litro de combustible cuesta $130, debemos hacer un programa que nos permita calcular 
    //el costo del combustible para una flota completa de taxis en un período de días determinado.

    //El programa debe devolver la información calculada mediante un mensaje en el siguiente formato:
    //“Una flota de[cantidadDeUnidades] unidades trabajando durante[periodoDeDias] días implicará un gasto de[costoTotalCombustible]
    //pesos en concepto de combustible”.

    //El programa debe devolver un mensaje de error y no realizar ningún cálculo
    //si la cantidad de días total es menor que 5 o si la cantidad de días de lluvia es negativa o mayor que la cantidad total de días.

    public int cantidadUnidades; // cada litro 15 km - 90km 6 litros - 110km 8 litros
    public int cantidadDias; // si son 10 dias, y 3 de lluvia, son 10 totales {cantidadDias - cantidadDiasLluvia}
    public int cantidadDiasLluvia;

    void Start()
    {
        if(cantidadDias < 5 || cantidadDiasLluvia < 0 || cantidadDiasLluvia > cantidadDias)
        {
            Debug.Log("Error");
        }
        int precioUnidad = cantidadUnidades * (6 * 130);

        Debug.Log(precioUnidad);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
