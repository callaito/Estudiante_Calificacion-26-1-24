namespace Estudiante_Calificacion_26_1_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int nota1, nota2, nota3, nota4, promedio;
            string Situacion = " ";

            nota1 = int.Parse(txt_Nota_1.Text);
            nota2 = int.Parse(txt_Nota_2.Text);
            nota3 = int.Parse(txt_Nota_3.Text);
            nota4 = int.Parse(txt_Nota_4.Text);

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            txt_Promedio.Text = promedio.ToString();

            if (promedio >= 70)
            {
                Situacion="Aprobado";
                txt_Promedio.ForeColor = Color.Green;
                txt_Situacion.ForeColor = Color.Green;
            }
            else
            {
                Situacion="Reprodado";
                txt_Promedio.ForeColor = Color.Red;
                txt_Situacion.ForeColor = Color.Red;
            }
            txt_Situacion.Text = Situacion;
        }




        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nota_1.Clear();
            txt_Nota_2.Clear();
            txt_Nota_3.Clear();
            txt_Nota_4.Clear();
            txt_Situacion.Clear();
            txt_Promedio.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}