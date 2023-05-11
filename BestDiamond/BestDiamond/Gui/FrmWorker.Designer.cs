namespace BestDiamond.Gui
{
    partial class FrmWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWorker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbsug = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.txtch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(294, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 81);
            this.panel1.TabIndex = 55;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRefresh.Location = new System.Drawing.Point(404, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 44);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "רענן";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 44);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDel.Location = new System.Drawing.Point(141, 16);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(88, 44);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "מחק";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNew.Location = new System.Drawing.Point(267, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 44);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(12, 92);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(160, 20);
            this.txtFName.TabIndex = 48;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(12, 53);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(160, 20);
            this.txtLName.TabIndex = 47;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(12, 133);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(160, 20);
            this.txtP.TabIndex = 45;
            this.txtP.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "פלאפון";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(187, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "קוד התמחות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "שם פרטי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "שם משפחה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "ת.ז. לקוח";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 20);
            this.txtId.TabIndex = 46;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged_1);
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(359, 20);
            this.dg1.Name = "dg1";
            this.dg1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dg1.Size = new System.Drawing.Size(494, 222);
            this.dg1.TabIndex = 44;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(492, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 78);
            this.panel2.TabIndex = 59;
            this.panel2.Visible = false;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancle.Location = new System.Drawing.Point(11, 14);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // cbsug
            // 
            this.cbsug.FormattingEnabled = true;
            this.cbsug.Location = new System.Drawing.Point(12, 180);
            this.cbsug.Name = "cbsug";
            this.cbsug.Size = new System.Drawing.Size(160, 21);
            this.cbsug.TabIndex = 60;
            this.cbsug.SelectedIndexChanged += new System.EventHandler(this.cbsug_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "מספ חשבון";
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Location = new System.Drawing.Point(197, 358);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(59, 17);
            this.ch1.TabIndex = 62;
            this.ch1.Text = "סטטוס";
            this.ch1.UseVisualStyleBackColor = true;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(12, 229);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(160, 20);
            this.txtb.TabIndex = 63;
            this.txtb.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(12, 274);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(160, 20);
            this.txts.TabIndex = 64;
            // 
            // txtch
            // 
            this.txtch.Location = new System.Drawing.Point(15, 317);
            this.txtch.Name = "txtch";
            this.txtch.Size = new System.Drawing.Size(157, 20);
            this.txtch.TabIndex = 65;
            this.txtch.TextChanged += new System.EventHandler(this.txtch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "קוד בנק";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "קוד סניף";
            // 
            // FrmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 556);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtch);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbsug);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dg1);
            this.DoubleBuffered = true;
            this.Name = "FrmWorker";
            this.Text = "FrmWorker";
          
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbsug;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.CheckBox ch1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}