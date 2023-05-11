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
    public partial class FrmKindE : Form
    {

        private KindE k;
        private KindEDB tbLKindE;
        private bool FlagAdd;
        private bool FlagUpdate;
        private int y = 1;



        public FrmKindE()
        {
            InitializeComponent();
            tbLKindE = new KindEDB();

            k = tbLKindE.GetList().FirstOrDefault();
            FlagUpdate = false;
            FlagAdd = false;
            notPossible();
            Fill(k);
            dg1.DataSource = tbLKindE.GetList().Select(x => new { קוד = x.KodE, תאור = x.Teur, חלק = x.Part, מחיר = x.FirstPrice, }).ToList(); ;
        }
        private void Possible()
        {
            panel2.Visible = true;
            panel1.Visible = false;
            btnSave.Visible = true;
            btnCancle.Visible = true;
            txtE.ReadOnly = true;
            txtteur.ReadOnly = false;
            txtP.ReadOnly = false;
            txtpart.ReadOnly = false;

        }

        private void notPossible()
        {
            panel2.Visible = false;
            panel1.Visible = true;
            FlagAdd = false;
            FlagUpdate = false;
            btnSave.Visible = false;
            btnCancle.Visible = false;
            txtE.ReadOnly = true;
            txtteur.ReadOnly = true;
            txtP.ReadOnly = true;
            txtpart.ReadOnly = true;

        }

        public void Fill(KindE k)
        {
            if (tbLKindE.Size() > 0)
            {
                txtE.Text = k.KodE.ToString();

                txtteur.Text = k.Teur.ToString();
                txtP.Text = k.FirstPrice.ToString();
                txtpart.Text = k.Part.ToString();
                ;
            }
            else
            {
                txtE.Text = "";
                txtteur.Text = "";
                txtP.Text = "";
                txtpart.Text = "";

            }






        }
        private bool CreateFields(KindE k)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                k.KodE = Convert.ToInt32((txtE.Text));
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtE, ex.Message);
                ok = false;
            }

            try
            {
                k.Teur = txtteur.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtteur, ex.Message);
                ok = false;
            }
            try
            {
                if (k.Part == "תחתון")
                    k.FirstPrice = Convert.ToDouble((txtP.Text)) + 5;
                else
                    k.FirstPrice = Convert.ToDouble((txtP.Text));
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtP, ex.Message);
                ok = false;
            }

            try
            {
                k.Part = txtpart.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtpart, ex.Message);
                ok = false;
            }


            return ok;


        }







        private void btnNew_Click(object sender, EventArgs e)
        {
            FlagAdd = true;
            FlagUpdate = false;
            txtE.Text = tbLKindE.GetNextKey().ToString();
            txtteur.Text = "";
            txtP.Text = "";
            txtpart.Text = "";

            Possible();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FlagAdd = false;
            FlagUpdate = true;

            string st = dg1.SelectedRows[0].Cells[0].Value.ToString();
            k = tbLKindE.Find(st);
            Fill(k);
            Possible();
        }



        //private void btnDel_Click(object sender, EventArgs e)
        //{
        //    DialogResult r = MessageBox.Show("האם למחוק התמחות  זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        //    if (r == DialogResult.Yes)
        //    {
        //        if (dg1.SelectedRows.Count > 0)
        //        {
        //            string st = dg1.SelectedRows[0].Cells[0].Value.ToString();
        //            tbLKindE.DeleteStatus(st);
        //            notPossible();
        //        }
        //    }
        //}



        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (FlagUpdate)
                if (CreateFields(k))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן התמחות זה?", "אישור עידכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tbLKindE.UpdateRow(k);
                        notPossible();
                    }
                }
            if (FlagAdd)
            {
                KindE s = new KindE();
                if (tbLKindE.GetList().Exists(x => x.KodE == Convert.ToInt32(txtE.Text)))
                    MessageBox.Show("התמחות זה כבר קיים", "שגיאת הוספה", MessageBoxButtons.OK);
                else
                {
                    if (CreateFields(s))
                    {
                        DialogResult r = MessageBox.Show("האם להוסיף התמחות זה?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tbLKindE.AddNew(s);
                            notPossible();
                        }
                    }
                }
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            notPossible();

            errorProvider1.Clear();

        }



        private void txtE_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLKindE.GetList().Where(x => x.KodE.ToString().StartsWith(txtE.Text)).Select(x => new { קוד = x.KodE, תאור = x.Teur, חלק = x.Part, מחיר = x.FirstPrice, }).ToList();
        }

        private void txtteur_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLKindE.GetList().Where(x => x.Teur.ToString().StartsWith(txtteur.Text)).Select(x => new { קוד = x.KodE, תאור = x.Teur, חלק = x.Part, מחיר = x.FirstPrice, }).ToList();
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLKindE.GetList().Where(x => x.FirstPrice.ToString().StartsWith(txtP.Text)).Select(x => new { קוד = x.KodE, תאור = x.Teur, חלק = x.Part, מחיר = x.FirstPrice, }).ToList();
        }

        private void txtpart_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLKindE.GetList().Where(x => x.Part.ToString().StartsWith(txtpart.Text)).Select(x => new { קוד = x.KodE, תאור = x.Teur, חלק = x.Part, מחיר = x.FirstPrice, }).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dg1.DataSource = tbLKindE.GetList().Select(x => new { קוד = x.KodE, תאור = x.Teur, חלק = x.Part, מחיר = x.FirstPrice, }).ToList();
        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם למחוק סוג זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                string st = dg1.SelectedRows[0].Cells[0].Value.ToString();
               tbLKindE.DeleteRow(st);
            }
        }

        private void FrmKindE_Load(object sender, EventArgs e)
        {

        }
    }
}
