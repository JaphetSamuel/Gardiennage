namespace Gardiennage
{
    partial class FormAjout
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbDomicile = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.NumericUpDown();
            this.chkListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUpDuree = new System.Windows.Forms.NumericUpDown();
            this.ckbDuree = new System.Windows.Forms.CheckBox();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.dtpdebut = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.cmboMatrimonial = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAge)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDuree)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.58009F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.41991F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbNom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPrenom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbDomicile, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbAge, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkListBox1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmboMatrimonial, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.35338F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.64662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Âge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Situation Matrimoniale";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Domicile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Compétence";
            // 
            // tbNom
            // 
            this.tbNom.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbNom.Location = new System.Drawing.Point(172, 3);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(271, 22);
            this.tbNom.TabIndex = 6;
            // 
            // tbPrenom
            // 
            this.tbPrenom.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbPrenom.Location = new System.Drawing.Point(172, 40);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(271, 22);
            this.tbPrenom.TabIndex = 7;
            // 
            // tbDomicile
            // 
            this.tbDomicile.Location = new System.Drawing.Point(172, 180);
            this.tbDomicile.Name = "tbDomicile";
            this.tbDomicile.Size = new System.Drawing.Size(271, 22);
            this.tbDomicile.TabIndex = 8;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(172, 93);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(120, 22);
            this.tbAge.TabIndex = 9;
            // 
            // chkListBox1
            // 
            this.chkListBox1.FormattingEnabled = true;
            this.chkListBox1.Items.AddRange(new object[] {
            "assidu",
            "serviable",
            "courageux",
            "experimenté",
            "devoué",
            "intelligence d\'action"});
            this.chkListBox1.Location = new System.Drawing.Point(172, 223);
            this.chkListBox1.Name = "chkListBox1";
            this.chkListBox1.Size = new System.Drawing.Size(287, 123);
            this.chkListBox1.TabIndex = 11;
            this.chkListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUpDuree);
            this.groupBox1.Controls.Add(this.ckbDuree);
            this.groupBox1.Controls.Add(this.dtpfin);
            this.groupBox1.Controls.Add(this.dtpdebut);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information liées au contrat";
            // 
            // numUpDuree
            // 
            this.numUpDuree.Location = new System.Drawing.Point(175, 32);
            this.numUpDuree.Name = "numUpDuree";
            this.numUpDuree.Size = new System.Drawing.Size(120, 22);
            this.numUpDuree.TabIndex = 6;
            // 
            // ckbDuree
            // 
            this.ckbDuree.AutoSize = true;
            this.ckbDuree.Location = new System.Drawing.Point(15, 32);
            this.ckbDuree.Name = "ckbDuree";
            this.ckbDuree.Size = new System.Drawing.Size(137, 21);
            this.ckbDuree.TabIndex = 5;
            this.ckbDuree.Text = "Durée du contrat";
            this.ckbDuree.UseVisualStyleBackColor = true;
            this.ckbDuree.CheckedChanged += new System.EventHandler(this.ckbDuree_CheckedChanged);
            // 
            // dtpfin
            // 
            this.dtpfin.Location = new System.Drawing.Point(146, 93);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(240, 22);
            this.dtpfin.TabIndex = 4;
            // 
            // dtpdebut
            // 
            this.dtpdebut.Location = new System.Drawing.Point(146, 63);
            this.dtpdebut.Name = "dtpdebut";
            this.dtpdebut.Size = new System.Drawing.Size(240, 22);
            this.dtpdebut.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fin du contrat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Debut du contrat";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValider.Location = new System.Drawing.Point(172, 548);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(157, 33);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cmboMatrimonial
            // 
            this.cmboMatrimonial.FormattingEnabled = true;
            this.cmboMatrimonial.Items.AddRange(new object[] {
            "Marié",
            "Célibataire",
            "Divorcé"});
            this.cmboMatrimonial.Location = new System.Drawing.Point(172, 139);
            this.cmboMatrimonial.Name = "cmboMatrimonial";
            this.cmboMatrimonial.Size = new System.Drawing.Size(271, 24);
            this.cmboMatrimonial.TabIndex = 12;
            // 
            // FormAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 593);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAjout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un nouveau gardien";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDuree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbDomicile;
        private System.Windows.Forms.NumericUpDown tbAge;
        private System.Windows.Forms.CheckedListBox chkListBox1;
        private System.Windows.Forms.NumericUpDown numUpDuree;
        private System.Windows.Forms.CheckBox ckbDuree;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.DateTimePicker dtpdebut;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cmboMatrimonial;
    }
}