using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camion : Vehiculo
{
    public int numeroPuertas = 0, capacidadCarga = 0, cargaActual = 0;

    public override void Acelerar()
    {
        Debug.Log ( Nombre + " esta acelerando" + Velocidad + "km/h");
    }
}
