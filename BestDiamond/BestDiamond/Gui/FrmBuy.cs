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
    public partial class FrmBuy : Form
    {
        private Buy b;
        private BuyDB tblb;
        private Gelem g;
        private GelemDB tblg;
        private Rama r;
        private RamaDB tblr;
        private bool flagAdd = false;


        public FrmBuy()
        {


            InitializeComponent();
            tblb = new BuyDB();
            tblg = new GelemDB();
            tblr = new RamaDB();
            btn.Visible = true;

        }
        private bool SelectDG(DataGridView dg)
        {


            return (dg.SelectedRows.Count >= 1);
        }


        private void gbO_Enter(object sender, EventArgs e)
        {

        }




        private void DateO_ValueChanged(object sender, EventArgs e)
        {
            btnDelParit.Visible = false;
            //gbPO.Visible = false;
            dgP.DataSource = null;
            dgB.DataSource = tblb.GetList().Where(x => x.Dateb==DateO.Value).Select(x => new { קוד_קניה = x.Kodbuy, תאריך = x.Dateb, סכום_סופי = x.Sumpf, }).ToList();
        }

        private void dgB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectDG(dgB))
            {
                string st = dgB.SelectedRows[0].Cells[0].Value.ToString();
                b = tblb.Find(st);
                dgP.DataSource = tblg.GetList().Where(x => x.Kodbuy.ToString() == st).Select(x => new { קוד_חומר_גלם = x.KodGelem, משקל = x.Mishkal, כמות = x.Camut, סך_לתשלום = x.Pricesuch, צבע = x.Color, חבילה = x.Pack, רמת_ניקיון = x.ThisRama().Teur }).ToList();

            }
        }

        private void btnDelParit_Click(object sender, EventArgs e)
        {
            int kodb, kodg;
            if (SelectDG(dgP))
            {

                if (b.Dateb < DateTime.Today)
                {
                    errorProvider1.SetError(dgP, " הזמנה זו כבר בוצעה");
                }
                else
                {
                    DialogResult r = MessageBox.Show("האם לבטל פריט זה", "אשור ביטול", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (r == DialogResult.Yes)
                    {

                        kodb = Convert.ToInt32(dgP.SelectedRows[0].Cells[0].Value.ToString());
                        string st = dgP.SelectedRows[0].Cells[0].Value.ToString();
                        b = tblb.Find(st);
                        tblg.DeleteRow(g.KodGelem.ToString(), kodb.ToString());
                        b.Sumpf =b.Sumpf-( tblg.GetList().Where(x => x.Kodbuy == g.Kodbuy).Sum(x => x.Pricesuch));
                        tblb.UpdateRow(b);
                        UpdateDG();
                    }

                }
            }
        }
        private void UpdateDG()
        {

            if (tblb.Find(b.Kodbuy.ToString()) != null)
            {
                dgB.DataSource = tblb.GetList().Where(x => x.Kodbuy == b.Kodbuy).Select(x => new { קוד_קניה = x.Kodbuy, תאריך = x.Dateb, סכום_סופי = x.Sumpf, }).ToList();
                dgP.DataSource = tblg.GetList().Where(x => x.Kodbuy == b.Kodbuy).Select(x => new { קוד_חומר_גלם = x.KodGelem, משקל = x.Mishkal, כמות = x.Camut, סך_לתשלום = x.Pricesuch, צבע = x.Color, רמת_ניקיון = x.ThisRama().Teur }).ToList();
            }
            else
            {
                dgB.DataSource = tblb.GetList().Select(x => new { קוד_קניה = x.Kodbuy, תאריך = x.Dateb, סכום_סופי = x.Sumpf, }).ToList();
                dgP.DataSource = null;
            }


        }

        private void ClearControl()
        {

            txtkodbuy.Text = "";
            DateO.Value = DateTime.Today.Date;
            dgP.DataSource = null;
            btnDelParit.Visible = false;
            gbPO.Visible = false;
            txtkodbuy.ReadOnly = true;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearControl();
            dgB.DataSource = tblb.GetList().Select(x => new { קוד_קניה = x.Kodbuy, תאריך = x.Dateb, סכום_סופי = x.Sumpf, }).ToList();
            errorProvider1.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgB))
            {
                if (b.Dateb < DateTime.Today)
                {
                    errorProvider1.SetError(dgB, " קניה זו כבר בוצעה");
                }
                else
                {
                    btnDelParit.Visible = true;
                    gbPO.Visible = true;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgB))
            {
                int key;
                gbO.Visible = true;
                gbPO.Visible = true;
                panel1.Visible = false;
                flagAdd = true;
                string st = dgB.SelectedRows[0].Cells[0].Value.ToString();
                if (tblg.GetList().Where(x => x.Kodbuy.ToString() == st).ToList().Count > 0)
                    key = tblg.GetList().Where(x => x.Kodbuy.ToString() == st).ToList().Max(x => x.KodGelem) + 1;
                else
                    key = 1;
                txtkod.Text = key.ToString();


                btnOKAdd.Visible = true;
                comrama.DataSource = tblr.GetList();

            }
        }
        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgB))
            {
                string st = dgB.SelectedRows[0].Cells[0].Value.ToString();
                b = tblb.Find((st));
                if (b.Dateb < DateTime.Today)
                {
                    errorProvider1.SetError(dgB, " הזמנה זו כבר בוצעה");
                }
                else
                {
                    DialogResult r = MessageBox.Show("האם לבטל הזמנה זו", "אשור ביטול", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {

                        tblb.DeleteRow(b.Kodbuy.ToString());
                        UpdateDG();
                    }
                }
            }
        }



        private void txtkod_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtCamut_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void comcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void comrama_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtkodbuy_TextChanged(object sender, EventArgs e)
        {
            btnDelParit.Visible = false;
            gbPO.Visible = false;
            dgP.DataSource = null;
            dgB.DataSource = tblb.GetList().Where(x => x.Kodbuy.ToString().StartsWith(txtkodbuy.Text)).Select(x => new { קוד_קניה = x.Kodbuy, תאריך = x.Dateb, סכום_סופי = x.Sumpf, }).ToList();
        }

        private void dgM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOKAdd_Click(object sender, EventArgs e)
        {
            int  count;
            double sum;
                if (txtCamut.Text != "" && ValidateUtil.IsNum(txtCamut.Text) && Convert.ToInt32(txtCamut.Text) > 0)
                if (txtsum.Text != "" && ValidateUtil.IsNum(txtsum.Text) && Convert.ToInt32(txtsum.Text) > 0)
                {
                    count = Convert.ToInt32(txtCamut.Text);
                    sum = Convert.ToDouble(txtsum.Text);


                    Gelem gelem = new Gelem();
                        Fill(gelem);
                        tblg.AddNew(gelem);
                    string st = dgB.SelectedRows[0].Cells[0].Value.ToString();
                  
                    Buy b1 = tblb.Find(st);
                         b1.Sumpf += sum;
                        tblb.UpdateRow(b1);
                        UpdateDG();
                        txtCamut.Text = " ";
                        comcolor.Text = " ";
                        txtsum.Text = " ";  
                        comrama.Text = " ";
                        txtkod.Text = "  ";
                        txtmishkal.Text = "  ";

                }
            }
     
        private void Fill(Gelem gelem)
        {
            string st = dgB.SelectedRows[0].Cells[0].Value.ToString();
            gelem.Kodbuy = Convert.ToInt32(st);
            gelem.KodGelem =Convert.ToInt32(txtkod.Text);
            gelem.Color = comcolor.Text;
            gelem.Pack = checkBox1.Checked;
            gelem.KodRama = ((Rama)(comrama.SelectedItem)).KodR;
            gelem.Camut = Convert.ToInt32(txtCamut.Text);
            gelem.Pricesuch = Convert.ToDouble( txtsum.Text);
            gelem.Mishkal= Convert.ToInt32(txtmishkal.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBuy_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            
                    b = new Buy();

                    DialogResult r = MessageBox.Show("האם להוסיף קניה ?", "אשור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (r == DialogResult.Yes)
                    {

                        b.Kodbuy = Convert.ToInt32(tblb.GetNextKey().ToString());
                        b.Dateb = DateTime.Today;
                        b.Sumpf = Convert.ToDouble("0");
                     txtkodbuy.Text = b.Kodbuy.ToString();
                        tblb.AddNew(b);
                        MessageBox.Show("הקניה  נרשמה", "אשור הוספה");
                        flagAdd = false;
                        dgB.DataSource = tblb.GetList().Where(x => x.Kodbuy == Convert.ToInt32(txtkodbuy.Text)).Select(x => new { קוד_קניה = x.Kodbuy, תאריך = x.Dateb, סכום_סופי = x.Sumpf, }).ToList();
                        gbPO.Visible = true;


                    }

        }

       

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgB))
            {
                DialogResult r = MessageBox.Show("האם למחוק קניה זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    string st = dgB.SelectedRows[0].Cells[0].Value.ToString();
                    tblb.DeleteRow(st);
                }
            }
        }
        private void dgB_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgB))
            {
                string st = dgB.SelectedRows[0].Cells[0].Value.ToString();
                b = tblb.Find(st);
                dgP.DataSource = tblg.GetList().Where(x => x.Kodbuy.ToString() == st).Select(x => new { קוד_קניה = x.Kodbuy, קוד_חומר_גלם = x.KodGelem, משקל = x.Mishkal, כמות = x.Camut, סך_לתשלום = x.Pricesuch, צבע = x.Color, רמת_ניקיון = x.KodRama }).ToList();

            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            gbPO.Visible = false;
            panel1.Visible = true;
        }

        private void gbPO_Enter(object sender, EventArgs e)
        {

        }

        private void dgP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }




