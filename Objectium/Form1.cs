using Objectium.Clases;
namespace Objectium
{
    public partial class Form1 : Form
    {
        Kandolf kandolf = new Kandolf();
        Y especieY = new Y();
        X especieX = new X();
        Z especieZ = new Z();
        ClsNantium Nantium = new ClsNantium();

        dynamic ClaseUsada;
        public Form1()
        {
            InitializeComponent();
            comboEspecies.SelectedIndex = 0;
            comboColores.SelectedIndex = 0;
            comboBoxEspecies2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        private void btnKandolf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El ser vivo identificado como kandolf ha emitido el siguiente sonido:"
                                + " " + kandolf.EmitirSonido() + "!");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El ser vivo identificado como Y, perteneciente a la especie Kandolf, ha emitido el siguiente sonido:"
                                + " " + especieY.EmitirSonido() + "!");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El ser vivo identificado como X, perteneciente a la especie Kandolf, ha emitido el siguiente sonido:"
                                + " " + especieX.EmitirSonido() + "!");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El ser vivo identificado como Z, perteneciente a la especie Kandolf, ha emitido el siguiente sonido:"
                                + " " + especieZ.EmitirSonido() + "!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Hemos observado la especie Nantium, y vemos que es un gran corredor y sde color " + Nantium.GetColor());
        }

        private void comboEspecies_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboEspecies.SelectedItem.ToString() == "Kandolf")
            {
                ClaseUsada = new Kandolf();
            }
            else if (comboEspecies.SelectedItem.ToString() == "X")
            {
                ClaseUsada = new X();
            }
            else if (comboEspecies.SelectedItem.ToString() == "Y")
            {
                ClaseUsada = new Y();
            }
            else if (comboEspecies.SelectedItem.ToString() == "Z")
            {
                ClaseUsada = new Z();
            }
        }

        private void btnCambiarColor_Click_1(object sender, EventArgs e)
        {
            ClaseUsada.CambiarColor(comboColores.SelectedIndex + 1);
        }

        private void btnInfoColor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El color actual de la especie: "
                + ClaseUsada.GetType().Name + " es: "
                + ClaseUsada.GetColorEspecie());
            
            
        }

        private void comboBoxEspecies2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEspecies2.SelectedItem.ToString() == "Kandolf")
            {
                ClaseUsada = new Kandolf();
            }
            else if (comboBoxEspecies2.SelectedItem.ToString() == "X")
            {
                ClaseUsada = new X();
            }
            else if (comboBoxEspecies2.SelectedItem.ToString() == "Y")
            {
                ClaseUsada = new Y();
            }
            else if (comboBoxEspecies2.SelectedItem.ToString() == "Z")
            {
                ClaseUsada = new Z();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClaseUsada.CambiarForma(comboBox1.SelectedIndex + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La forma actual de la especie: "
                + ClaseUsada.GetType().Name + " es: "
                + ClaseUsada.GetFormaEspecie());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}