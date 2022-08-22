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
    public partial class frmProductos : Form
    {
        DataTable dtProducto;
        string cadenaConexion = "server=localhost; database=Parcial; Integrated Security = true;";
        public frmProductos()
        {
            InitializeComponent();
            dtProducto = new DataTable();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmProductosEdit();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var nombre = ((TextBox)frm.Controls["txtNombre"]).Text;
                var marca = ((TextBox)frm.Controls["txtMarca"]).Text;
                var precio = ((TextBox)frm.Controls["txtPrecio"]).Text;
                var stock = ((ComboBox)frm.Controls["cboStock"]).Text;
                var categoria = ((ComboBox)frm.Controls["cboCat"]).SelectedValue.ToString();

                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    var sql = "INSER INTO Producto (Nombre ,Marca, Precio," +
                        "Stock, Categoria) VALUES (@nombre, " +
                        "@marca, @precio, @stock, @categoria)";


                    using(var comando = new SqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@marca", marca);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@stock", stock);
                        comando.Parameters.AddWithValue("@categoria", categoria);
                        var resultado = comando.ExecuteNonQuery();
                        if(resultado > 0)
                        {
                            MessageBox.Show("El producto ha sido registrado", "Sistemas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("El proceso de creacion del producto ha fallado.", "Sistemas",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void iniciarFormulario(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            dgvListado.Rows.Clear();
            using(var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var sql = "select IdProducto,A.Nombre, Marca, Precio, Stock, " +
                    " B.Nombre AS Categoria from Producto A " +
                    "INNER JOIN categoria B ON A.IdCategoria = B.IdCategoria " +
                    "AND A.Stock>5 AND A.Precio<=2500.00;";
                using(var comando = new SqlCommand(sql, conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if(lector != null && lector.HasRows)
                        {
                            while (lector.Read())
                            {
                                dgvListado.Rows.Add(lector[0], lector[1], lector[2]);
                            }
                        }
                    }
                }
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            
            var frm = new frmProductosEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    var sql = "UPDATE Producto SET Nombre =@nombre, Marca=@marca, " +
                        "Precio=@precio, Stock=@stock, Categoria=@categoria WHERE ID=@IdProducto";

                    var filaActual = dgvListado.CurrentRow;
                    if (filaActual != null)
                    {
                        var filaEditar = dtProducto.Rows[filaActual.Index];
                        var frmP = new frmProductosEdit();
                        var nombre = ((TextBox)frmP.Controls["txtNombre"]).Text = filaEditar["Nombre"].ToString();
                        var marca = ((TextBox)frmP.Controls["txtMarca"]).Text = filaEditar["Marca"].ToString();
                        var precio = ((TextBox)frmP.Controls["txtPrecio"]).Text = filaEditar["Precio"].ToString();
                        var stock = ((ComboBox)frmP.Controls["cboStock"]).Text = filaEditar["Stock"].ToString();
                        var categoria = ((ComboBox)frmP.Controls["cboCat"]).SelectedValue = filaEditar["Categoria"].ToString();

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            filaEditar["Nombre"] = ((TextBox)frm.Controls["txtNombre"]).Text;
                            filaEditar["Marca"] = ((TextBox)frm.Controls["txtMarca"]).Text;
                            filaEditar["Precio"] = ((TextBox)frm.Controls["txtPrecio"]).Text;
                            filaEditar["Stock"] = ((ComboBox)frm.Controls["cboStock"]).Text;
                            filaEditar["Categoria"] = ((ComboBox)frm.Controls["cboCat"]).SelectedValue;
                            using (var comando = new SqlCommand(sql, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombre", nombre);
                                comando.Parameters.AddWithValue("@marca", marca);
                                comando.Parameters.AddWithValue("@precio", precio);
                                comando.Parameters.AddWithValue("@stock", stock);
                                comando.Parameters.AddWithValue("@categoria", categoria);

                            }
                        }
                    }
                }
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var frm = new frmProductosEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    var sql = "DELETE FROM Producto WHERE ID=@IdProducto";

                    var filaActual = dgvListado.CurrentRow;
                    if (filaActual != null)
                    {
                        var filaEliminar = dtProducto.Rows[filaActual.Index];
                        filaEliminar.Delete();
                    }
                    using (var comando = new SqlCommand(sql, conexion))
                    {
                        comando.Parameters.Add("@id", SqlDbType.Int, 10, "ID");
                    }
                }
            }
        }
    }
}
