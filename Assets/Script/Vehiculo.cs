using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculo : MonoBehaviour
{
    [SerializeField] public string nombre;
    [SerializeField] public float velocidad;
    [SerializeField] public int CapacidadCombustible;
    [SerializeField] public int combustibleActual;
     
    public virtual void Acelerar() 
    {
        Debug.Log(nombre + "esta acelerado a " + velocidad + "km/h");
    }
    public void Frenar() 
    {
        Debug.Log(nombre + " eta frenando ");
    }

    public void Tanquear ( int cantidad) 
    {
        combustibleActual += cantidad;

        if ( combustibleActual > CapacidadCombustible )
        {
        combustibleActual = CapacidadDeCombustible;
        
        }
        Debug.Log(nombre + " a tanqueado. CombustibleActual" + combustibleActual);


    }

}
