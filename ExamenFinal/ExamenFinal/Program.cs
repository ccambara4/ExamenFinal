﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListasTipoCola1
{
    
    class Cola
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz, fondo;

        public Cola()
        {
            raiz = null;
            fondo = null;
        }

        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void Insertar(int info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig = null;
            if (Vacia())
            {
                raiz = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.sig = nuevo;
                fondo = nuevo;
            }
        }

        public int Extraer()
        {
            if (!Vacia())
            {
                int informacion = raiz.info;
                if (raiz == fondo)
                {
                    raiz = null;
                    fondo = null;
                }
                else
                {
                    raiz = raiz.sig;
                }
                return informacion;
            }
            else
                return int.MaxValue;
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            Console.WriteLine("Listado de todos los elementos de la cola.");
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Cola cola1 = new Cola();
            cola1.Insertar(5);
            cola1.Insertar(10);
            cola1.Insertar(50);
            cola1.Imprimir();
            Console.WriteLine("Extraemos uno de la cola:" + cola1.Extraer());
            cola1.Imprimir();
            Console.ReadKey();
        }
    }
}

namespace ListasTipoPila1
{
    class Pila
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz;

        public Pila()
        {
            raiz = null;
        }

        public void Insertar(int x)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = x;
            if (raiz == null)
            {
                nuevo.sig = null;
                raiz = nuevo;
            }
            else
            {
                nuevo.sig = raiz;
                raiz = nuevo;
            }
        }

        public int Extraer()
        {
            if (raiz != null)
            {
                int informacion = raiz.info;
                raiz = raiz.sig;
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            Console.WriteLine("Listado de todos los elementos de la pila.");
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Pila pila1 = new Pila();
            pila1.Insertar(10);
            pila1.Insertar(40);
            pila1.Insertar(3);
            pila1.Imprimir();
            Console.WriteLine("Extraemos de la pila:" + pila1.Extraer());
            pila1.Imprimir();
            Console.ReadKey();
        }
    }
}