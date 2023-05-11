namespace BestDiamond.Gui
{
    partial class FrmDiary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiary));
            this.label6 = new System.Windows.Forms.Label();
            this.comya = new System.Windows.Forms.ComboBox();
            this.comId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmark = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtyo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.txtp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 137;
            this.label6.Text = "ציון";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comya
            // 
            this.comya.FormattingEnabled = true;
            this.comya.Location = new System.Drawing.Point(9, 117);
            this.comya.Name = "comya";
            this.comya.Size = new System.Drawing.Size(160, 21);
            this.comya.TabIndex = 136;
            this.comya.SelectedIndexChanged += new System.EventHandler(this.comya_SelectedIndexChanged);
            // 
            // comId
            // 
            this.comId.FormattingEnabled = true;
            this.comId.Location = new System.Drawing.Point(9, 75);
            this.comId.Name = "comId";
            this.comId.Size = new System.Drawing.Size(160, 21);
            this.comId.TabIndex = 135;
            this.comId.SelectedIndexChanged += new System.EventHandler(this.comId_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 134;
            this.label8.Text = "קוד יהלום";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 133;
            this.label7.Text = "תאריך סיום";
            // 
            // txtmark
            // 
            this.txtmark.Location = new System.Drawing.Point(249, 376);
            this.txtmark.Name = "txtmark";
            this.txtmark.Size = new System.Drawing.Size(160, 20);
            this.txtmark.TabIndex = 132;
            this.txtmark.Visible = false;
            this.txtmark.TextChanged += new System.EventHandler(this.txtmark_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(24, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 70);
            this.panel2.TabIndex = 130;
            this.panel2.Visible = false;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancle.Location = new System.Drawing.Point(18, 16);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(102, 39);
            this.btnCancle.TabIndex = 26;
            this.btnCancle.Text = "בטל";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.Location = new System.Drawing.Point(151, 16);
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
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 74);
            this.panel1.TabIndex = 129;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.Location = new System.Drawing.Point(27, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 44);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNew.Location = new System.Drawing.Point(153, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 44);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRefresh.Location = new System.Drawing.Point(429, 173);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 44);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "רענן";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // txtyo
            // 
            this.txtyo.Location = new System.Drawing.Point(9, 29);
            this.txtyo.Name = "txtyo";
            this.txtyo.Size = new System.Drawing.Size(160, 20);
            this.txtyo.TabIndex = 125;
            this.txtyo.TextChanged += new System.EventHandler(this.txtyo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 128;
            this.label5.Text = "תארין תחילת עבודה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(260, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "ת.ז.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "קוד יומן עבודה";
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(538, 87);
            this.dg1.Name = "dg1";
            this.dg1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dg1.Size = new System.Drawing.Size(413, 222);
            this.dg1.TabIndex = 123;
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(9, 251);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(160, 20);
            this.txtp.TabIndex = 138;
            this.txtp.TextChanged += new System.EventHandler(this.txtp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 139;
            this.label1.Text = "תשלום";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(9, 161);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(160, 20);
            this.txtc.TabIndex = 142;
            // 
            // txtg
            // 
            this.txtg.Location = new System.Drawing.Point(9, 201);
            this.txtg.Name = "txtg";
            this.txtg.Size = new System.Drawing.Size(160, 20);
            this.txtg.TabIndex = 143;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(97, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 43);
            this.button1.TabIndex = 144;
            this.button1.Text = "עידכון ציון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtg);
            this.panel3.Controls.Add(this.txtc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtp);
            this.panel3.Controls.Add(this.comya);
            this.panel3.Controls.Add(this.comId);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtyo);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 281);
            this.panel3.TabIndex = 145;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(619, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 183);
            this.panel4.TabIndex = 146;
            // 
            // FrmDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 544);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmark);
            this.Controls.Add(this.dg1);
            this.DoubleBuffered = true;
            this.Name = "FrmDiary";
            this.Text = "FrmDiary";

            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comya;
        private System.Windows.Forms.ComboBox comId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmark;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtyo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtg;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}