﻿using Microsoft.Win32;
using System.Text.RegularExpressions;
namespace ejercicio_06_Lamparitas
{
//    Una empresa que se dedica a la comercialización de lámparas de bajo consumo, registra de sus ventas, los siguientes datos: marca y cantidad.El precio de cada lamparita es de $150 (Sin importar la marca).
//El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.
//A.Si compra 6 lamparitas o más, tiene un descuento del 50%.
//B.Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40% y si es de otra marca, el descuento es del 30%.
//C.Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25%, y si es de otra marca el descuento es del 20%.
//D.Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15%, si es “FelipeLamparas se hace un descuento del 10% y si es otra marca, 5%.
//E.Si el importe final con descuento suma más de $950, se debe agregar el 10% de ingresos brutos.
//Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento, y si corresponde total de ingresos brutos y total a pagar.

    internal class Program
    {
        static void Main(string[] args)
        {
        string cantidadDeLamapritasTexto;
        int cantidadDeLamapritas;
        int precioLamparita;
        double descuento;
        double precioTotal;
        double precioConDescuento;
        double ingresosBrutos;
        double totalAPagar;
        string marcaLamparita;
        string marcaLampa;
        double valorDescuento;

        precioLamparita = 150;
            Console.WriteLine("hola, por favor ingrese la cantidad de lamparitas que quiere comprar: ");
        cantidadDeLamapritasTexto = Console.ReadLine();
        cantidadDeLamapritas= int.Parse(cantidadDeLamapritasTexto);
        Console.WriteLine("Que marca va a comprar? :");
        marcaLamparita= Console.ReadLine();

        if (cantidadDeLamapritas > 6)
        {
            descuento= 0.50;
        }
        if (cantidadDeLamapritas == 5 && marcaLamparita == "argentina luz")
        {
            descuento=0.40;
        }
            else 
            {
            descuento=0.30;

            }

        if (cantidadDeLamapritas == 4 && marcaLamparita == "argentinaluz" || marcaLamparita == "felipelamparas")
        {
            descuento=0.25;
        }
        else
        {
            descuento=0.20;
        }
        if (cantidadDeLamapritas==3 && marcaLamparita == "argentinaluz")

        {
            descuento=0.15;

        }
        if (cantidadDeLamapritas == 3 && marcaLamparita =="felipelamparas")
        {
            descuento=0.10;

        }
        else
        {
            descuento=0.05;
        }
            precioTotal=cantidadDeLamapritas*precioLamparita;
            valorDescuento=precioTotal*descuento;
            totalAPagar= precioTotal-valorDescuento;
            if (totalAPagar > 950)
            {

            }

        }
    }
}
