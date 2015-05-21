namespace KundenManagementGUI
{
    partial class FormKunde
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowCustomers = new System.Windows.Forms.Button();
            this.comboBoxKunden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKundenId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonShowCustomers
            // 
            this.buttonShowCustomers.Location = new System.Drawing.Point(42, 43);
            this.buttonShowCustomers.Name = "buttonShowCustomers";
            this.buttonShowCustomers.Size = new System.Drawing.Size(181, 32);
            this.buttonShowCustomers.TabIndex = 1;
            this.buttonShowCustomers.Text = "Kunden anzeigen";
            this.buttonShowCustomers.UseVisualStyleBackColor = true;
            this.buttonShowCustomers.Click += new System.EventHandler(this.buttonShowCustomers_Click);
            // 
            // comboBoxKunden
            // 
            this.comboBoxKunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKunden.FormattingEnabled = true;
            this.comboBoxKunden.Location = new System.Drawing.Point(40, 103);
            this.comboBoxKunden.Name = "comboBoxKunden";
            this.comboBoxKunden.Size = new System.Drawing.Size(182, 24);
            this.comboBoxKunden.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KundenId";
            // 
            // textBoxKundenId
            // 
            this.textBoxKundenId.Location = new System.Drawing.Point(111, 147);
            this.textBoxKundenId.Name = "textBoxKundenId";
            this.textBoxKundenId.Size = new System.Drawing.Size(110, 20);
            this.textBoxKundenId.TabIndex = 4;
            // 
            // FormKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 439);
            this.Controls.Add(this.textBoxKundenId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKunden);
            this.Controls.Add(this.buttonShowCustomers);
            this.Name = "FormKunde";
            this.Text = "Kundenverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowCustomers;
        private System.Windows.Forms.ComboBox comboBoxKunden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKundenId;
    }
}

