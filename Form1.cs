using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRUEBA_TECNICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CDatos datos = new CDatos();
        CLIENTE cliente = new CLIENTE();
        private int no_dui;
        private void CargarGrid()
        {
            var Lst = datos.Read();
            TBL_CLIENTE.DataSource = Lst;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarDatos()
        {

            // cliente.no_dui = Convert.ToString(no_dui);
            cliente.no_dui = no_dui;
            cliente.no_dui = Convert.ToInt32(txtDUI.Text);        
            cliente.Nombre = txt_nombre.Text;
            cliente.Telefono = txt_telefono.Text;


        }
        private void Deshabilitar(){

             txtDUI.Enabled = false;
        }
        private void Habilitar()
        {
            txtDUI.Enabled = true;
        }


           
       

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (txtDUI.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el DUI", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_nombre.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Nombre", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_telefono.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Telefono", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            else
            {
                CargarDatos();
                datos.Create(cliente);
                MessageBox.Show("Datos agregados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

            }
           
        }



        public void limpiar()
        {
           
            txtDUI.Focus();
            txtDUI.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            
            CargarGrid();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //if (no_dui > 0)
            //{
            //    CargarDatos();
            //    datos.Update(cliente);
            //    MessageBox.Show("Datos Actualizados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    limpiar();
            //}           
            //else
            //{
            //   MessageBox.Show("Edita un Registro", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            if(no_dui > 0)
            {
                CargarDatos();

                datos.Update(cliente);
                MessageBox.Show("Datos Actualizados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
               

        private void btn_eliminar_Click(object sender, EventArgs e)
        {



            //CargarDatos();
            //datos.Delete(no_dui);
            //MessageBox.Show("Datos eliminados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //limpiar();

            if (DialogResult.Yes == MessageBox.Show("Esta seguro de Eliminar el registro Seleccionado", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                CargarDatos();
                datos.Delete(no_dui);
                MessageBox.Show("Datos eliminados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al eliminar", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(txt_busqueda.Text != string.Empty)
            {
                var Lst = datos.buscardui(Convert.ToInt32(txt_busqueda.Text));
                TBL_CLIENTE.DataSource = Lst;
            }
        }

        private void btn_borrar_filtro_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Informacion",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Habilitar();          
            limpiar();
            CargarGrid();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TBL_CLIENTE_Click(object sender, EventArgs e)
        {
            Deshabilitar();

            no_dui = Convert.ToInt32(TBL_CLIENTE.CurrentRow.Cells["no_dui"].Value.ToString());
            txtDUI.Text = TBL_CLIENTE.CurrentRow.Cells["no_dui"].Value.ToString();
            txt_nombre.Text = TBL_CLIENTE.CurrentRow.Cells["Nombre"].Value.ToString();
            txt_telefono.Text = TBL_CLIENTE.CurrentRow.Cells["Telefono"].Value.ToString();
        }

       
    }
}
