namespace WinFormsApp25
{
    public partial class Form1 : Form
    {
        Profesor profesorcito;
        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizaProfesor()
        { 
            ListViewItem fila = new ListViewItem(profesorcito.Id.ToString());
            fila.SubItems.Add(profesorcito.Nombre);
            fila.SubItems.Add(profesorcito.NumeroSeguro.ToString());
            fila.SubItems.Add(profesorcito.DiasTrabajados.ToString());
            fila.SubItems.Add(profesorcito.NominaNeta().ToString());
            fila.SubItems.Add(profesorcito.NominaImpuesto().ToString());
            lsvDatos.Items.Add(fila);   

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string tipoEmpleado=cbEmpleado.Text;

            switch (tipoEmpleado)
            {
                case "Profesor":
                    profesorcito = new Profesor(int.Parse(txtId.Text), txtNombre.Text,
                        txtNumeroSeguro.Text,int.Parse(txtDiasTrabajados.Text));
                    ActualizaProfesor();
                    break;
            
            }


        }
    }
}
