namespace FORML3IAGE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbHomme = new System.Windows.Forms.RadioButton();
            this.rbFemme = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbJava = new System.Windows.Forms.CheckBox();
            this.ckbCsharp = new System.Windows.Forms.CheckBox();
            this.ckbPhp = new System.Windows.Forms.CheckBox();
            this.ckbCplusplus = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRENOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOM";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(155, 27);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(167, 41);
            this.txtPrenom.TabIndex = 2;
            this.txtPrenom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(155, 81);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(167, 43);
            this.txtNom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "TEL";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(155, 158);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(171, 44);
            this.txtTel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "SEXE";
            // 
            // rbHomme
            // 
            this.rbHomme.AutoSize = true;
            this.rbHomme.Location = new System.Drawing.Point(135, 233);
            this.rbHomme.Name = "rbHomme";
            this.rbHomme.Size = new System.Drawing.Size(90, 24);
            this.rbHomme.TabIndex = 8;
            this.rbHomme.TabStop = true;
            this.rbHomme.Text = "Homme";
            this.rbHomme.UseVisualStyleBackColor = true;
            // 
            // rbFemme
            // 
            this.rbFemme.AutoSize = true;
            this.rbFemme.Location = new System.Drawing.Point(271, 233);
            this.rbFemme.Name = "rbFemme";
            this.rbFemme.Size = new System.Drawing.Size(88, 24);
            this.rbFemme.TabIndex = 9;
            this.rbFemme.TabStop = true;
            this.rbFemme.Text = "Femme";
            this.rbFemme.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "COMPETENCES";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ckbJava
            // 
            this.ckbJava.AutoSize = true;
            this.ckbJava.Location = new System.Drawing.Point(220, 296);
            this.ckbJava.Name = "ckbJava";
            this.ckbJava.Size = new System.Drawing.Size(68, 24);
            this.ckbJava.TabIndex = 11;
            this.ckbJava.Text = "Java";
            this.ckbJava.UseVisualStyleBackColor = true;
            // 
            // ckbCsharp
            // 
            this.ckbCsharp.AutoSize = true;
            this.ckbCsharp.Location = new System.Drawing.Point(317, 297);
            this.ckbCsharp.Name = "ckbCsharp";
            this.ckbCsharp.Size = new System.Drawing.Size(55, 24);
            this.ckbCsharp.TabIndex = 12;
            this.ckbCsharp.Text = "C#";
            this.ckbCsharp.UseVisualStyleBackColor = true;
            this.ckbCsharp.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbPhp
            // 
            this.ckbPhp.AutoSize = true;
            this.ckbPhp.Location = new System.Drawing.Point(220, 339);
            this.ckbPhp.Name = "ckbPhp";
            this.ckbPhp.Size = new System.Drawing.Size(62, 24);
            this.ckbPhp.TabIndex = 13;
            this.ckbPhp.Text = "php";
            this.ckbPhp.UseVisualStyleBackColor = true;
            this.ckbPhp.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // ckbCplusplus
            // 
            this.ckbCplusplus.AutoSize = true;
            this.ckbCplusplus.Location = new System.Drawing.Point(317, 339);
            this.ckbCplusplus.Name = "ckbCplusplus";
            this.ckbCplusplus.Size = new System.Drawing.Size(64, 24);
            this.ckbCplusplus.TabIndex = 14;
            this.ckbCplusplus.Text = "C++";
            this.ckbCplusplus.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(301, 405);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 37);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(155, 405);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 37);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.Location = new System.Drawing.Point(598, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 37);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpen.Location = new System.Drawing.Point(748, 405);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(133, 37);
            this.btnOpen.TabIndex = 19;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(897, 387);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "CLASSE";
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "L1 IAGE",
            "L2 IAGE",
            "L3 IAGE",
            "M1 IAGE",
            "M2 IAGE"});
            this.cmbClasse.Location = new System.Drawing.Point(155, 371);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(137, 28);
            this.cmbClasse.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Location = new System.Drawing.Point(16, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 37);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(452, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 37);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 484);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ckbCplusplus);
            this.Controls.Add(this.ckbPhp);
            this.Controls.Add(this.ckbCsharp);
            this.Controls.Add(this.ckbJava);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbFemme);
            this.Controls.Add(this.rbHomme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "L3 IAGE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbHomme;
        private System.Windows.Forms.RadioButton rbFemme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbJava;
        private System.Windows.Forms.CheckBox ckbCsharp;
        private System.Windows.Forms.CheckBox ckbPhp;
        private System.Windows.Forms.CheckBox ckbCplusplus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}

