namespace Учебные_классы {
    partial class FormTransferEquip {
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbxNameWorkstation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(103, 138);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(84, 23);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Переместить";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Выберите класс, в который следует переместить оборудование:";
            // 
            // cbxClass
            // 
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(12, 25);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(366, 21);
            this.cbxClass.TabIndex = 2;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(193, 138);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // cbxNameWorkstation
            // 
            this.cbxNameWorkstation.FormattingEnabled = true;
            this.cbxNameWorkstation.Location = new System.Drawing.Point(12, 88);
            this.cbxNameWorkstation.Name = "cbxNameWorkstation";
            this.cbxNameWorkstation.Size = new System.Drawing.Size(366, 21);
            this.cbxNameWorkstation.TabIndex = 15;
            this.cbxNameWorkstation.SelectedIndexChanged += new System.EventHandler(this.cbxNameWorkstation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Выберите имя рабочей станции, где будет установлено оборудование:";
            // 
            // FormTransferEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(390, 176);
            this.Controls.Add(this.cbxNameWorkstation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbxClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTransfer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTransferEquip";
            this.ShowIcon = false;
            this.Text = "Переместить оборудование";
            this.Load += new System.EventHandler(this.Form1_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbxNameWorkstation;
        private System.Windows.Forms.Label label1;
    }
}