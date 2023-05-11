namespace BestDiamond.Gui
{
    partial class FrmDiamondFoler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiamondFoler));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIbud = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgWork = new System.Windows.Forms.DataGridView();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(30, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 78);
            this.panel2.TabIndex = 79;
            this.panel2.Visible = false;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancle.Location = new System.Drawing.Point(31, 14);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(102, 39);
            this.btnCancle.TabIndex = 26;
            this.btnCancle.Text = "בטל";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.Location = new System.Drawing.Point(169, 14);
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
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(114, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 81);
            this.panel1.TabIndex = 78;
            
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.Location = new System.Drawing.Point(187, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(237, 44);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "עדכן החזרה";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRefresh.Location = new System.Drawing.Point(654, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 44);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "רענן";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNew.Location = new System.Drawing.Point(445, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(194, 44);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "הוסף תהליך עיבוד";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "ת.ז. לקוח";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(-83, -19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 20);
            this.txtId.TabIndex = 70;
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(592, 109);
            this.dg1.Name = "dg1";
            this.dg1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dg1.Size = new System.Drawing.Size(446, 219);
            this.dg1.TabIndex = 68;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(956, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 132;
            this.label9.Text = "פרטי מעקב יהלום";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIbud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dgWork);
            this.groupBox1.Location = new System.Drawing.Point(68, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(443, 172);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי שיבוץ למעקב";
            // 
            // lblIbud
            // 
            this.lblIbud.AutoSize = true;
            this.lblIbud.Location = new System.Drawing.Point(223, 26);
            this.lblIbud.Name = "lblIbud";
            this.lblIbud.Size = new System.Drawing.Size(0, 13);
            this.lblIbud.TabIndex = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 137;
            this.label3.Text = "שלב העיבוד";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "שבץ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgWork
            // 
            this.dgWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWork.Location = new System.Drawing.Point(138, 57);
            this.dgWork.Name = "dgWork";
            this.dgWork.Size = new System.Drawing.Size(281, 82);
            this.dgWork.TabIndex = 0;
            // 
            // dg2
            // 
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Location = new System.Drawing.Point(12, 12);
            this.dg2.Name = "dg2";
            this.dg2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dg2.Size = new System.Drawing.Size(483, 73);
            this.dg2.TabIndex = 134;
            this.dg2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg2_CellContentClick);
            this.dg2.Click += new System.EventHandler(this.dg2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtmark);
            this.panel3.Location = new System.Drawing.Point(512, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 114);
            this.panel3.TabIndex = 135;
            this.panel3.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(3, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 43);
            this.button1.TabIndex = 147;
            this.button1.Text = "עידכון ציון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 146;
            this.label6.Text = "ציון";
            // 
            // txtmark
            // 
            this.txtmark.Location = new System.Drawing.Point(155, 50);
            this.txtmark.Name = "txtmark";
            this.txtmark.Size = new System.Drawing.Size(160, 20);
            this.txtmark.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 136;
            this.label2.Text = "פרטי היהלום";
            // 
            // FrmDiamondFoler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dg1);
            this.DoubleBuffered = true;
            this.Name = "FrmDiamondFoler";
            this.Text = "FrmDiamondFoler";

            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgWork;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIbud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}