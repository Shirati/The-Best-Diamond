namespace BestDiamond.Gui
{
    partial class FrmRama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRama));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbatel = new System.Windows.Forms.Button();
            this.btnsh = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btncadas = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnbatel);
            this.panel1.Controls.Add(this.btnsh);
            this.panel1.Controls.Add(this.txt2);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Location = new System.Drawing.Point(40, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 182);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "תאור";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "קוד סוג";
            // 
            // btnbatel
            // 
            this.btnbatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnbatel.Location = new System.Drawing.Point(39, 132);
            this.btnbatel.Name = "btnbatel";
            this.btnbatel.Size = new System.Drawing.Size(75, 36);
            this.btnbatel.TabIndex = 3;
            this.btnbatel.Text = "בטל";
            this.btnbatel.UseVisualStyleBackColor = true;
            this.btnbatel.Click += new System.EventHandler(this.btnbatel_Click);
            // 
            // btnsh
            // 
            this.btnsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnsh.Location = new System.Drawing.Point(131, 132);
            this.btnsh.Name = "btnsh";
            this.btnsh.Size = new System.Drawing.Size(75, 36);
            this.btnsh.TabIndex = 2;
            this.btnsh.Text = "שמור";
            this.btnsh.UseVisualStyleBackColor = true;
            this.btnsh.Click += new System.EventHandler(this.btnsh_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(25, 76);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(25, 28);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 0;
            // 
            // btncadas
            // 
            this.btncadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btncadas.Location = new System.Drawing.Point(312, 292);
            this.btncadas.Name = "btncadas";
            this.btncadas.Size = new System.Drawing.Size(101, 42);
            this.btncadas.TabIndex = 4;
            this.btncadas.Text = "חדש";
            this.btncadas.UseVisualStyleBackColor = true;
            this.btncadas.Click += new System.EventHandler(this.btncadas_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(438, 55);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(283, 182);
            this.dg.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(438, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "מחק";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncadas);
            this.Controls.Add(this.dg);
            this.DoubleBuffered = true;
            this.Name = "FrmRama";
            this.Text = "FrmRama";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbatel;
        private System.Windows.Forms.Button btnsh;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btncadas;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}