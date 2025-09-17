namespace Actividad2ADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Refrescar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmNuevo frm = new FrmNuevo();
            frm.ShowDialog();
            Refrescar();
        }

        private void Refrescar()
        {
            PersonaDB personaDB = new PersonaDB();
            dgvTabla.DataSource = personaDB.listarPersonas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerIdSeleccionado();
            if (id != null)
            {
                FrmNuevo frm = new FrmNuevo(id);
                frm.ShowDialog();
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        #region HELPER
        private int? ObtenerIdSeleccionado()
        {
            try
            {
                return int.Parse(dgvTabla.Rows[dgvTabla.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerIdSeleccionado();
            if (id != null)
            {
                PersonaDB personaDB = new PersonaDB();
                if (personaDB.correcto())
                {
                    try
                    {
                        personaDB.EliminarPersona((int)id);
                        MessageBox.Show("Persona eliminada correctamente");
                        Refrescar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}