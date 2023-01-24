namespace Excel
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Browse = new System.Windows.Forms.Button();
            this.TB_Path = new System.Windows.Forms.TextBox();
            this.BTN_Open = new System.Windows.Forms.Button();
            this.GB_Tools = new System.Windows.Forms.GroupBox();
            this.BTN_Fill = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_FillFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_FillTo = new System.Windows.Forms.TextBox();
            this.GB_Tools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Browse
            // 
            this.BTN_Browse.Location = new System.Drawing.Point(713, 12);
            this.BTN_Browse.Name = "BTN_Browse";
            this.BTN_Browse.Size = new System.Drawing.Size(86, 23);
            this.BTN_Browse.TabIndex = 1;
            this.BTN_Browse.Text = "Parcourir ...";
            this.BTN_Browse.UseVisualStyleBackColor = true;
            this.BTN_Browse.Click += new System.EventHandler(this.BTN_Browse_Clickk);
            // 
            // TB_Path
            // 
            this.TB_Path.Location = new System.Drawing.Point(2, 13);
            this.TB_Path.Name = "TB_Path";
            this.TB_Path.Size = new System.Drawing.Size(705, 20);
            this.TB_Path.TabIndex = 2;
            this.TB_Path.TextChanged += new System.EventHandler(this.TB_Path_TextChanged);
            // 
            // BTN_Open
            // 
            this.BTN_Open.Location = new System.Drawing.Point(2, 40);
            this.BTN_Open.Name = "BTN_Open";
            this.BTN_Open.Size = new System.Drawing.Size(797, 23);
            this.BTN_Open.TabIndex = 3;
            this.BTN_Open.Text = "Ouvrir";
            this.BTN_Open.UseVisualStyleBackColor = true;
            this.BTN_Open.Click += new System.EventHandler(this.BTN_Open_Click);
            // 
            // GB_Tools
            // 
            this.GB_Tools.Controls.Add(this.groupBox1);
            this.GB_Tools.Location = new System.Drawing.Point(2, 70);
            this.GB_Tools.Name = "GB_Tools";
            this.GB_Tools.Size = new System.Drawing.Size(797, 368);
            this.GB_Tools.TabIndex = 4;
            this.GB_Tools.TabStop = false;
            this.GB_Tools.Text = "Outils";
            // 
            // BTN_Fill
            // 
            this.BTN_Fill.Location = new System.Drawing.Point(6, 77);
            this.BTN_Fill.Name = "BTN_Fill";
            this.BTN_Fill.Size = new System.Drawing.Size(146, 23);
            this.BTN_Fill.TabIndex = 0;
            this.BTN_Fill.Text = "Remplir";
            this.BTN_Fill.UseVisualStyleBackColor = true;
            this.BTN_Fill.Click += new System.EventHandler(this.BTN_Fill_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BTN_Fill);
            this.groupBox1.Controls.Add(this.TB_FillTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_FillFrom);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remplir";
            // 
            // TB_FillFrom
            // 
            this.TB_FillFrom.Location = new System.Drawing.Point(49, 21);
            this.TB_FillFrom.Name = "TB_FillFrom";
            this.TB_FillFrom.Size = new System.Drawing.Size(100, 20);
            this.TB_FillFrom.TabIndex = 0;
            this.TB_FillFrom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "De :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A :";
            // 
            // TB_FillTo
            // 
            this.TB_FillTo.Location = new System.Drawing.Point(49, 51);
            this.TB_FillTo.Name = "TB_FillTo";
            this.TB_FillTo.Size = new System.Drawing.Size(100, 20);
            this.TB_FillTo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GB_Tools);
            this.Controls.Add(this.BTN_Open);
            this.Controls.Add(this.TB_Path);
            this.Controls.Add(this.BTN_Browse);
            this.Name = "Form1";
            this.Text = "Auto_excel";
            this.GB_Tools.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Browse;
        private System.Windows.Forms.TextBox TB_Path;
        private System.Windows.Forms.Button BTN_Open;
        private System.Windows.Forms.GroupBox GB_Tools;
        private System.Windows.Forms.Button BTN_Fill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_FillFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_FillTo;
        private System.Windows.Forms.Label label1;
    }
}

