using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static CalculadoraBraba.Program;

namespace CalculadoraBraba {
  public partial class Form1 : Form {
    private bool hasStarted = false;
    private int progress = 0;
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e) {
      
      if (progress < 1000) {
        progressBar2.Value += 1;
        progress += 10;
      }
      else {
        if (!hasStarted) {
          Form2 form2 = new Form2();
          form2.Show();
          hasStarted = true;
        }
        if (hasStarted && progress < 2000) {
          progress += 50;
        }
        else {
          form1.Hide();
          form1.ShowInTaskbar = true;
          timer1.Stop();
        }
      }
    }
  }
}
