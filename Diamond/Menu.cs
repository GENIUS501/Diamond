using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diamond
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Tipo_Productos_Click(object sender, EventArgs e)
        {
            try
            {
                ListaTipoProducto frm = new ListaTipoProducto();
                frm.Usuario = 1;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
