using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_senhas
{
    public partial class Form1 : Form
    {
        Util util = new Util();
        public Form1()
        {
            InitializeComponent();
            lbl_tamanho.Text = $"{trackbar_tamanho.Value} caracteres";
            generatePassword();
        }

        public void generatePassword()
        {
            string str = "";
            Random rand = new Random();
            int index;

            while (str.Length < trackbar_tamanho.Value)
            {
                index = rand.Next(0, util.letters.Length);
                str += util.letters[index].ToString();

                if (checkbox_numbers.Checked)
                {
                    index = rand.Next(0, util.numbers.Length);
                    str += util.numbers[index].ToString();
                }
                if(checkbox_specialCharacters.Checked)
                {
                    index = rand.Next(0, util.specialCharacters.Length);
                    str += util.specialCharacters[index].ToString();
                }
            }

            if(str.Length > trackbar_tamanho.Value)
            {
                str = str.Substring(0, str.Length - (str.Length - trackbar_tamanho.Value));
            }
            lbl_senhaGerada.Text = str;

        }

        private void trackbar_tamanho_ValueChanged(object sender, EventArgs e)
        {
            lbl_tamanho.Text = $"{trackbar_tamanho.Value} caracteres";
            generatePassword();
        }

        private void checkbox_numbers_CheckedChanged(object sender, EventArgs e)
        {
            generatePassword();
        }

        private void checkbox_specialCharacters_CheckedChanged(object sender, EventArgs e)
        {
            generatePassword();
        }
    }
}
