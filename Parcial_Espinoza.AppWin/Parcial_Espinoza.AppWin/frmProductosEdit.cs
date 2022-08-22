using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Espinoza.AppWin
{
    public partial class frmProductosEdit : Form
    {
        string cadenaConexion = "server=localhost; database=Parcial; Integrated Security=true";
        public frmProductosEdit()
        {
            InitializeComponent();
        }

        private void frmProductosEdit_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            using(var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                var sql = "SELECT * FROM Categoria";
                using (var comando = new SqlCommand(sql, conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Dictionary<string, string> CategoriaSource = new Dictionary<string, string>();
                            while (lector.Read())
                            {
                                CategoriaSource.Add(lector[2].ToString(), lector[1].ToString());
                            }
                            cboCat.DataSource = new BindingSource(CategoriaSource, null);
                            cboCat.DisplayMember = "Name";
                            cboCat.ValueMember = "Key";
                        }
                    }
                }
            }
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
