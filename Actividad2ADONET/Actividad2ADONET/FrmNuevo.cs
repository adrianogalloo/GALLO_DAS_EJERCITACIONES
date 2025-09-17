using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2ADONET
{
    public partial class FrmNuevo : Form
    {
        private int? id;
        public FrmNuevo(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (this.id != null)
                cargarDatos();

        }

        private void cargarDatos()
        {
            PersonaDB pdb = new PersonaDB();
            Persona persona = pdb.buscarPersona((int)id);
            txtnombre.Text = persona.nombre;
            txtedad.Text = persona.edad.ToString();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PersonaDB personaDB = new PersonaDB();
            if (personaDB.correcto())
            {
                try
                {
                    if (id != null)
                    {
                        string nombre = txtnombre.Text;
                        int edad = int.Parse(txtedad.Text);
                        personaDB.ModificarPersona(nombre, edad, (int)id);
                        MessageBox.Show("Persona modificada correctamente");
                        this.Close();
                        return;
                    }
                    if (id == null)
                    {
                        string nombre = txtnombre.Text;
                        int edad = int.Parse(txtedad.Text);
                        personaDB.AgregarPersona(nombre, edad);
                        MessageBox.Show("Persona agregada correctamente");
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
            }
        }
    }
}
