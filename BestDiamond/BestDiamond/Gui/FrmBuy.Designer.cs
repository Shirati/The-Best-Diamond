namespace BestDiamond.Gui
{
    partial class FrmBuy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuy));
            this.dgP = new System.Windows.Forms.DataGridView();
            this.dgB = new System.Windows.Forms.DataGridView();
            this.btnDelParit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtkodbuy = new System.Windows.Forms.TextBox();
            this.DateO = new System.Windows.Forms.DateTimePicker();
            this.תאריך = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtkod = new System.Windows.Forms.TextBox();
            this.txtCamut = new System.Windows.Forms.TextBox();
            this.comcolor = new System.Windows.Forms.ComboBox();
            this.comrama = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnOKAdd = new System.Windows.Forms.Button();
            this.gbPO = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmishkal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbO = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgB)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbPO.SuspendLayout();
            this.gbO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgP
            // 
            this.dgP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgP.Location = new System.Drawing.Point(92, 175);
            this.dgP.Name = "dgP";
            this.dgP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgP.Size = new System.Drawing.Size(515, 90);
            this.dgP.TabIndex = 42;
            this.dgP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgP_CellContentClick);
            // 
            // dgB
            // 
            this.dgB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgB.Location = new System.Drawing.Point(92, 19);
            this.dgB.Name = "dgB";
            this.dgB.Size = new System.Drawing.Size(515, 112);
            this.dgB.TabIndex = 43;
            this.dgB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgB_CellContentClick);
            this.dgB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgB_CellContentClick);
            this.dgB.Click += new System.EventHandler(this.dgB_Click);
            // 
            // btnDelParit
            // 
            this.btnDelParit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelParit.Location = new System.Drawing.Point(0, 175);
            this.btnDelParit.Name = "btnDelParit";
            this.btnDelParit.Size = new System.Drawing.Size(91, 31);
            this.btnDelParit.TabIndex = 44;
            this.btnDelParit.Text = "בטל פריט";
            this.btnDelParit.UseVisualStyleBackColor = true;
            this.btnDelParit.Click += new System.EventHandler(this.btnDelParit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(210, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 49;
            this.label9.Text = "קוד קניה";
            // 
            // txtkodbuy
            // 
            this.txtkodbuy.Location = new System.Drawing.Point(12, 27);
            this.txtkodbuy.Name = "txtkodbuy";
            this.txtkodbuy.Size = new System.Drawing.Size(189, 20);
            this.txtkodbuy.TabIndex = 45;
            this.txtkodbuy.TextChanged += new System.EventHandler(this.txtkodbuy_TextChanged);
            // 
            // DateO
            // 
            this.DateO.Location = new System.Drawing.Point(12, 78);
            this.DateO.Name = "DateO";
            this.DateO.Size = new System.Drawing.Size(189, 20);
            this.DateO.TabIndex = 50;
            this.DateO.ValueChanged += new System.EventHandler(this.DateO_ValueChanged);
            // 
            // תאריך
            // 
            this.תאריך.AutoSize = true;
            this.תאריך.Location = new System.Drawing.Point(230, 78);
            this.תאריך.Name = "תאריך";
            this.תאריך.Size = new System.Drawing.Size(40, 13);
            this.תאריך.TabIndex = 51;
            this.תאריך.Text = "תאריך";
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn.Location = new System.Drawing.Point(28, 137);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(136, 35);
            this.btn.TabIndex = 52;
            this.btn.Text = "חדש קניה";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.Location = new System.Drawing.Point(162, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 46);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelOrder.Location = new System.Drawing.Point(38, 22);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(85, 46);
            this.btnDelOrder.TabIndex = 56;
            this.btnDelOrder.Text = "ביטול";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDelOrder);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(82, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 87);
            this.panel1.TabIndex = 57;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRefresh.Location = new System.Drawing.Point(280, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 46);
            this.btnRefresh.TabIndex = 57;
            this.btnRefresh.Text = "רענן";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "קוד חומר גלם";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "כמות";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(475, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "צבע";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(441, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "רמת ניקיון";
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(326, 29);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(100, 20);
            this.txtkod.TabIndex = 63;
            this.txtkod.Click += new System.EventHandler(this.txtkod_TextChanged);
            this.txtkod.TextChanged += new System.EventHandler(this.txtkod_TextChanged);
            // 
            // txtCamut
            // 
            this.txtCamut.Location = new System.Drawing.Point(326, 64);
            this.txtCamut.Name = "txtCamut";
            this.txtCamut.Size = new System.Drawing.Size(100, 20);
            this.txtCamut.TabIndex = 64;
            this.txtCamut.TextChanged += new System.EventHandler(this.txtCamut_TextChanged);
            // 
            // comcolor
            // 
            this.comcolor.FormattingEnabled = true;
            this.comcolor.Items.AddRange(new object[] {
            "צהוב",
            "אדום",
            "לבן",
            "כחול"});
            this.comcolor.Location = new System.Drawing.Point(326, 94);
            this.comcolor.Name = "comcolor";
            this.comcolor.Size = new System.Drawing.Size(100, 21);
            this.comcolor.TabIndex = 65;
            this.comcolor.SelectedIndexChanged += new System.EventHandler(this.comcolor_SelectedIndexChanged);
            // 
            // comrama
            // 
            this.comrama.FormattingEnabled = true;
            this.comrama.Location = new System.Drawing.Point(326, 132);
            this.comrama.Name = "comrama";
            this.comrama.Size = new System.Drawing.Size(100, 21);
            this.comrama.TabIndex = 66;
            this.comrama.SelectedIndexChanged += new System.EventHandler(this.comrama_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(441, 263);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 67;
            this.checkBox1.Text = "חבילה";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnOKAdd
            // 
            this.btnOKAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOKAdd.Location = new System.Drawing.Point(202, 249);
            this.btnOKAdd.Name = "btnOKAdd";
            this.btnOKAdd.Size = new System.Drawing.Size(75, 31);
            this.btnOKAdd.TabIndex = 68;
            this.btnOKAdd.Text = "ok";
            this.btnOKAdd.UseVisualStyleBackColor = true;
            this.btnOKAdd.Click += new System.EventHandler(this.btnOKAdd_Click);
            // 
            // gbPO
            // 
            this.gbPO.BackColor = System.Drawing.Color.Gray;
            this.gbPO.Controls.Add(this.btnEnd);
            this.gbPO.Controls.Add(this.txtsum);
            this.gbPO.Controls.Add(this.label2);
            this.gbPO.Controls.Add(this.txtmishkal);
            this.gbPO.Controls.Add(this.label1);
            this.gbPO.Controls.Add(this.btnNew);
            this.gbPO.Controls.Add(this.comcolor);
            this.gbPO.Controls.Add(this.btnOKAdd);
            this.gbPO.Controls.Add(this.label7);
            this.gbPO.Controls.Add(this.checkBox1);
            this.gbPO.Controls.Add(this.label10);
            this.gbPO.Controls.Add(this.label11);
            this.gbPO.Controls.Add(this.comrama);
            this.gbPO.Controls.Add(this.label12);
            this.gbPO.Controls.Add(this.txtkod);
            this.gbPO.Controls.Add(this.txtCamut);
            this.gbPO.Location = new System.Drawing.Point(569, 312);
            this.gbPO.Name = "gbPO";
            this.gbPO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbPO.Size = new System.Drawing.Size(579, 316);
            this.gbPO.TabIndex = 69;
            this.gbPO.TabStop = false;
            this.gbPO.Text = "בחר פרטי הזמנה";
            this.gbPO.Enter += new System.EventHandler(this.gbPO_Enter);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEnd.Location = new System.Drawing.Point(29, 94);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(93, 46);
            this.btnEnd.TabIndex = 74;
            this.btnEnd.Text = "סיום";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(326, 211);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(100, 20);
            this.txtsum.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "סכום לתשלום";
            // 
            // txtmishkal
            // 
            this.txtmishkal.Location = new System.Drawing.Point(326, 177);
            this.txtmishkal.Name = "txtmishkal";
            this.txtmishkal.Size = new System.Drawing.Size(100, 20);
            this.txtmishkal.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "משקל";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNew.Location = new System.Drawing.Point(29, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(93, 46);
            this.btnNew.TabIndex = 69;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gbO
            // 
            this.gbO.BackColor = System.Drawing.Color.Gray;
            this.gbO.Controls.Add(this.button1);
            this.gbO.Controls.Add(this.label13);
            this.gbO.Controls.Add(this.dgB);
            this.gbO.Controls.Add(this.btnDelParit);
            this.gbO.Controls.Add(this.dgP);
            this.gbO.Location = new System.Drawing.Point(442, 12);
            this.gbO.Name = "gbO";
            this.gbO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbO.Size = new System.Drawing.Size(687, 280);
            this.gbO.TabIndex = 70;
            this.gbO.TabStop = false;
            this.gbO.Text = "קניות";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(4, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 46;
            this.button1.Text = "מחק קניה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(612, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "פרטי קניה";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuy
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 639);
            this.Controls.Add(this.gbO);
            this.Controls.Add(this.gbPO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.תאריך);
            this.Controls.Add(this.DateO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtkodbuy);
            this.DoubleBuffered = true;
            this.Name = "FrmBuy";
            ((System.ComponentModel.ISupportInitialize)(this.dgP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbPO.ResumeLayout(false);
            this.gbPO.PerformLayout();
            this.gbO.ResumeLayout(false);
            this.gbO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.DataGridView dgP;
        private System.Windows.Forms.DataGridView dgB;
        private System.Windows.Forms.Button btnDelParit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtkodbuy;
        private System.Windows.Forms.DateTimePicker DateO;
        private System.Windows.Forms.Label תאריך;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.TextBox txtCamut;
        private System.Windows.Forms.ComboBox comcolor;
        private System.Windows.Forms.ComboBox comrama;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnOKAdd;
        private System.Windows.Forms.GroupBox gbPO;
        private System.Windows.Forms.GroupBox gbO;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmishkal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEnd;
    }
}