namespace CarLocation
{
    partial class MainMenuForm
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
            this.reserveVehiculeButton = new System.Windows.Forms.Button();
            this.lendButton = new System.Windows.Forms.Button();
            this.clientManagementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reserveVehiculeButton
            // 
            this.reserveVehiculeButton.Location = new System.Drawing.Point(12, 5);
            this.reserveVehiculeButton.Name = "reserveVehiculeButton";
            this.reserveVehiculeButton.Size = new System.Drawing.Size(260, 23);
            this.reserveVehiculeButton.TabIndex = 1;
            this.reserveVehiculeButton.Text = "Réserver véhicule";
            this.reserveVehiculeButton.UseVisualStyleBackColor = true;
            this.reserveVehiculeButton.Click += new System.EventHandler(this.reserveVehiculeButton_Click);
            // 
            // lendButton
            // 
            this.lendButton.Location = new System.Drawing.Point(12, 34);
            this.lendButton.Name = "lendButton";
            this.lendButton.Size = new System.Drawing.Size(260, 23);
            this.lendButton.TabIndex = 2;
            this.lendButton.Text = "Prêter véhicule";
            this.lendButton.UseVisualStyleBackColor = true;
            this.lendButton.Click += new System.EventHandler(this.LendButton_Click);
            // 
            // clientManagementButton
            // 
            this.clientManagementButton.Location = new System.Drawing.Point(12, 63);
            this.clientManagementButton.Name = "clientManagementButton";
            this.clientManagementButton.Size = new System.Drawing.Size(260, 23);
            this.clientManagementButton.TabIndex = 3;
            this.clientManagementButton.Text = "Gestion clients";
            this.clientManagementButton.UseVisualStyleBackColor = true;
            this.clientManagementButton.Click += new System.EventHandler(this.ClientManagementButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 94);
            this.Controls.Add(this.clientManagementButton);
            this.Controls.Add(this.lendButton);
            this.Controls.Add(this.reserveVehiculeButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 133);
            this.MinimumSize = new System.Drawing.Size(300, 133);
            this.Name = "MainMenuForm";
            this.Text = "Système de location";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reserveVehiculeButton;
        private System.Windows.Forms.Button lendButton;
        private System.Windows.Forms.Button clientManagementButton;
    }
}

