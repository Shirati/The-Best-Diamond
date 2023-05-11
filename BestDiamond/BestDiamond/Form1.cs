using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BestDiamond.Gui;
namespace BestDiamond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmWorker f = new FrmWorker();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKindE f = new FrmKindE();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FrmDiamondFoler f = new FrmDiamondFoler();
            //f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmRama f = new FrmRama();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           FrmSaleryM f = new FrmSaleryM();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrnDiamondWork f = new FrnDiamondWork();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           FrmDiary f = new FrmDiary();
            f.Show();
        }

        private void btbuy_Click(object sender, EventArgs e)
        {
          FrmBuy f = new FrmBuy();
            f.Show();
        }
    }
}
