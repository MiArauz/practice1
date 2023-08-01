using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace primer_proyecto.Controllers
{
    public class Ejercicio2Controller : Controller
    {
        private List<string> listaCadenas = new List<string>
        {
            "cadena 0",
            "cadena 1",
            "cadena 2",
            "cadena 3",
            "cadena 4",
        };

        public string Buscar(string cadena)
        {
            int posicion = listaCadenas.IndexOf(cadena);

            if (posicion >= 0)
            {
                return $"La cadena '{cadena}' se encuentra en la posición {posicion} de la lista.";
            }
            else
            {
                return "La cadena no se encontró en la lista.";
            }
        }

        public string ubicacion(int posicion)
        {
            if (posicion >= 0 && posicion < listaCadenas.Count)
            {
                return $"El elemento en la posición {posicion} es: {listaCadenas[posicion]}";
            }
            else
            {
                return "Posición inválida";
            }
        }
    }
}
