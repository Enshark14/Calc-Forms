namespace Calc_Forms
{
    public partial class Form1 : Form
    {
        double val1, val2;
        string Operacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;


            if (Painel.Text == "0")
            {
                Painel.Text = btn.Text;

            }
            else
            {
                Painel.Text += btn.Text;
            }
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (Painel.Text.Length > 0)
            {
                Painel.Text = Painel.Text.Remove(Painel.Text.Length - 1);
            }
            if (Painel.Text.Length == 0)
            {
                Painel.Text = "0";
            }
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            val1 = double.Parse(Painel.Text);
            Operacao = btn.Text;
            label1.Text = Painel.Text + " ";
            label1.Text += btn.Text;
            Painel.Clear();
            Painel.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(Painel.Text);
            label1.Text += " " + Painel.Text + " = ";
            switch (Operacao)
            {
                case "+":
                    Painel.Text = (val1 + val2).ToString();
                    break;

                case "-":
                    Painel.Text = (val1 - val2).ToString();
                    break;

                case "x":
                    Painel.Text = (val1 * val2).ToString();
                    break;

                case "÷":
                    if (val1 > 0 && val2 > 0)
                    {
                        Painel.Text = (val1 / val2).ToString();
                    }
                    else
                    {
                        Painel.Text = "Resultado Indefinido.";
                    }
                    break;
            }
            label1.Text += Painel.Text;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {

            if (!Painel.Text.Contains(","))
            {
                Painel.Text += ",";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Painel.Clear();
            Painel.Text = "0";
            val1 = 0; val2 = 0;
            label1.Text = "";
        }
    }
}
