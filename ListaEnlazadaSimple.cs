using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_01
{
    public class ListaEnlazadaSimple
    {
        private Nodo primero = null;
        private Nodo ultimo = null;

        public void insertar(int num) 
        { 
            Nodo nuevo= new Nodo();
            nuevo.Numero = num;
            if(primero == null)   //cuando es el primer elemento
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo= nuevo;
            } else  //cuando ya existe el primer elemento
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
        }
        public void mostrar(ListBox List) 
        {
            Nodo actual = primero;
            while (actual != null)
            {
                List.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            }
        }
        public void eliminar(int num)
        {
            Nodo actual= primero;
            Nodo anterior = null;
            bool encontrado = false;

            while (actual != null) 
            {
                if(actual.Numero == num)
                {
                    if(actual== primero)
                    {
                        primero = primero.Siguiente;
                    } else if(actual==ultimo){
                        anterior.Siguiente = null;
                        ultimo = anterior;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    encontrado = true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
            if (encontrado == false)
                MessageBox.Show($"El numero {num} no esta en la lista");

        }
    }
}
