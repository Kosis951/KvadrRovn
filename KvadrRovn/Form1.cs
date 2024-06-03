using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KvadrRovn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            textBoxA.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            textBoxB.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            textBoxC.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
           
            textBoxA.Leave += new EventHandler(TextBox_Leave);
            textBoxB.Leave += new EventHandler(TextBox_Leave);
            textBoxC.Leave += new EventHandler(TextBox_Leave);

            textBoxA.Enter += new EventHandler(TextBox_Enter);
            textBoxB.Enter += new EventHandler(TextBox_Enter);
            textBoxC.Enter += new EventHandler(TextBox_Enter);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is a control key, digit, or a single decimal point
            bool isValidInput = char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == '.';
            TextBox textBox = sender as TextBox;

            // Check for multiple decimal points
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                isValidInput = false;
            }

            // If the input is not valid, show a dialog box and handle the event
            if (!isValidInput)
            {
                e.Handled = true;
                MessageBox.Show("Prosím zadejte číslo.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            // Change the background color of the focused TextBox
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.ForestGreen;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            // Revert the background color of the TextBox
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.White;
        }
        private void oAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kvadratická rovnice verze 1","O aplikaci",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);
                

                double discriminant = b * b - 4 * a * c;
                labelDis.Text = discriminant.ToString();
                if (discriminant > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminant) / (2 * a));
                    double x2 = (-b + Math.Sqrt(discriminant) / (2 * a));
                    labelResult.Text = $"x1 = {x1:F2}, x2 = {x2:F2}";
                }
                else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    labelResult.Text = $"x = {x:F2}";
                }
                else
                {
                    labelResult.Text = "No real solutions.";
                }
            }
            catch
            {
                MessageBox.Show("Vyplňte prosím všechny hodnoty","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void barvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void typPísmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                labelDis.Font = fontDialog1.Font;
                labelResult.Font = fontDialog1.Font;
            }
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
