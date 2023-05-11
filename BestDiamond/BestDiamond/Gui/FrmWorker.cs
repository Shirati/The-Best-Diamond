using BestDiamond.DB;
using BestDiamond.Models;
using BestDiamond.Utilities;
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
    public partial class FrmWorker : Form
    {

        private Worker w;
        private WorkerDB tbLWorker;
        private KindEDB tbLKind;

        private bool FlagAdd;
        private bool FlagUpdate;
        private int y = 1;
        private WorkerDB tbLbuy;


        public FrmWorker()
        {
            InitializeComponent();
            tbLWorker = new WorkerDB();
            tbLKind = new KindEDB();
            w = tbLWorker.GetList().FirstOrDefault();
            FlagUpdate = false;
            FlagAdd = false;
            notPossible();
            Fill(w);
            cbsug.DataSource = tbLKind.GetList();

        }
        private void Possible()
        {
            panel2.Visible = true;
            panel1.Visible = false;
            btnSave.Visible = true;
            btnCancle.Visible = true;
            txtb.ReadOnly = false;
            txtch.ReadOnly = false;
            txtFName.ReadOnly = false;
            txtLName.ReadOnly = false;
            txtId.ReadOnly = false;
            txts.ReadOnly = false;
            txtP.ReadOnly = false;
            ch1.Checked = false;
        }

        private void notPossible()
        {
            panel2.Visible = false;
            panel1.Visible = true;
            FlagAdd = false;
            FlagUpdate = false;
            btnSave.Visible = false;
            btnCancle.Visible = false;
            txtb.ReadOnly = true;
            txtch.ReadOnly = true;
            txtFName.ReadOnly = true;
            txtLName.ReadOnly = true;
            txtId.ReadOnly = true;
            txts.ReadOnly = true;
            txtP.ReadOnly = true;
            ch1.Checked = true;
        }

        public void Fill(Worker w)
        {
            if (tbLWorker.Size() > 0)
            {
                txtb.Text = w.Id.ToString();
                cbsug.SelectedItem = w.ThisK().KodE;
                txts.Text = w.Semel.ToString();
                txtId.Text = w.Id.ToString();
                txtch.Text = w.Numch.ToString();
                txtFName.Text = w.Fname.ToString();
                txtLName.Text = w.Lname.ToString();
                ch1.Checked = (w.Status.Equals(true));
                txtP.Text = w.Pel.ToString();
            }
            else
            {
                txtId.Text = "";
                txtb.Text = "";
                cbsug.SelectedItem = "";
                txts.Text = "";
                txtch.Text = "";
                ch1.Checked = false;
                txtFName.Text = "";
                txtLName.Text = "";
                txtP.Text = "";
            }






        }
        private bool CreateFields(Worker w)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                w.Id = (txtId.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                ok = false;
            }

            try
            {
                w.Lname = txtLName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLName, ex.Message);
                ok = false;
            }
            try
            {
                w.Fname = (txtFName.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFName, ex.Message);
                ok = false;
            }

            try
            {
                w.Pel = txtP.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtP, ex.Message);
                ok = false;
            }

            try
            {
                w.KodE = ((KindE)(cbsug.SelectedItem)).KodE;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cbsug, ex.Message);
                ok = false;
            }

            try
            {
                w.KodB = Convert.ToInt32(txtb.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtb, ex.Message);
                ok = false;
            }
            try
            {
                w.Semel = Convert.ToInt32(txts.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txts, ex.Message);
                ok = false;
            }
            try
            {
                w.Numch = Convert.ToInt32(txtch.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtch, ex.Message);
                ok = false;
            }


            w.Status = (ch1.Checked == true);
            return ok;



        }






        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FlagUpdate)
                if (CreateFields(w))
                {

                    DialogResult r = MessageBox.Show("האם לעדכן זה עובד", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tbLWorker.UpdateRow(w);
                        notPossible();
                    }

                }
            if (FlagAdd)
            {
                Worker w = new Worker();
                if (this.tbLWorker.GetList().Find(x => x.Id == txtId.Text.ToString()) == null)
                {
                    if (CreateFields(w))
                    {
                        DialogResult r = MessageBox.Show("האם לעדכן זה עובד", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tbLWorker.AddNew(w);
                            notPossible();
                        }
                    }


                }

            }

        }

      

        private void btnNew_Click(object sender, EventArgs e)
        {
            FlagAdd = true;
            FlagUpdate = false;
            txtId.ReadOnly = true;
            txtId.Text = "";
            txtb.Text = "";
            cbsug.SelectedItem = "";
            txts.Text = "";
            txtch.Text = "";
            ch1.Checked = false;
            txtFName.Text = "";
            txtLName.Text = "";
            txtP.Text = "";
            Possible();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectDG(dg1))
            {
                FlagAdd = false;
                FlagUpdate = true;
                txtId.ReadOnly = true;
                string st = dg1.SelectedRows[0].Cells[0].Value.ToString();
                w = tbLWorker.Find(st);
                Fill(w);
                Possible();
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dg1.DataSource = tbLWorker.GetList().Select(x => new { ת_ז = x.Id, קוד_בנק = x.KodB, התמחות = x.ThisK().KodE, שם = x.Fname, משפחה = x.Lname, סמל = x.Semel, זמין = x.Status, פל = x.Pel }).ToList();
            notPossible();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (SelectDG(dg1))
            {
                DialogResult r = MessageBox.Show("האם למחוק עובד  זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    if (dg1.SelectedRows.Count > 0)
                    {
                        string st = dg1.SelectedRows[0].Cells[0].Value.ToString();
                        tbLWorker.DeleteStatus(st);
                        notPossible();
                    }
                }
            }

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (FlagUpdate)

                
            if (CreateFields(w))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן עובד זה?", "אישור עידכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tbLWorker.UpdateRow(w);
                        notPossible();
                    }
                }
            if (FlagAdd)
            {
                Worker w = new Worker();
                if (tbLWorker.GetList().Exists(x => x.Id == txtId.Text ))
                    MessageBox.Show("עובד זה כבר קיים", "שגיאת הוספה", MessageBoxButtons.OK);
                else
                {
                    if (CreateFields(w))
                    {
                        DialogResult r = MessageBox.Show("האם להוסיף עובד זה?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tbLWorker.AddNew(w);
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

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {
            dg1.DataSource = tbLWorker.GetList().Where(x => x.Id.StartsWith(txtId.Text)).Select(x => new { ת_ז = x.Id, קוד_בנק = x.KodB, התמחות = x.ThisK().KodE, שם = x.Fname, משפחה = x.Lname, סמל = x.Semel, זמין = x.Status, פל = x.Pel }).ToList();
        }

        private void cbsug_SelectedIndexChanged(object sender, EventArgs e)
        {
           dg1.DataSource = tbLWorker.GetList().Where(x => x.ThisK().Teur == cbsug.Text).Select(x => new { ת_ז = x.Id, קוד_בנק = x.KodB, התמחות = x.ThisK().KodE, שם = x.Fname, משפחה = x.Lname, סמל = x.Semel, זמין = x.Status, פל = x.Pel }).ToList();
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLWorker.GetList().Where(x => x.Lname.StartsWith(txtLName.Text)).Select(x => new { ת_ז = x.Id, קוד_בנק = x.KodB, התמחות = x.ThisK().KodE, שם = x.Fname, משפחה = x.Lname, סמל = x.Semel, זמין = x.Status, פל = x.Pel }).ToList();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLWorker.GetList().Where(x => x.Fname.StartsWith(txtFName.Text)).Select(x => new { קוד = x.KodE, חשבון = x.Numch, סמל = x.Semel, שם_משפחה = x.Lname, התמחות = x.ThisK().KodE, פל = x.Pel, זמין = x.Status, שם = x.Fname }).ToList();
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLWorker.GetList().Where(x => x.Pel.StartsWith(txtP.Text)).Select(x => new { ת_ז = x.Id, קוד_בנק = x.KodB, התמחות = x.ThisK().KodE, שם = x.Fname, משפחה = x.Lname, סמל = x.Semel, זמין = x.Status, פל = x.Pel }).ToList();
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLWorker.GetList().Where(x => x.KodB.ToString().StartsWith(txtb.Text)).Select(x => new { ת_ז = x.Id, קוד_בנק = x.KodB, התמחות = x.ThisK().KodE, שם = x.Fname, משפחה = x.Lname, סמל = x.Semel, זמין = x.Status, פל = x.Pel }).ToList();
        }

        

        private void txtch_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLWorker.GetList().Where(x => x.Numch.ToString().StartsWith(txtch.Text)).Select(x => new { ת_ז = x.Id, קוד_בנק = x.KodB, התמחות = x.ThisK().KodE, שם = x.Fname, משפחה = x.Lname, סמל = x.Semel, זמין = x.Status, פל = x.Pel }).ToList();
        }

        private bool SelectDG(DataGridView dg)
        {


            return (dg.SelectedRows.Count >= 1);
        }
    }
}