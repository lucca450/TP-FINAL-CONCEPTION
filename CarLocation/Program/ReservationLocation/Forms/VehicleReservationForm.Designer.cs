namespace CarLocation
{
    partial class VehiculeReservationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.clientCode = new System.Windows.Forms.TextBox();
            this.checkCodeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.editionComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.beginning = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marque de véhicule : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modele de véhicule : ";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(272, 248);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 35);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Enregistrer";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Code du client : ";
            // 
            // clientCode
            // 
            this.clientCode.Location = new System.Drawing.Point(167, 12);
            this.clientCode.MaxLength = 10;
            this.clientCode.Name = "clientCode";
            this.clientCode.Size = new System.Drawing.Size(104, 20);
            this.clientCode.TabIndex = 12;
            this.clientCode.TextChanged += new System.EventHandler(this.ClientCode_TextChanged);
            // 
            // checkCodeButton
            // 
            this.checkCodeButton.Location = new System.Drawing.Point(277, 9);
            this.checkCodeButton.Name = "checkCodeButton";
            this.checkCodeButton.Size = new System.Drawing.Size(100, 24);
            this.checkCodeButton.TabIndex = 13;
            this.checkCodeButton.Text = "Vérifier code";
            this.checkCodeButton.UseVisualStyleBackColor = true;
            this.checkCodeButton.Click += new System.EventHandler(this.checkCodeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 248);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 35);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // brandComboBox
            // 
            this.brandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandComboBox.Enabled = false;
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(167, 120);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(205, 21);
            this.brandComboBox.TabIndex = 16;
            this.brandComboBox.SelectedIndexChanged += new System.EventHandler(this.brandComboBox_SelectedIndexChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.Enabled = false;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(167, 147);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(205, 21);
            this.modelComboBox.TabIndex = 17;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type de vehicule :";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Enabled = false;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(167, 93);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(205, 21);
            this.typeComboBox.TabIndex = 15;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // editionComboBox
            // 
            this.editionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editionComboBox.Enabled = false;
            this.editionComboBox.FormattingEnabled = true;
            this.editionComboBox.Location = new System.Drawing.Point(167, 174);
            this.editionComboBox.Name = "editionComboBox";
            this.editionComboBox.Size = new System.Drawing.Size(205, 21);
            this.editionComboBox.TabIndex = 32;
            this.editionComboBox.SelectedIndexChanged += new System.EventHandler(this.editionComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Garniture de véhicule : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Année : ";
            // 
            // end
            // 
            this.end.Enabled = false;
            this.end.Location = new System.Drawing.Point(167, 68);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(205, 20);
            this.end.TabIndex = 36;
            this.end.Value = new System.DateTime(2020, 3, 6, 11, 5, 52, 0);
            this.end.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fin :";
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.Enabled = false;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(167, 198);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(72, 21);
            this.yearComboBox.TabIndex = 37;
            // 
            // beginning
            // 
            this.beginning.Enabled = false;
            this.beginning.Location = new System.Drawing.Point(167, 39);
            this.beginning.Name = "beginning";
            this.beginning.Size = new System.Drawing.Size(205, 20);
            this.beginning.TabIndex = 39;
            this.beginning.Value = new System.DateTime(2020, 3, 6, 11, 5, 52, 0);
            this.beginning.ValueChanged += new System.EventHandler(this.beginning_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Début :";
            // 
            // VehiculeReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 292);
            this.Controls.Add(this.beginning);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.end);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editionComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.checkCodeButton);
            this.Controls.Add(this.clientCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 331);
            this.MinimumSize = new System.Drawing.Size(400, 331);
            this.Name = "VehiculeReservationForm";
            this.Text = "Réservation d\'un véhicule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientCode;
        private System.Windows.Forms.Button checkCodeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox editionComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.DateTimePicker beginning;
        private System.Windows.Forms.Label label8;
    }
}