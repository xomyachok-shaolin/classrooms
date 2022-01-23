namespace Учебные_классы {
    partial class Form1_Add {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxDivisions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxAddress1 = new System.Windows.Forms.ComboBox();
            this.cbxAddress2 = new System.Windows.Forms.ComboBox();
            this.cbxAddress3 = new System.Windows.Forms.ComboBox();
            this.cbxAddress4 = new System.Windows.Forms.ComboBox();
            this.numUDQuantitySeats = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxNote = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantitySeats)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxDivisions
            // 
            this.cbxDivisions.FormattingEnabled = true;
            this.cbxDivisions.Location = new System.Drawing.Point(13, 29);
            this.cbxDivisions.Name = "cbxDivisions";
            this.cbxDivisions.Size = new System.Drawing.Size(317, 21);
            this.cbxDivisions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите ответственную кафедру:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 2);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 2);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Укажите адрес класса:";
            // 
            // cbxAddress1
            // 
            this.cbxAddress1.FormattingEnabled = true;
            this.cbxAddress1.Location = new System.Drawing.Point(12, 86);
            this.cbxAddress1.Name = "cbxAddress1";
            this.cbxAddress1.Size = new System.Drawing.Size(76, 21);
            this.cbxAddress1.TabIndex = 2;
            this.cbxAddress1.SelectedIndexChanged += new System.EventHandler(this.cbxAddress1_SelectedIndexChanged);
            // 
            // cbxAddress2
            // 
            this.cbxAddress2.FormattingEnabled = true;
            this.cbxAddress2.Location = new System.Drawing.Point(94, 86);
            this.cbxAddress2.Name = "cbxAddress2";
            this.cbxAddress2.Size = new System.Drawing.Size(123, 21);
            this.cbxAddress2.TabIndex = 3;
            this.cbxAddress2.SelectedIndexChanged += new System.EventHandler(this.cbxAddress2_SelectedIndexChanged);
            // 
            // cbxAddress3
            // 
            this.cbxAddress3.FormattingEnabled = true;
            this.cbxAddress3.Location = new System.Drawing.Point(223, 86);
            this.cbxAddress3.Name = "cbxAddress3";
            this.cbxAddress3.Size = new System.Drawing.Size(43, 21);
            this.cbxAddress3.TabIndex = 4;
            this.cbxAddress3.SelectedIndexChanged += new System.EventHandler(this.cbxAddress3_SelectedIndexChanged);
            // 
            // cbxAddress4
            // 
            this.cbxAddress4.FormattingEnabled = true;
            this.cbxAddress4.Location = new System.Drawing.Point(272, 86);
            this.cbxAddress4.Name = "cbxAddress4";
            this.cbxAddress4.Size = new System.Drawing.Size(57, 21);
            this.cbxAddress4.TabIndex = 5;
            // 
            // numUDQuantitySeats
            // 
            this.numUDQuantitySeats.Location = new System.Drawing.Point(289, 134);
            this.numUDQuantitySeats.Name = "numUDQuantitySeats";
            this.numUDQuantitySeats.Size = new System.Drawing.Size(40, 20);
            this.numUDQuantitySeats.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Укажите максимальное количество мест в классе:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Оставьте примечание (не обязательно):";
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.Location = new System.Drawing.Point(15, 183);
            this.txtBoxNote.Multiline = true;
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.Size = new System.Drawing.Size(314, 120);
            this.txtBoxNote.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(175, 309);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Form1_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(342, 344);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numUDQuantitySeats);
            this.Controls.Add(this.cbxAddress4);
            this.Controls.Add(this.cbxAddress3);
            this.Controls.Add(this.cbxAddress2);
            this.Controls.Add(this.cbxAddress1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDivisions);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1_Add";
            this.ShowIcon = false;
            this.Text = "Добавить учебный класс";
            this.Load += new System.EventHandler(this.Form1_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantitySeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxDivisions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxAddress1;
        private System.Windows.Forms.ComboBox cbxAddress2;
        private System.Windows.Forms.ComboBox cbxAddress3;
        private System.Windows.Forms.ComboBox cbxAddress4;
        private System.Windows.Forms.NumericUpDown numUDQuantitySeats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxNote;
        private System.Windows.Forms.Button btnBack;
    }
}