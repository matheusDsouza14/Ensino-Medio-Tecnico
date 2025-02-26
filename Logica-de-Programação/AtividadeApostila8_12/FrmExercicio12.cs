using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExercicio8_12Apostila
{
    public partial class FrmExercicio8 : Form
    {
        public FrmExercicio8()
        {
            InitializeComponent();
        }
        private void btnArea_Click(object sender, EventArgs e)
        {
			int base = int.Parse(txtBase.Text);
			int altura = int.Parse(txtAltura.Text);
			int area = base + altura;
			lblArea.Text = "A área do triângulo é de " = area;
        }
		private void btnPerimetro_Click(object sender, EventArgs e)
        {
			int base = int.Parse(txtBase.Text);
			int altura = int.Parse(txtAltura.Text);
			int perimetro = 2(base + altura);
			lblPerimetro.Text = "O perimetro do triângulo é de " = area;
        }
    }
}
