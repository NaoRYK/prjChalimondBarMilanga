using System.Text;

namespace prjChalimondBarMilanga
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }
        string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
        bool datosValidados = false;
        float[,] valoresGrilla;
        private void frmVentas_Load(object sender, EventArgs e)
        {
            dgvDatos.Columns[0].HeaderText = "Mozos";

            foreach (string mozo in mozos)
            {
                dgvDatos.Rows.Add(mozo);
            }
            valoresGrilla = new float[dgvDatos.Rows.Count, dgvDatos.Columns.Count];
            btnMejorMozo.Enabled = datosValidados;
            btnTotal.Enabled = datosValidados;
        }

        private void Validar()
        {
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                if (dgvDatos.Rows[i].IsNewRow) continue; // evito fila vacía


                for (int j = 1; j < dgvDatos.Columns.Count; j++)
                {


                    object valorCelda = dgvDatos.Rows[i].Cells[j].Value;
                    if (float.TryParse(Convert.ToString(valorCelda), out float resultado))
                    {
                        valoresGrilla[i, j] = resultado;
                    }
                    else
                    {
                        MessageBox.Show($"El valor en fila {i + 1}, columna {j + 1} no es un número válido.");
                        return;
                    }



                }
            }
            datosValidados = true;
            btnMejorMozo.Enabled = datosValidados;
            btnTotal.Enabled = datosValidados;

        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void btnMejorMozo_Click(object sender, EventArgs e)
        {
            if (valoresGrilla == null)
            {
                MessageBox.Show("Primero validá los datos con el botón 'Validar'.");
                return;
            }

            Validar();
            float maxTotal = float.MinValue;
            string mejorMozo = "";

            for (int i = 0; i < mozos.Length; i++)
            {
                float suma = 0;

                for (int j = 1; j < dgvDatos.Columns.Count; j++)
                {
                    suma += valoresGrilla[i, j];
                }
                if (suma > maxTotal)
                {
                    maxTotal = suma;
                    mejorMozo = mozos[i];
                }
            }

            txtResultados.Text = mejorMozo + " Con un aporte de $" + maxTotal.ToString("0.00"); ;

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {


            if (valoresGrilla == null)
            {
                MessageBox.Show("Primero validá los datos con el botón 'Validar'.");
                return;
            }
            Validar();
            int cantCategorias = dgvDatos.Columns.Count - 1; // 
            float[] totalesPorCategoria = new float[cantCategorias];
            float totalGeneral = 0;


            for (int i = 0; i < mozos.Length; i++)
            {
                for (int j = 1; j < dgvDatos.Columns.Count; j++)
                {
                    float valor = valoresGrilla[i, j];
                    totalesPorCategoria[j - 1] += valor;
                    totalGeneral += valor;
                }
            }


            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" Totales por categoría:");

            for (int k = 1; k < cantCategorias; k++)
            {
                sb.AppendLine($"Categoría {dgvDatos.Columns[k].HeaderText}: {totalesPorCategoria[k]:0.00}");
            }

            sb.AppendLine();
            sb.AppendLine($"Total general vendido: {totalGeneral:0.00}");

            txtResultados.Text = sb.ToString();
        }
    }
}
