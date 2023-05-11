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
    public partial class FrmDiary : Form
    {
        private Diary d;
        private DiaryDB tbLDiary;
        private bool FlagAdd;
        private bool FlagUpdate;
        private int y = 1;
        private WorkerDB tbLWorker;
        private DiamondWorkDB tbLDiamondWork;
        DiamondFoler diamondFoler;
        DiamondFolerDB tbldiamondFoler;

        public FrmDiary(string st)
        {
            InitializeComponent();
            tbLDiary = new DiaryDB();
            tbLDiamondWork = new DiamondWorkDB();
          
          tbldiamondFoler = new DiamondFolerDB();
            diamondFoler = tbldiamondFoler.GetList().Find(x => x.Kodm.ToString() == st);
            d = tbLDiary.Find(diamondFoler.Kodya.ToString());
            panel3.Visible=false;
            panel4.Visible = false;
            FlagUpdate = false;
            FlagAdd = false;
            notPossible();
            panel3.Visible = false;
            panel4.Visible = false;
        }
        public FrmDiary()
        {
            InitializeComponent();
            tbLDiary = new DiaryDB();
            tbLWorker = new WorkerDB();
            tbLDiamondWork = new DiamondWorkDB();
            d = tbLDiary.GetList().FirstOrDefault();
            FlagUpdate = false;
            FlagAdd = false;
            notPossible();
            Fill(d);
            comId.DataSource = tbLWorker.GetList();
            comya.DataSource = tbLDiamondWork.GetList();
            panel3.Visible = false;
            panel4.Visible = false;
        }
        private void Possible()
        {
            panel2.Visible = true;
            panel1.Visible = false;
            btnSave.Visible = true;
            btnCancle.Visible = true;
            txtyo.ReadOnly = true;
            txtg.ReadOnly = false;
            txtc.ReadOnly = false;
            txtmark.ReadOnly = false;
            txtp.ReadOnly = false;


        }

        private void notPossible()
        {
            panel2.Visible = false;
            panel1.Visible = true;
            FlagAdd = false;
            FlagUpdate = false;
            btnSave.Visible = false;
            btnCancle.Visible = false;
            txtyo.ReadOnly = true;
            txtg.ReadOnly = true;
            txtc.ReadOnly = true;
            txtmark.ReadOnly = true;
            txtp.ReadOnly = true;
        }
        public void Fill(Diary d)
        {
            if (tbLDiamondWork.Size() > 0)
            {
                txtyo.Text = d.Kodya.ToString();
                comId.SelectedItem = d.ThisWorker();
                comya.SelectedItem = d.ThisDiamondWork();
                txtg.Text = d.detes.ToString();
                txtc.Text = d.detef.ToString();
                txtmark.Text = d.Mark.ToString();
                txtp.Text = d.Pricew.ToString();

            }
            else
            {
                txtyo.Text = " ";
                comId.SelectedItem = " ";
                comya.SelectedItem = " ";
                txtg.Text = " ";
                txtc.Text = " ";
                txtmark.Text = " ";
                txtp.Text = " ";
            }






        }
        private bool CreateFields(Diary d)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                d.Kodyo = Convert.ToInt32(txtyo.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtyo, ex.Message);
                ok = false;
            }

            try
            {
                d.detes = Convert.ToDateTime(txtg.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtg, ex.Message);
                ok = false;
            }
            try
            {
                d.detef = Convert.ToDateTime(txtc.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtc, ex.Message);
                ok = false;
            }

            try
            {
                d.Mark = Convert.ToInt32(txtmark.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtmark, ex.Message);
                ok = false;
            }
            try
            {
                d.Pricew = Convert.ToInt32(txtp.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtp, ex.Message);
                ok = false;
            }

            try
            {
                d.Id = (comId.ToString());
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comId, ex.Message);
                ok = false;
            }

            try
            {
                d.Kodya = Convert.ToInt32(comya.ToString());
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comya, ex.Message);
                ok = false;
            }
            return ok;

        }






        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FlagUpdate)
                if (CreateFields(d))
                {

                    DialogResult r = MessageBox.Show("האם לעדכן זה עבודת פועל", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tbLDiary.UpdateRow(d);
                        notPossible();
                    }

                }
            if (FlagAdd)
            {
                Diary d1 = new Diary();
                if (this.tbLDiary.GetList().Find(x => x.Kodyo == Convert.ToInt32(txtyo.Text.ToString())) == null)
                {
                    if (CreateFields(d1))
                    {
                        DialogResult r = MessageBox.Show("האם לעדכן זה עבודה", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tbLDiary.AddNew(d1);
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
            txtyo.Text = tbLDiary.GetNextKey().ToString();
            comId.SelectedItem = " ";
            comya.SelectedItem = " ";
            txtg.Text = " ";
            txtc.Text = " ";
            txtmark.Text = " ";
            txtp.Text = " ";
            Possible();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FlagAdd = true;
            FlagUpdate = false;
            txtyo.ReadOnly = true;
            string st = dg1.SelectedRows[0].Cells[0].Value.ToString();
            d = tbLDiary.Find(st);
            Fill(d);
            Possible();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dg1.DataSource = tbLDiary.GetList().Select(x => new { קודי = x.Kodyo, תז = x.ThisWorker().Id, קודיהלום = x.ThisDiamondWork().Kodya, התחלה = x.detes, סיום = x.detef, ציון = x.Mark, תשלום = x.Pricew, }).ToList();
            //dg1.DataSource = tbLWorker.GetList();
            //dg1.DataSource = tbLDiamondWork.GetList();
        }







        private void btnCancle_Click(object sender, EventArgs e)
        {
            notPossible();

            errorProvider1.Clear();

        }

        private void txtyo_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLDiary.GetList().Where(x => x.Kodyo.ToString().StartsWith(txtyo.Text)).Select(x => new { קודי = x.Kodyo, תז = x.ThisWorker().Id, קודיהלום = x.ThisDiamondWork().Kodya, התחלה = x.detes, סיום = x.detef, ציון = x.Mark, תשלום = x.Pricew, }).ToList();
        }



        private void comId_SelectedIndexChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLDiary.GetList().Where(x => x.Id.ToString().StartsWith(comId.Text)).Select(x => new { קודי = x.Kodyo, תז = x.ThisWorker().Id, קודיהלום = x.ThisDiamondWork().Kodya, התחלה = x.detes, סיום = x.detef, ציון = x.Mark, תשלום = x.Pricew, }).ToList();
        }

        private void comya_SelectedIndexChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLDiary.GetList().Where(x => x.Kodya.ToString().StartsWith(comya.Text)).Select(x => new { קודי = x.Kodyo, תז = x.ThisWorker().Id, קודיהלום = x.ThisDiamondWork().Kodya, התחלה = x.detes, סיום = x.detef, ציון = x.Mark, תשלום = x.Pricew, }).ToList();
        }

        private void txtg_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLDiary.GetList().Where(x => x.detes.ToString().StartsWith(txtg.Text)).Select(x => new { קודי = x.Kodyo, תז = x.ThisWorker().Id, קודיהלום = x.ThisDiamondWork().Kodya, התחלה = x.detes, סיום = x.detef, ציון = x.Mark, תשלום = x.Pricew, }).ToList();
        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLDiary.GetList().Where(x => x.detef.ToString().StartsWith(txtc.Text)).Select(x => new { קודי = x.Kodyo, תז = x.ThisWorker().Id, קודיהלום = x.ThisDiamondWork().Kodya, התחלה = x.detes, סיום = x.detef, ציון = x.Mark, תשלום = x.Pricew, }).ToList();
        }

        private void txtmark_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLDiary.GetList().Where(x => x.Mark.ToString().StartsWith(txtmark.Text)).Select(x => new { קודי = x.Kodyo, תז = x.ThisWorker().Id, קודיהלום = x.ThisDiamondWork().Kodya, התחלה = x.detes, סיום = x.detef, ציון = x.Mark, תשלום = x.Pricew, }).ToList();
        }

        private void txtp_TextChanged(object sender, EventArgs e)
        {
            dg1.DataSource = tbLDiary.GetList().Where(x => x.Pricew.ToString().StartsWith(txtp.Text)).Select(x => new { קודי = x.Kodyo, תז = x.ThisWorker().Id, קודיהלום = x.ThisDiamondWork().Kodya, התחלה = x.detes, סיום = x.detef, ציון = x.Mark, תשלום = x.Pricew, }).ToList();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            Diary d1 = new Diary();
            d1.Kodyo = Convert.ToInt32(tbLDiary.GetNextKey().ToString());
            d1.Id = diamondFoler.Id;
            d1.Kodya = diamondFoler.Kodya;
            d1.detes = diamondFoler.DateGo;
            d1.detef = diamondFoler.DateBack;
            d1.Mark = Convert.ToInt32(txtmark.Text);
            KindEDB tblkindE = new KindEDB();
            KindE kindE = tblkindE.GetList().Find(x => x.KodE == diamondFoler.Level);
            d1.Pricew = ((kindE.FirstPrice * Convert.ToInt32(txtmark.Text) )/ 100);
            tbLDiary.AddNew(d1);
            tbLDiary.UpdateRow(d1);
            dg1.DataSource=tbLDiary.GetList().Select(x => new { קודי = x.Kodyo, תז = x.ThisWorker().Id, קודיהלום = x.ThisDiamondWork().Kodya, התחלה = x.detes, סיום = x.detef, ציון = x.Mark, תשלום = x.Pricew, }).ToList();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      
    }
}
