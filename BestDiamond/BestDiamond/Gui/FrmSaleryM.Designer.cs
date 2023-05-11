namespace BestDiamond.Gui
{
    partial class FrmSaleryM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleryM));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsa = new System.Windows.Forms.TextBox();
            this.txtscom = new System.Windows.Forms.TextBox();
            this.chId = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtkod = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "משכורת";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "סכום אבנים";
            // 
            // txtsa
            // 
            this.txtsa.Location = new System.Drawing.Point(12, 256);
            this.txtsa.Name = "txtsa";
            this.txtsa.Size = new System.Drawing.Size(160, 20);
            this.txtsa.TabIndex = 84;
            this.txtsa.TextChanged += new System.EventHandler(this.txtsa_TextChanged);
            // 
            // txtscom
            // 
            this.txtscom.Location = new System.Drawing.Point(12, 214);
            this.txtscom.Name = "txtscom";
            this.txtscom.Size = new System.Drawing.Size(160, 20);
            this.txtscom.TabIndex = 83;
            this.txtscom.TextChanged += new System.EventHandler(this.txtscom_TextChanged);
            // 
            // chId
            // 
            this.chId.FormattingEnabled = true;
            this.chId.Location = new System.Drawing.Point(12, 168);
            this.chId.Name = "chId";
            this.chId.Size = new System.Drawing.Size(160, 21);
            this.chId.TabIndex = 80;
            this.chId.SelectedIndexChanged += new System.EventHandler(this.chId_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(57, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 78);
            this.panel2.TabIndex = 79;
            this.panel2.Visible = false;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancle.Location = new System.Drawing.Point(154, 13);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(102, 39);
            this.btnCancle.TabIndex = 26;
            this.btnCancle.Text = "בטל";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(3, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 88;
            this.button1.Text = "עדכון משכורת";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRefresh.Location = new System.Drawing.Point(309, 270);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 44);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "רענן";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(12, 73);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(160, 20);
            this.txtm.TabIndex = 72;
            this.txtm.TextChanged += new System.EventHandler(this.txtm_TextChanged);
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(0, 16);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(160, 20);
            this.txtkod.TabIndex = 71;
            this.txtkod.TextChanged += new System.EventHandler(this.txtkod_TextChanged);
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(12, 121);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(160, 20);
            this.txty.TabIndex = 69;
            this.txty.TextChanged += new System.EventHandler(this.txty_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "שנה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(205, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "ת.ז פועל";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "חודש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "קוד";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "ת.ז. לקוח";
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(415, 5);
            this.dg1.Name = "dg1";
            this.dg1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dg1.Size = new System.Drawing.Size(448, 222);
            this.dg1.TabIndex = 68;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNew.Location = new System.Drawing.Point(105, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 44);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.Location = new System.Drawing.Point(3, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 44);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.Location = new System.Drawing.Point(215, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 39);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(484, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 81);
            this.panel1.TabIndex = 78;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtkod);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(46, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 58);
            this.panel3.TabIndex = 88;
            // 
            // FrmSaleryM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtscom);
            this.Controls.Add(this.chId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg1);
            this.DoubleBuffered = true;
            this.Name = "FrmSaleryM";
            this.Text = "FrmSalery";
            this.Load += new System.EventHandler(this.FrmSaleryM_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsa;
        private System.Windows.Forms.TextBox txtscom;
        private System.Windows.Forms.ComboBox chId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel3;
    }
}