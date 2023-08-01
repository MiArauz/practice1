using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace primer_proyecto.Controllers;

public class Ejercicio1controller : Controller
{
    public string Index()
    {
        return "Esto es una prueba de controladores";
    }

    public string saludo(string nombre = "Mynor", int edad = 21)
    {
        return "Hola soy " + nombre + " y mi edad es: " + edad;
    }

    public string reversa(string text){
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public string mayuscula(string nombre)
    {
        string mayus, revermayu;
        mayus = nombre.ToUpper();
        revermayu = reversa(mayus);
        return revermayu;
    }

    public string compare(string cadena1, string cadena2)
    {
        int resut = cadena1.CompareTo(cadena2);
        if(resut == 0)
        {
            return "Las cadenas de texto ingresadas son iguales";
        }
        else
        {
            return "Las cadenas ingresadas no son iguales";
        }
    }

    public IActionResult perfil()
    {
        return View();
    }

}