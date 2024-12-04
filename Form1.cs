using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bot_agregar_Click(object sender, EventArgs e)
        {
            string ingreso = txt_ingreso.Text;
            lista.Items.Add(ingreso);
            MessageBox.Show("Registro Ingresado ");
            txt_ingreso.Clear();
            txt_ingreso.Focus();

        }

        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            if (lista.SelectedItem != null)
            {
                lista.Items.Remove(lista.SelectedItem);
            }
        }
    }
}
