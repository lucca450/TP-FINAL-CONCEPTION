namespace CarLocation
{
    partial class VehiculeLoanForm
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
            this.checkCodeButton = new System.Windows.Forms.Button();
            this.clientCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkNumeroReservation = new System.Windows.Forms.Button();
            this.numeroReservation = new System.Windows.Forms.TextBox();
            this.lbl_numero_reservation = new System.Windows.Forms.Label();
            this.pn_section3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.beginning = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editionComboBox = new System.Windows.Forms.ComboBox();
            this.pn_section2 = new System.Windows.Forms.Panel();
            this.pn_section3.SuspendLayout();
            this.pn_section2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkCodeButton
            // 
            this.checkCodeButton.Location = new System.Drawing.Point(277, 3);
            this.checkCodeButton.Name = "checkCodeButton";
            this.checkCodeButton.Size = new System.Drawing.Size(100, 24);
            this.checkCodeButton.TabIndex = 46;
            this.checkCodeButton.Text = "Vérifier code";
            this.checkCodeButton.UseVisualStyleBackColor = true;
            this.checkCodeButton.Click += new System.EventHandler(this.checkCodeButton_Click);
            // 
            // clientCode
            // 
            this.clientCode.Location = new System.Drawing.Point(167, 6);
            this.clientCode.MaxLength = 10;
            this.clientCode.Name = "clientCode";
            this.clientCode.Size = new System.Drawing.Size(104, 20);
            this.clientCode.TabIndex = 45;
            this.clientCode.TextChanged += new System.EventHandler(this.clientCode_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Code du client : ";
            // 
            // checkNumeroReservation
            // 
            this.checkNumeroReservation.Location = new System.Drawing.Point(265, 3);
            this.checkNumeroReservation.Name = "checkNumeroReservation";
            this.checkNumeroReservation.Size = new System.Drawing.Size(100, 24);
            this.checkNumeroReservation.TabIndex = 61;
            this.checkNumeroReservation.Text = "Vérifier numéro";
            this.checkNumeroReservation.UseVisualStyleBackColor = true;
            this.checkNumeroReservation.Click += new System.EventHandler(this.checkNumeroReservation_Click);
            // 
            // numeroReservation
            // 
            this.numeroReservation.Enabled = false;
            this.numeroReservation.Location = new System.Drawing.Point(155, 3);
            this.numeroReservation.MaxLength = 8;
            this.numeroReservation.Name = "numeroReservation";
            this.numeroReservation.Size = new System.Drawing.Size(104, 20);
            this.numeroReservation.TabIndex = 60;
            this.numeroReservation.TextChanged += new System.EventHandler(this.numeroReservation_TextChanged);
            this.numeroReservation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroReservation_KeyPress);
            // 
            // lbl_numero_reservation
            // 
            this.lbl_numero_reservation.AutoSize = true;
            this.lbl_numero_reservation.Location = new System.Drawing.Point(0, 3);
            this.lbl_numero_reservation.Name = "lbl_numero_reservation";
            this.lbl_numero_reservation.Size = new System.Drawing.Size(120, 13);
            this.lbl_numero_reservation.TabIndex = 59;
            this.lbl_numero_reservation.Text = "Numéro de réservation: ";
            // 
            // pn_section3
            // 
            this.pn_section3.Controls.Add(this.label8);
            this.pn_section3.Controls.Add(this.label1);
            this.pn_section3.Controls.Add(this.label2);
            this.pn_section3.Controls.Add(this.label3);
            this.pn_section3.Controls.Add(this.beginning);
            this.pn_section3.Controls.Add(this.SaveButton);
            this.pn_section3.Controls.Add(this.cancelButton);
            this.pn_section3.Controls.Add(this.yearComboBox);
            this.pn_section3.Controls.Add(this.typeComboBox);
            this.pn_section3.Controls.Add(this.end);
            this.pn_section3.Controls.Add(this.brandComboBox);
            this.pn_section3.Controls.Add(this.label4);
            this.pn_section3.Controls.Add(this.modelComboBox);
            this.pn_section3.Controls.Add(this.label7);
            this.pn_section3.Controls.Add(this.label6);
            this.pn_section3.Controls.Add(this.editionComboBox);
            this.pn_section3.Location = new System.Drawing.Point(12, 65);
            this.pn_section3.Name = "pn_section3";
            this.pn_section3.Size = new System.Drawing.Size(360, 255);
            this.pn_section3.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Début :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Type de vehicule :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Marque de véhicule : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Modele de véhicule : ";
            // 
            // beginning
            // 
            this.beginning.Enabled = false;
            this.beginning.Location = new System.Drawing.Point(155, 3);
            this.beginning.Name = "beginning";
            this.beginning.Size = new System.Drawing.Size(205, 20);
            this.beginning.TabIndex = 58;
            this.beginning.Value = new System.DateTime(2020, 3, 6, 11, 5, 52, 0);
            this.beginning.ValueChanged += new System.EventHandler(this.beginning_ValueChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(260, 214);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 35);
            this.SaveButton.TabIndex = 43;
            this.SaveButton.Text = "Enregistrer";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(0, 214);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 35);
            this.cancelButton.TabIndex = 47;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.Enabled = false;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(155, 164);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(72, 21);
            this.yearComboBox.TabIndex = 56;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Enabled = false;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(155, 59);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(205, 21);
            this.typeComboBox.TabIndex = 48;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // end
            // 
            this.end.Enabled = false;
            this.end.Location = new System.Drawing.Point(155, 34);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(205, 20);
            this.end.TabIndex = 55;
            this.end.Value = new System.DateTime(2020, 3, 6, 11, 5, 52, 0);
            this.end.ValueChanged += new System.EventHandler(this.end_ValueChanged);
            // 
            // brandComboBox
            // 
            this.brandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandComboBox.Enabled = false;
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(155, 86);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(205, 21);
            this.brandComboBox.TabIndex = 49;
            this.brandComboBox.SelectedIndexChanged += new System.EventHandler(this.brandComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Fin :";
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.Enabled = false;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(155, 113);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(205, 21);
            this.modelComboBox.TabIndex = 50;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Année : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Garniture de véhicule : ";
            // 
            // editionComboBox
            // 
            this.editionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editionComboBox.Enabled = false;
            this.editionComboBox.FormattingEnabled = true;
            this.editionComboBox.Location = new System.Drawing.Point(155, 140);
            this.editionComboBox.Name = "editionComboBox";
            this.editionComboBox.Size = new System.Drawing.Size(205, 21);
            this.editionComboBox.TabIndex = 52;
            this.editionComboBox.SelectedIndexChanged += new System.EventHandler(this.editionComboBox_SelectedIndexChanged);
            // 
            // pn_section2
            // 
            this.pn_section2.Controls.Add(this.lbl_numero_reservation);
            this.pn_section2.Controls.Add(this.numeroReservation);
            this.pn_section2.Controls.Add(this.checkNumeroReservation);
            this.pn_section2.Location = new System.Drawing.Point(12, 32);
            this.pn_section2.Name = "pn_section2";
            this.pn_section2.Size = new System.Drawing.Size(375, 27);
            this.pn_section2.TabIndex = 59;
            // 
            // VehiculeLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 327);
            this.Controls.Add(this.pn_section2);
            this.Controls.Add(this.pn_section3);
            this.Controls.Add(this.checkCodeButton);
            this.Controls.Add(this.clientCode);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(400, 331);
            this.Name = "VehiculeLoanForm";
            this.Text = "Prêt d\'un véhicule";
            this.pn_section3.ResumeLayout(false);
            this.pn_section3.PerformLayout();
            this.pn_section2.ResumeLayout(false);
            this.pn_section2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkCodeButton;
        private System.Windows.Forms.TextBox clientCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button checkNumeroReservation;
        private System.Windows.Forms.TextBox numeroReservation;
        private System.Windows.Forms.Label lbl_numero_reservation;
        private System.Windows.Forms.Panel pn_section3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker beginning;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox editionComboBox;
        private System.Windows.Forms.Panel pn_section2;
    }
}