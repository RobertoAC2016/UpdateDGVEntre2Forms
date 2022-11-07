using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateDGVFromOtherForm
{
    public partial class windowtwo : Form
    {
        //Aqui recibes el parametro por la instaciacion
        private Form1 principal;
        public Form1 secundary;
        public windowtwo()
        {
            InitializeComponent();
        }
        public windowtwo(Form1 obj)
        {
            InitializeComponent();
            principal = obj;
        }
        private void btnload_Click(object sender, EventArgs e)
        {
            //Aqui ya puedes mandar a llamar la funcion de reload de carga de datos

            var datos = DB.loaddatos();
            datos.Add(new user { id = 6, name = "Mario", lastname = "Mora", age = 51, status = "active" });
            datos.Add(new user { id = 7, name = "Diana", lastname = "Reyes", age = 42, status = "active" });
            //esta funcion ya existe en la otra forma q estas referenciando
            principal.OnReloadData(datos);
        }

        private void btnsec_Click(object sender, EventArgs e)
        {//aqui usamos la otra forma de mandar a llamar la funcion reload por medio de la forma de parametro
            var datos = DB.loaddatos();
            datos.Add(new user { id = 6, name = "Mario", lastname = "Mora", age = 51, status = "active" });
            datos.Add(new user { id = 7, name = "Diana", lastname = "Reyes", age = 42, status = "active" });
            //esta funcion ya existe en la otra forma q estas referenciando
            principal.OnReloadData(datos);
        }
    }
}
