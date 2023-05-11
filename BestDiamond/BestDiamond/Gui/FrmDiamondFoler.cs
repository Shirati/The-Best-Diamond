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
    public partial class FrmDiamondFoler : Form
    {
        private DiamondFoler d;
        private DiamondFolerDB tbLDiamondFoler;
        private bool FlagAdd;
        private bool FlagUpdate;
        private int y = 1;
        private DiamondWorkDB tbLDiamondWork;
        private DiamondWork dy;
        private string st;
        private int kk=0;


        public FrmDiamondFoler(string st)
        {
            InitializeComponent();
           
            tbLDiamondFoler = new DiamondFolerDB();
            tbLDiamondWork = new DiamondWorkDB();
            dy = tbLDiamondWork.Find(st);
            dg2.DataSource = tbLDiamondWork.GetList().Where(x => x.Kodya.ToString() == st).Select(x => new { קוד_יהלום = x.Kodya, תאריך_התחלה = x.Datef, תאריך_סיום_משוער = x.Dates, כמות = x.Camut }).ToList();

            FlagUpdate = false;
            FlagAdd = false;
            notPossible();
            dg1.DataSource = tbLDiamondFoler.GetList().Where(x => x.Kodya.ToString() == st).Select(x => new { קודיהלום = x.ThisDiamondWork().Kodya, תז = x.ThisWorker().Id, שם_פועל = x.ThisWorker().Lname + "  " + x.ThisWorker().Fname, התחלה = x.DateGo, סיום = x.DateBack, שלב = x.ThisLevel().Teur + "  " + x.ThisLevel().Part }).ToList();
          //if(dg1.RowCount<1)
          //  {
          //     //for(int i=0;i<dy.Camut;i++)
          //     // {

          //          DiamondFoler df = new DiamondFoler();
          //          df.Kodm = tbLDiamondFoler.GetNextKey();
          //          df.Kodya = Convert.ToInt32(st);
          //          df.DateGo = DateTime.Today;
          //          df.DateBack = DateTime.Today;
          //          df.Level = 0;
          //          tbLDiamondFoler.AddNew(df);


          //      //}

                //dg1.DataSource = tbLDiamondFoler.GetList();
            //}
            
            
            this.st = st;
            button2.Enabled =false;


        }

        private void Possible()
        {
            panel2.Visible = true;
            panel1.Visible = false;
            btnSave.Visible = true;
            btnCancle.Visible = true;


        }

        private void notPossible()
        {
            panel2.Visible = false;
            panel1.Visible = true;
            FlagAdd = false;
            FlagUpdate = false;
            btnSave.Visible = false;
            btnCancle.Visible = false;

        }









        private bool CreateFields(DiamondFoler d)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                d.Kodm = tbLDiamondFoler.GetNextKey();
            }
            catch (Exception ex)
            {

                ok = false;
            }

            try
            {
                d.Kodya = Convert.ToInt32(st);
            }
            catch (Exception ex)
            {

                ok = false;
            }
            try
            {
                d.DateGo = DateTime.Today;
            }
            catch (Exception ex)
            {

                ok = false;
            }

            try
            {
                d.Id = txtId.Text;
            }
            catch (Exception ex)
            {

                ok = false;
            }

            try
            {
                d.DateBack = DateTime.Today;
            }
            catch (Exception ex)
            {

                ok = false;
            }

            try
            {
                // d.Level = 
            }
            catch (Exception ex)
            {


                ok = false;
            }

            return ok;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (FlagUpdate)
            //    if (CreateFields(d))
            //    {

            //        DialogResult r = MessageBox.Show("האם לעדכן זה מעקב", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //        if (r == DialogResult.Yes)
            //        {
            //            tbLDiamondFoler.UpdateRow(d);
            //            notPossible();
            //        }

            //    }
            //if (FlagAdd)
            //{
            //    Worker w = new Worker();

            //    {
            //        if (CreateFields(d))
            //        {
            //            DialogResult r = MessageBox.Show("האם לעדכן זה מעקב", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //            if (r == DialogResult.Yes)
            //            {
            //                tbLDiamondFoler.AddNew(d);
            //                notPossible();
            //            }
            //        }


            //    }

            //}
            notPossible();

            errorProvider1.Clear();

        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            KindEDB tblK = new KindEDB();

            if (SelectDG(dg2))
            {
                string st = dg2.SelectedRows[0].Cells[0].Value.ToString();
                DiamondFoler d1 = tbLDiamondFoler.GetList().Where(x => x.Kodya.ToString() == st && x.DateGo == x.DateBack).FirstOrDefault();
                if (d1 != null)
                {
                    MessageBox.Show(" יהלום זה עדיין בתהליך פעיל " + d1.ThisLevel().Teur);
                  
                    
                }
                else
                {

                    btnAdd.Enabled = true;
                    FlagAdd = true;
                    FlagUpdate = false;
                    d1 = tbLDiamondFoler.GetList().Where(x => x.Kodya.ToString() == st).FirstOrDefault();
                    if (d1 == null)
                    {
                        kk = 1;
                        lblIbud.Text = tblK.Find(kk.ToString()).Teur + "  " + tblK.Find(kk.ToString()).Part;
                        
                        WorkerDB tblW = new WorkerDB();
                       
                        dgWork.DataSource = tblW.GetList().Where(x => x.KodE == kk && x.Status == true).Select(x => new { תז = x.Id, שם = x.Fname, שם_משפחה = x.Lname, קוד = x.KodE, תאור = x.ThisK().Teur, חלק = x.ThisK().Part, מחיר = x.ThisK().FirstPrice, }).ToList();
                    }
                    else
                    {


                        kk = tbLDiamondFoler.GetList().Where(x => x.Kodya.ToString() == st).ToList().OrderBy(t => t.Level).LastOrDefault().Level;
                        if (kk == 7)
                        {
                            MessageBox.Show(" יהלום זה סיים תהליך עיבוד ");

                        }
                        else
                        {
                            kk++;

                            lblIbud.Text = tblK.Find(kk.ToString()).Teur + "  " + tblK.Find(kk.ToString()).Part;
                          
                            WorkerDB tblW = new WorkerDB();
                            
                            dgWork.DataSource = tblW.GetList().Where(x => x.KodE == kk&& x.Status == true).Select(x => new { תז = x.Id, שם = x.Fname, שם_משפחה = x.Lname, קוד = x.KodE, תאור = x.ThisK().Teur, חלק = x.ThisK().Part, מחיר = x.ThisK().FirstPrice, }).ToList();
                        }

                        Possible();
                    }
                }
            }
          
            
       
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FlagAdd = true;
            FlagUpdate = false;
            txtId.ReadOnly = true;
            string st = dg1.SelectedRows[0].Cells[0].Value.ToString();
            d = tbLDiamondFoler.Find(st);

            Possible();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dg1.DataSource = tbLDiamondFoler.GetList().Where(x => x.Kodya.ToString() == st).Select(x => new { קודיהלום = x.ThisDiamondWork().Kodya, תז = x.ThisWorker().Id, שם_פועל = x.ThisWorker().Lname + "  " + x.ThisWorker().Fname, התחלה = x.DateGo, סיום = x.DateBack, שלב = x.ThisLevel().Teur + "  " + x.ThisLevel().Part }).ToList();
            //dg1.DataSource = tbLDiamondFoler.GetList().Select(x => new { קוד_מעקב = x.Kodm, תז_פועל = x.Id, שם_פועל = x.ThisWorker().Lname + "  " + x.ThisWorker().Fname }).ToList();
            errorProvider1.Clear();
        }






        private void btnCancle_Click(object sender, EventArgs e)
        {
            notPossible();

            errorProvider1.Clear();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgWork))
            {

                string st = dg2.SelectedRows[0].Cells[0].Value.ToString();
                string st1 = dgWork.SelectedRows[0].Cells[0].Value.ToString();
                WorkerDB tblw = new WorkerDB();
                Worker worker = tblw.GetList().Where(x => x.Id.ToString() == st1).First();
                if (worker.Status == true)
                {
                    DiamondFoler diamondFoler = new DiamondFoler();
                    diamondFoler.Kodm = Convert.ToInt32(tbLDiamondFoler.GetNextKey().ToString());
                    diamondFoler.Kodya = Convert.ToInt32(st);
                    diamondFoler.DateGo = DateTime.Today;
                    diamondFoler.DateBack = DateTime.Today;
                    diamondFoler.Level = kk;
                    diamondFoler.Id = st1;
                    tbLDiamondFoler.AddNew(diamondFoler);
                    dg1.DataSource = tbLDiamondFoler.GetList().Where(x => x.Kodya.ToString() == st).Select(x => new { קוד_מעקב = x.Kodm, תז_פועל = x.Id, שם_פועל = x.ThisWorker().Lname + "  " + x.ThisWorker().Fname }).ToList();
                    btnAdd.Enabled = false;
                    panel2.Visible = false;
                    panel1.Visible = true;
                    worker.Status = false;
                    tblw.UpdateRow(worker);
                }
                else

                MessageBox.Show("עובד זה היה פעיל");
             
               

            }
            //dg1.DataSource = tbLDiamondFoler.GetList().Select(x => new { קודיהלום = x.ThisDiamondWork().Kodya, תז = x.ThisWorker().Id, שם_פועל = x.ThisWorker().Lname + "  " + x.ThisWorker().Fname, התחלה = x.DateGo, סיום = x.DateBack, שלב = x.ThisLevel().Teur + "  " + x.ThisLevel().Part }).ToList();

        }
        private bool SelectDG(DataGridView dg)
        {


            return (dg.SelectedRows.Count >= 1);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (SelectDG(dg1))
            {
                string st = dg1.SelectedRows[0].Cells[1].Value.ToString();
                dateTimePicker1.Visible = true;
                button2.Enabled = true;
                WorkerDB tblw = new WorkerDB();
                Worker worker = tblw.GetList().Where(x => x.Id.ToString() == st).First();
                worker.Status = true;
                tblw.UpdateRow(worker);
            }
        
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmark.Text !="")
            {
                if (SelectDG(dg1))
                {
                    Diary d1 = new Diary();
                    DiaryDB tbLDiary = new DiaryDB();
                    d1.Kodyo = Convert.ToInt32(tbLDiary.GetNextKey().ToString());
                    d1.Id = d.Id;
                    d1.Kodya = d.Kodya;
                    d1.detes = d.DateGo;
                    d1.detef = d.DateBack;
                    d1.Mark = Convert.ToInt32(txtmark.Text);
                    KindEDB tblkindE = new KindEDB();
                    KindE kindE = tblkindE.GetList().Find(x => x.KodE == d.Level);
                    d1.Pricew = ((kindE.FirstPrice * Convert.ToInt32(txtmark.Text)) / 100.0);
                    tbLDiary.AddNew(d1);
                    //dg1.DataSource = tbLDiamondFoler.GetList().Where(x => x.Kodya.ToString() == st).Select(x => new { קוד_מעקב = x.Kodm, תז_פועל = x.Id, שם_פועל = x.ThisWorker().Lname + "  " + x.ThisWorker().Fname }).ToList();
                    panel3.Visible = false;
                    button2.Enabled=false;
                }
            }
        }
        


      

        private void dg2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectDG(dg2))
            {
                string st1 = dg2.SelectedRows[0].Cells[0].Value.ToString();
                dg1.DataSource = tbLDiamondFoler.GetList().Where(x => x.Kodya.ToString() == st).ToList().Select(x => new { קודיהלום = x.ThisDiamondWork().Kodya, תז = x.ThisWorker().Id, שם_פועל = x.ThisWorker().Lname + "  " + x.ThisWorker().Fname, התחלה = x.DateGo, סיום = x.DateBack, שלב = x.ThisLevel().Teur + "  " + x.ThisLevel().Part }).ToList();


            }
        }

        private void dg2_Click(object sender, EventArgs e)
        {
            if (SelectDG(dg2))
            {
                string st1 = dg2.SelectedRows[0].Cells[0].Value.ToString();
                dg1.DataSource = tbLDiamondFoler.GetList().Where(x => x.Kodya.ToString() == st1).ToList().Select(x => new { קודיהלום = x.ThisDiamondWork().Kodya, תז = x.ThisWorker().Id, שם_פועל = x.ThisWorker().Lname + "  " + x.ThisWorker().Fname, התחלה = x.DateGo, סיום = x.DateBack, שלב = x.ThisLevel().Teur + "  " + x.ThisLevel().Part }).ToList();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string st1 = dg1.SelectedRows[0].Cells[0].Value.ToString();
            d = tbLDiamondFoler.GetList().Find(x => x.Kodya.ToString() == st1);
            d.DateBack = dateTimePicker1.Value;
            tbLDiamondFoler.UpdateRow(d);
            dateTimePicker1.Visible = false;
            MessageBox.Show("קבע ציון לפועל " + d.ThisWorker().Fname + "  " + d.ThisWorker().Lname);
            panel3.Visible = true;
            dateTimePicker1.Visible = false;
        }

    }
}