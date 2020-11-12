using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Code_Translator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mors_Code.ReadOnly = true;
            ToMorse.Enabled = false;
        }

        bool PastePressed = false;
        private void NormalText_TextChanged(object sender, EventArgs e)
        {

            if (NormalText.Text.Length != 0 && !PastePressed && !ToMorse.Enabled)
                Mors_Code.Text += MorseCode.NormalTextToMorse(NormalText.Text);

            PastePressed = false;
        }

        private void Mors_Code_TextChanged(object sender, EventArgs e)
        {
            if (!ToText.Enabled)
                NormalText.Text = MorseCode.MorseToNormalText(Mors_Code.Text);
            
        }

        private void NormalText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                Text = "";

        }

        private void NormalText_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.V) && e.Control)
            {
                Mors_Code.Text += MorseCode.FullTextToMorse(Clipboard.GetText());
               
                PastePressed = true;
            }
        }

        private void ToMorse_Click(object sender, EventArgs e)
        {
            NormalText.ReadOnly = false;
            Mors_Code.ReadOnly = true;
            ToMorse.Enabled = false;
            ToText.Enabled = true;

            NormalText.Clear();
            Mors_Code.Clear();
        }

        private void ToText_Click(object sender, EventArgs e)
        {
            NormalText.ReadOnly = true;
            Mors_Code.ReadOnly = false;
            ToMorse.Enabled = true;
            ToText.Enabled = false;

            NormalText.Clear();
            Mors_Code.Clear();
        }
    }
}
