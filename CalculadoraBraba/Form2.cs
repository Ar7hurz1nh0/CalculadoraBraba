using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBraba
{
    public partial class Form2 : Form
    {
        private bool wantsToExit = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timerHora.Start();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wantsToExit) {
                Close();
            }
            else {
                DialogResult result = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                {
                    wantsToExit = true;
                }
                else e.Cancel = true;
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            wantsToExit = false;
            Application.Exit();
        }
        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void utilitáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerHora_tick(object sender, EventArgs e)
        {
            stDataHora.Text = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
        }

        private void start_notepad(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void start_calc(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void test_server(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            // startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden; // Esconde a janela do CMD
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ping google.com";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
    }
}
