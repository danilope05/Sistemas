using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moto : Vehiculo
{
    public int numeroPuertas;
    public string tipoManillar = "";
    
    public override void Acelerar() 
    {
        Debug.Log(Nombre + " esta acelerando a" + Velocidad + " km/h");
    }
}
