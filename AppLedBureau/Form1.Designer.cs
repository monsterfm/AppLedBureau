namespace AppLedBureau
{
    partial class LED
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
            this.components = new System.ComponentModel.Container();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.Red = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.InstantApply = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(12, 12);
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(104, 45);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(13, 64);
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(104, 45);
            this.trackBarGreen.TabIndex = 1;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(13, 116);
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(104, 45);
            this.trackBarBlue.TabIndex = 2;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(123, 13);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(27, 13);
            this.Red.TabIndex = 3;
            this.Red.Text = "Red";
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(123, 64);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(36, 13);
            this.Green.TabIndex = 4;
            this.Green.Text = "Green";
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(126, 116);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(28, 13);
            this.Blue.TabIndex = 5;
            this.Blue.Text = "Blue";
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(13, 226);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 6;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // InstantApply
            // 
            this.InstantApply.AutoSize = true;
            this.InstantApply.Location = new System.Drawing.Point(12, 203);
            this.InstantApply.Name = "InstantApply";
            this.InstantApply.Size = new System.Drawing.Size(87, 17);
            this.InstantApply.TabIndex = 7;
            this.InstantApply.Text = "Instant Apply";
            this.InstantApply.UseVisualStyleBackColor = true;
            this.InstantApply.CheckedChanged += new System.EventHandler(this.InstantApply_CheckedChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(172, 13);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.ReadOnly = true;
            this.textBoxRed.Size = new System.Drawing.Size(100, 20);
            this.textBoxRed.TabIndex = 8;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(172, 64);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.ReadOnly = true;
            this.textBoxGreen.Size = new System.Drawing.Size(100, 20);
            this.textBoxGreen.TabIndex = 9;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(172, 116);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.ReadOnly = true;
            this.textBoxBlue.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlue.TabIndex = 10;
            // 
            // LED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.InstantApply);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Name = "LED";
            this.Text = "LED";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.CheckBox InstantApply;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxBlue;

    }
}

