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
    public partial class FrmSaleryM : Form
    {

        private SaleryM s;
        private SaleryMDB tbLSaleryM;
        private bool FlagAdd;
        private bool FlagUpdate;
        private int y = 1;
        private WorkerDB tbLWorker;


        public FrmSaleryM()
        {
            InitializeComponent();
            tbLSaleryM = new SaleryMDB();
            tbLWorker = new WorkerDB();
            s = tbLSaleryM.GetList().FirstOrDefault();
            FlagUpdate = false;
            FlagAdd = false;
            notPossible();
            Fill(s);
            chId.DataSource = tbLWorker.GetList();
            panel3.Visible = false;
        }
        private void Possible()
        {
            panel2.Visible = true;
            panel1.Visible = false;
            btnSave.Visible = true;
            btnCancle.Visible = true;
            txtkod.ReadOnly = true;
            txtm.ReadOnly = false;
            txty.ReadOnly = false;
            txtscom.ReadOnly = false;
            txtsa.ReadOnly = false;


        }

        private void notPossible()
        {
            panel2.Visible = false;
            panel1.Visible = true;
            FlagAdd = false;
            FlagUpdate = false;
            btnSave.Visible = false;
            btnCancle.Visible = false;
            txtm.ReadOnly = true;
            txty.ReadOnly = true;
            txtscom.ReadOnly = true;
            txtsa.ReadOnly = true;
            txtkod.ReadOnly = true;
        }
        public void Fill(SaleryM s)
        {
            if (tbLSaleryM.Size() > 0)
            {
                txtm.Text = s.MonthD.ToString();
                chId.SelectedItem = s.ThisWorker().Id;
                txty.Text = s.YearD.ToString();
                txtscom.Text = s.ScumA.ToString();
                txtkod.Text = s.KodMonth.ToString();
                txtsa.Text = s.Pricesuch.ToString();

            }
            else
            {
                txtm.Text = " ";
                chId.SelectedItem = " ";
                txty.Text = " ";
                txtscom.Text = " ";
                txtkod.Text = " ";
                txtsa.Text = " ";
            }






        }
        private bool CreateFields(SaleryM s)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                s.MonthD = Convert.ToInt32(txtm.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtm, ex.Message);
                ok = false;
            }

            try
            {
                s.YearD = Convert.ToInt32(txty.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txty, ex.Message);
                ok = false;
            }
            try
            {
                s.ScumA = Convert.ToInt32(txtscom.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtscom, ex.Message);
                ok = false;
            }

            try
            {
                s.Pricesuch = Convert.ToInt32(txtsa.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtsa, ex.Message);
                ok = false;
            }

            try
            {
                s.Id = (chId.ToString());
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(chId, ex.Message);
                ok = false;
            }

            try
            {
                s.KodMonth = Convert.ToInt32(txtkod.ToString());
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtkod, ex.Message);
                ok = false;
            }
            return ok;

        }






        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FlagUpdate)
                if (CreateFields(s))
                {

                    DialogResult r = MessageBox.Show("האם לעדכן זה משכורת", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tbLSaleryM.UpdateRow(s);
                        notPossible();
                    }

                }
            if (FlagAdd)
            {
                SaleryM s1 = new SaleryM();
                if (this.tbLSaleryM.GetList().Find(x => x.KodMonth == Convert.ToInt32(txtkod.Text.ToString())) == null)
                {
                    if (CreateFields(s1))
                    {
                        DialogResult r = MessageBox.Show("האם לעדכן זה משכורת", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tbLSaleryM.AddNew(s1);
                            notPossible();
                        }
                    }


                }

            }

        }


        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FlagAdd = true;
            FlagUpdate = false;
            txtkod.ReadOnly = true;
            string st = dg1.SelectedRows[0].Cells[0].Value.ToString();
            s = tbLSaleryM.Find(st);
            Fill(s);
            Possible();
        }








        private void btnCancle_Click(object sender, EventArgs e)
        {
            notPossible();

            errorProvider1.Clear();

        }

        private void txtkod_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLSaleryM.GetList().Where(x => x.KodMonth.ToString().StartsWith(txtkod.Text)).Select(x => new { קוד = x.KodMonth, החודש = x.MonthD, תז = x.ThisWorker().Id, שנה = x.YearD, אבנים = x.ScumA, משכורת = x.Pricesuch, }).ToList();
        }

        private void txtm_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLSaleryM.GetList().Where(x => x.MonthD.ToString().StartsWith(txtm.Text)).Select(x => new { קוד = x.KodMonth, החודש = x.MonthD, תז = x.ThisWorker().Id, שנה = x.YearD, אבנים = x.ScumA, משכורת = x.Pricesuch, }).ToList();
        }

        private void txty_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLSaleryM.GetList().Where(x => x.YearD.ToString().StartsWith(txty.Text)).Select(x => new { קוד = x.KodMonth, החודש = x.MonthD, תז = x.ThisWorker().Id, שנה = x.YearD, אבנים = x.ScumA, משכורת = x.Pricesuch, }).ToList();
        }

        private void chId_SelectedIndexChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLSaleryM.GetList().Where(x => x.Id.ToString().StartsWith(chId.Text)).Select(x => new { קוד = x.KodMonth, החודש = x.MonthD, תז = x.ThisWorker().Id, שנה = x.YearD, אבנים = x.ScumA, משכורת = x.Pricesuch, }).ToList();
        }

        private void txtscom_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLSaleryM.GetList().Where(x => x.ScumA.ToString().StartsWith(txtscom.Text)).Select(x => new { קוד = x.KodMonth, החודש = x.MonthD, תז = x.ThisWorker().Id, שנה = x.YearD, אבנים = x.ScumA, משכורת = x.Pricesuch, }).ToList();
        }

        private void txtsa_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLSaleryM.GetList().Where(x => x.Pricesuch.ToString().StartsWith(txtsa.Text)).Select(x => new { קוד = x.KodMonth, החודש = x.MonthD, תז = x.ThisWorker().Id, שנה = x.YearD, אבנים = x.ScumA, משכורת = x.Pricesuch, }).ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            FlagAdd = true;
            FlagUpdate = false;
            txtkod.Text = tbLSaleryM.GetNextKey().ToString();
            txtm.Text = " ";
            chId.SelectedItem = " ";
            txty.Text = " ";
            txtscom.Text = " ";
            txtkod.Text = " ";
            txtsa.Text = " ";
            Possible();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            dg1.DataSource = tbLSaleryM.GetList().Select(x => new { קוד = x.KodMonth, החודש = x.MonthD, תז = x.ThisWorker().Id, שנה = x.YearD, אבנים = x.ScumA, משכורת = x.Pricesuch, }).ToList();
            //dg1.DataSource = tbLWorker.GetList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txty.Text != "" && txtm.Text != "" && chId.Text != "")
            {
                SaleryM s1 = new SaleryM();


                DialogResult r = MessageBox.Show("האם לעדכן זה משכורת", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {

                    int c;
                    double s;
                    DiaryDB tbldiary = new DiaryDB();
                    DiamondWorkDB tblWD = new DiamondWorkDB();
                    c = tbldiary.GetList().Count(x => x.Id == chId.Text && x.detef.Month == Convert.ToInt32(txtm.Text) && x.detef.Year == Convert.ToInt32(txty.Text));

                    s = tbldiary.GetList().Where(x => x.Id == chId.Text && x.detef.Month == Convert.ToInt32(txtm.Text) && x.detef.Year == Convert.ToInt32(txty.Text)).ToList().Sum(x => x.Pricew);
                    bool ok = true;
                    errorProvider1.Clear();
                    try
                    {

                        s1.MonthD = Convert.ToInt32(txtm.Text);
                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(txtm, ex.Message);
                        ok = false;
                    }

                    try
                    {
                        s1.YearD = Convert.ToInt32(txty.Text);
                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(txty, ex.Message);
                        ok = false;
                    }
                    if (ok == true)
                    {
                        s1.Id = chId.Text;
                        s1.ScumA = c;
                        s1.Pricesuch = s;
                        s1.KodMonth = Convert.ToInt32(tbLSaleryM.GetNextKey().ToString());
                        tbLSaleryM.AddNew(s1);
                    }
                    


                    dg1.DataSource = tbLSaleryM.GetList().Select(x => new { קוד = x.KodMonth, החודש = x.MonthD, תז = x.ThisWorker().Id, שנה = x.YearD, אבנים = x.ScumA, משכורת = x.Pricesuch, }).ToList();
                    notPossible();

                }


            }
            else
                errorProvider1.SetError(button1,"לא הוזנו נתונים");
        }
        private void FrmSaleryM_Load(object sender, EventArgs e)
        {

        }
    }
}
