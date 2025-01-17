using System;
using System.Windows.Forms;

namespace projLeds
{
    public partial class Form1 : Form
    {
        private Leds meusLeds;

        public Form1()
        {
            InitializeComponent();
            meusLeds = new Leds(129);
            AtualizaInterface();
        }

        private void AtualizaInterface()
        {
            txtDado.Text = meusLeds.getDado().ToString();
            txtDado2.Text = Convert.ToString(meusLeds.getDado(), 2);
            txtDado16.Text = Convert.ToString(meusLeds.getDado(), 16);

            for (int i = 1; i <= 8; i++)
            {
                AtualizaEstadoLed(i);
            }
        }

        private void AtualizaEstadoLed(int ledIndex)
        {
            bool estado = meusLeds.getLed(ledIndex);
            var checkBox = Controls.Find($"chkLed{ledIndex}", true)[0] as CheckBox;
            var pictureBox = Controls.Find($"picLed{ledIndex}", true)[0] as PictureBox;

            if (checkBox != null) checkBox.Checked = estado;

            if (pictureBox != null)
            {
                pictureBox.Image = estado
                    ? projLeds.Properties.Resources.acesa
                    : projLeds.Properties.Resources.apagada;
            }
        }

        private void AlterarEstadoLed(int ledIndex, bool acender)
        {
            if (acender)
                meusLeds.acender(ledIndex);
            else
                meusLeds.apagar(ledIndex);

            AtualizaInterface();
        }

        private void btnLed_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string[] parts = button.Name.Split(new[] { "btnLed", "ON", "OFF" }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 1 && int.TryParse(parts[0], out int ledIndex))
                {
                    bool acender = button.Name.Contains("ON");
                    AlterarEstadoLed(ledIndex, acender);
                }
            }
        }
    }
}
