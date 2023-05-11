using BestDiamond.DB;
using BestDiamond.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestDiamond.Gui
{
    public partial class FrnDiamondWork : Form
    {
        private DiamondWork d;
        private DiamondWorkDB tbLDiamondWork;
        private GelemDB tbLGelem;


        public FrnDiamondWork()
        {
            InitializeComponent();
            tbLDiamondWork = new DiamondWorkDB();
            tbLGelem = new GelemDB();
            d = tbLDiamondWork.GetList().FirstOrDefault();
            btnUpdate.Visible = false;
            panel3.Visible = false;
            button2.Visible = false;
            btnfoler.Visible = true;
          
        }
        //private void Possible()
        //{
          
        //    panel1.Visible = false;
        //    btnSave.Visible = true;
        //    btnCancle.Visible = true;

        //    txtcamut.ReadOnly = false;



        //}

        //private void notPossible()
        //{
          
        //    panel1.Visible = true;
          
        //    btnSave.Visible = false;
        //    btnCancle.Visible = false;

        //    txtcamut.ReadOnly = true;
        //}
     





      






        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    if (FlagUpdate)
        //        if (CreateFields(d))
        //        {

        //            DialogResult r = MessageBox.Show("האם לעדכן זה משכורת", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        //            if (r == DialogResult.Yes)
        //            {
        //                tbLDiamondWork.UpdateRow(d);
        //                notPossible();
        //            }

        //        }
        //    if (FlagAdd)
        //    {
        //        DiamondWork d1 = new DiamondWork();
        //        if (this.tbLDiamondWork.GetList().Find(x => x.Kodya == Convert.ToInt32(txtya.Text.ToString())) == null)
        //        {
        //            if (CreateFields(d1))
        //            {
        //                DialogResult r = MessageBox.Show("האם לעדכן זה עבודה", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        //                if (r == DialogResult.Yes)
        //                {
        //                    tbLDiamondWork.AddNew(d1);
        //                    notPossible();
        //                }
        //            }


        //        }

        //    }

        //}




        private void btnNew_Click(object sender, EventArgs e)
        {
          
            txtcamut.Text = " ";
            btnUpdate.Visible = false;
            panel3.Visible = false;
            button2.Visible = false;
            btnfoler.Visible = false;

        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
          
        //    panel3.Visible = true;



          
        //}

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dgfoler.DataSource = tbLGelem.GetList().Where(x => x.Kodbuy == Convert.ToInt32(txtkodbuy.Text)).Select(x => new { קוד_חומר_גלם = x.KodGelem, משקל = x.Mishkal, כמות = x.Camut, סך_לתשלום = x.Pricesuch, צבע = x.Color, רמת_ניקיון = x.ThisRama().Teur }).ToList();

            dg1.DataSource = tbLDiamondWork.GetList() .Select(x => new { קוד_יהלום = x.Kodya, תאריך_התחלה = x.Datef, תאריך_סיום_משוער = x.Dates, כמות = x.Camut }).ToList();
            //dg1.DataSource = tbLGelem.GetList();
        }







        //private void btnCancle_Click(object sender, EventArgs e)
        //{
        //    notPossible();

        //    errorProvider1.Clear();

        //}



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtkodbuy.Text!="")
            {
                dgfoler.DataSource = tbLGelem.GetList().Where(x => x.Kodbuy == Convert.ToInt32(txtkodbuy.Text)).Select(x => new { קוד_חומר_גלם = x.KodGelem, משקל = x.Mishkal, כמות = x.Camut, חבילה = x.Pack, סך_לתשלום = x.Pricesuch, צבע = x.Color, רמת_ניקיון = x.ThisRama().Teur }).ToList();
            }
        }

        private void dgfoler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectDG(dgfoler))
            {
                string st = dgfoler.SelectedRows[0].Cells[0].Value.ToString();
               ///////// d = tbLDiamondWork.Find(txtkodbuy.Text, st);
                dg1.DataSource = tbLDiamondWork.GetList().Where(x => x.Kodbuy.ToString()==txtkodbuy.Text && x.KodGelem.ToString() == st).Select(x => new { קוד_יהלום = x.Kodya, תאריך_התחלה = x.Datef, תאריך_סיום_משוער = x.Dates, כמות = x.Camut }).ToList();



                int kk = Convert.ToInt32(txtkodbuy.Text);
                int yaholomim = tbLDiamondWork.GetList().Where(x => x.Kodbuy == kk && x.KodGelem == Convert.ToInt32(st)).ToList().Sum(x => x.Camut);
                txtn.Text = (Convert.ToInt32(dgfoler.SelectedRows[0].Cells[2].Value) - yaholomim).ToString();
            }
        }
        private bool SelectDG(DataGridView dg)
        {


            return (dg.SelectedRows.Count >= 1);
        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgfoler))
            {
                string st = dgfoler.SelectedRows[0].Cells[0].Value.ToString();
                int kk = Convert.ToInt32(txtkodbuy.Text);
                int yaholomim = tbLDiamondWork.GetList().Where(x => x.Kodbuy == kk && x.KodGelem == Convert.ToInt32(st)).ToList().Sum(x => x.Camut);
                
                if (yaholomim + Convert.ToInt32(txtcamut.Text) <= (Convert.ToInt32(dgfoler.SelectedRows[0].Cells[2].Value) ))
                {
                    DiamondWork diamondWork = new DiamondWork();
                    diamondWork.Kodya = Convert.ToInt32(tbLDiamondWork.GetNextKey().ToString());
                    diamondWork.Kodbuy = kk;
                    diamondWork.KodGelem = Convert.ToInt32(st);
                    diamondWork.Datef = DateTime.Today;
                    diamondWork.Camut = Convert.ToInt32(txtcamut.Text);
                    diamondWork.Dates = DateTime.Today.AddDays(60);
                    tbLDiamondWork.AddNew(diamondWork);
                    dg1.DataSource = tbLDiamondWork.GetList().Select(x => new { קוד_יהלום = x.Kodya, תאריך_התחלה = x.Datef, תאריך_סיום_משוער = x.Dates, כמות = x.Camut }).ToList();
                    btnUpdate.Visible = true;
                    btnfoler.Visible = true;
                }
                else
                    MessageBox.Show("הכמות שנשלחה לעיבוד גדולה מהכמות שנרכשה");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgfoler) && dateTimePicker1.Value >Convert.ToDateTime( dg1.SelectedRows[0].Cells[3].Value.ToString()))
            {
                tbLDiamondWork.GetList().Find(x => x.Kodbuy == Convert.ToInt32(txtkodbuy.Text)).Dates = dateTimePicker1.Value;
                string st = dg1.SelectedRows[0].Cells[0].Value.ToString();

            }
            else
                MessageBox.Show("טעות בנתונים");
        }

        private void txtkodbuy_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SelectDG(dg1))
            {
                string st = dg1.SelectedRows[0].Cells[0].Value.ToString();
                FrmDiamondFoler f = new FrmDiamondFoler(st);
                f.Show();
                this.Hide();
            }
        }

     

        private void txtcamut_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectDG(dg1))
            { 

               panel3.Visible = true;
            }
          
        }

       
    }
}
