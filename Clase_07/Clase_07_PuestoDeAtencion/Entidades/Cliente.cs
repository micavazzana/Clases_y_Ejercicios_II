﻿using System;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre 
        {
            get
            {
                return this.nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }
        public Cliente(int numero)
        {
            this.numero = numero; 
        }
        public Cliente(int numero,string nombre) :this(numero)
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Numero == c2.Numero;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
