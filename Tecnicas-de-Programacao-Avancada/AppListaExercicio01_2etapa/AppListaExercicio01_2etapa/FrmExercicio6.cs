using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppListaExercicio01_2etapa
{
    public partial class FrmExercicio6 : Form
    {
        public FrmExercicio6()
        {
            InitializeComponent();
        }

        private void btn_mostresultado_Click(object sender, EventArgs e)
        {
            int numLados = int.Parse(txtNum_Lado.Text);
        }
    }
}
