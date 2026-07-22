using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOANSO_PF
{
    public partial class Restaurante : Form
    {
        public Restaurante()
        {
            InitializeComponent();
        }

        private void btnCore_Click(object sender, EventArgs e)
        {
            Core formCore = new Core();
            formCore.Show();
        }

        private void btnMantenedor_Click(object sender, EventArgs e)
        {
            Mantenedores formMantenedores = new Mantenedores();
            formMantenedores.Show();
        }

        private void Restaurante_Load(object sender, EventArgs e)
        {
            int cX = this.ClientSize.Width / 2;
            int cY = this.ClientSize.Height / 2;

            label1.Left = cX - label1.Width / 2;
            label2.Left = cX - label2.Width / 2;

            int btnsW = btnCore.Width + 30 + btnMantenedor.Width;
            btnCore.Left = cX - btnsW / 2;
            btnMantenedor.Left = btnCore.Right + 30;
            btnCore.Top = cY - btnCore.Height / 2;
            btnMantenedor.Top = btnCore.Top;
        }
    }
}
