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

    public partial class FrmRama : Form
    {
        private Rama rama;
        private RamaDB tblRama;


     

         
    
        public FrmRama()
        {
            InitializeComponent();
            tblRama = new RamaDB();
            dg.DataSource = tblRama.GetList();
            dg.DataSource = tblRama.GetList().Select(x => new { קוד = x.KodR, תאור = x.Teur }).ToList();
            panel1.Visible = false;
        }

        

        private void btncadas_Click(object sender, EventArgs e)
        {
            txt1.Text = tblRama.GetNextKey().ToString();
            txt2.Text = " ";
            Possible();
            txt2.Select();
        }
        private void Possible()
        {
            panel1.Visible = true;
            btncadas.Visible = false;
            txt2.ReadOnly = false;
        }
        private void NotPossible()
        {
            panel1.Visible = false;
            btncadas.Visible = true;

        }

        private void btnsh_Click(object sender, EventArgs e)
        {
            Rama r1 = new Rama();
            if (tblRama.GetList().Exists(x => x.Teur == this.txt2.Text))
            {
                MessageBox.Show("קיים כבר סוג זה", "הוספת שגיאת", MessageBoxButtons.OK);
                txt2.Text = " ";
            }
            else
                 if (CreateFields(r1))
            {

                DialogResult r = MessageBox.Show("האם להוסיף סוג זה", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    tblRama.AddNew(r1);
                    dg.DataSource = tblRama.GetList().Select(x => new { קוד = x.KodR, תאור = x.Teur}).ToList();
                    NotPossible();
                }

            }
        }

        private bool CreateFields(Rama r)
        {
            bool ok = true;
            errorProvider1.Clear();
            r.KodR = Convert.ToInt32(txt1.Text);

            try
            {
                r.Teur = txt2.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt2, ex.Message);
                ok = false;
            }
            return ok;
        }

        private void btnbatel_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם למחוק רמה זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                string st = dg.SelectedRows[0].Cells[0].Value.ToString();
                tblRama.DeleteRow(st);
            }
        }
    }
}
    
