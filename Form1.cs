using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_01
{
    public partial class Form1 : Form
    {
        ListaEnlazadaSimple milista = new ListaEnlazadaSimple(); //instancia para utilizar los metodos que existen en la clase lista a traves de un objeto
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Listbox.Items.Clear();
            milista.insertar(int.Parse(btnIngresarnumero.Text)); //de esta manera lo llamo 
            milista.mostrar(Listbox);
        }

    }
}
