using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorVehiculos : MonoBehaviour
{

    public Carro carro;
    public Moto moto;
    public Camion camion;

    private Vehiculo vehiculoActual;

    public TextMeshProUGUI infoVehiculoText;

    void Start()
    {
        carro = new Carro { Nombre = "Carro Deportivo", Velocidad = 200, capacidadCombustible = 50, combustibleActual = 20, numeroPuertas = 2 };
        moto = new Moto { Nombre = "Moto de Carreras", Velocidad = 180, capacidadCombustible = 20, combustibleActual = 10, tipoManillar = "Deportivo" };
        camion = new Camion { Nombre = "Camion de Carga", Velocidad = 100, capacidadCombustible = 150, combustibleActual = 80, capacidadCarga = 1000, cargaActual = 500 };

        SeleccionarVehiculo(carro);  // Seleccionar coche por defecto al iniciar
    }

    public void SeleccionarVehiculo(Vehiculo vehiculo)
    {
        vehiculoActual = vehiculo;
        ActualizarInformacionVehiculo();
    }

    public void Acelerar()
    {
        if (vehiculoActual != null)
        {
            vehiculoActual.Acelerar();
            ActualizarInformacionVehiculo();
        }
    }

    public void Frenar()
    {
        if (vehiculoActual != null)
        {
            vehiculoActual.Frenar();
        }
    }

    public void Tanquear()
    {
        if (vehiculoActual != null)
        {
            vehiculoActual.Repostar(10);  // Repostar una cantidad fija de 10
            ActualizarInformacionVehiculo();
        }
    }

    private void ActualizarInformacionVehiculo()
    {
        infoVehiculoText.text = $"Nombre: {vehiculoActual.nombre}\n" +
                                $"Velocidad: {vehiculoActual.velocidad}\n" +
                                $"Combustible: {vehiculoActual.combustibleActual}/{vehiculoActual.capacidadCombustible}";
    }
}
