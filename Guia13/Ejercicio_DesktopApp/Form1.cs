using Ejercicio1_Models;

namespace Ejercicio_DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sistema sistema = new Sistema();
        private void MostrarListaZonas()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (Paquete p in sistema.ListaPaquetes)
            {
                switch (p.ZonaDestino)
                {
                    case "1":
                        listBox1.Items.Add(p);
                        break;
                    case "2":
                        listBox2.Items.Add(p);
                        break;
                    case "3":
                        listBox3.Items.Add(p);
                        break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                try
                {
                    string path = openFileDialog1.FileName;
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sistema.Descargar(fs);
                    MostrarListaZonas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("surgio un error: " + ex.Message);
                }
                finally { if (fs != null) fs.Close(); }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(sistema.CamionesCargados());
        }

        int camionElegido = -1;

        private void btnIniciarCamion_Click(object sender, EventArgs e)
        {
            camionElegido = comboBox1.SelectedIndex;
            VerCarga();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete elegido = null;
            if (listBox3.Items.Count > 0)
            {
                elegido = listBox3.SelectedItems[0] as Paquete;
            }
            else if (listBox2.Items.Count > 0)
            {
                elegido = listBox2.SelectedItems[0] as Paquete;
            }
            else if (listBox1.Items.Count > 0)
            {
                elegido = listBox1.SelectedItems[0] as Paquete;
            }
            if (elegido != null && camionElegido > -1)
            {
                sistema.CargarPaquete(camionElegido, elegido);
                textBox1.Text += elegido.Peso;
                MostrarListaZonas();
                VerCarga();
            }
            else
            {
                MessageBox.Show("Seleccione un paquete");
            }

        }
        private void VerCarga()
        {
            listBox4.Items.Clear();
            if (camionElegido > -1)
            {
                listBox4.Items.AddRange(sistema.VerCargaCamion(camionElegido));
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (camionElegido > -1)
            {
                double peso = sistema.RetirarPaquete(camionElegido);
                textBox1.Text = peso.ToString("0.00");
                MostrarListaZonas();
                VerCarga();
            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                string nombre = $"{camionElegido.ToString("000")}carga.csv";
                fs = new FileStream(nombre, FileMode.OpenOrCreate, FileAccess.Write);
                sistema.RetirarCamion(fs, camionElegido);

                camionElegido = -1;
                comboBox1.SelectedIndex = camionElegido;
                MostrarListaZonas();
                VerCarga();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) { fs.Close(); }
            }
        }
    }
}
