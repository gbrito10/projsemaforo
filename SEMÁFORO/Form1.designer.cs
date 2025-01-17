namespace projLeds
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDado = new System.Windows.Forms.TextBox();
            this.txtDado2 = new System.Windows.Forms.TextBox();
            this.txtDado16 = new System.Windows.Forms.TextBox();
            this.grpLeds = new System.Windows.Forms.GroupBox();
            
            // Arrays de controles para LEDs
            this.chkLeds = new System.Windows.Forms.CheckBox[8];
            this.picLeds = new System.Windows.Forms.PictureBox[8];
            this.btnLedOn = new System.Windows.Forms.Button[8];
            this.btnLedOff = new System.Windows.Forms.Button[8];
            
            // Configuração inicial
            for (int i = 0; i < 8; i++)
            {
                this.chkLeds[i] = new System.Windows.Forms.CheckBox();
                this.picLeds[i] = new System.Windows.Forms.PictureBox();
                this.btnLedOn[i] = new System.Windows.Forms.Button();
                this.btnLedOff[i] = new System.Windows.Forms.Button();
            }

            // 
            // txtDado
            // 
            this.txtDado.Location = new System.Drawing.Point(20, 20);
            this.txtDado.Name = "txtDado";
            this.txtDado.Size = new System.Drawing.Size(100, 20);
            this.txtDado.TabIndex = 0;
            this.txtDado.ReadOnly = true;

            // 
            // txtDado2
            // 
            this.txtDado2.Location = new System.Drawing.Point(130, 20);
            this.txtDado2.Name = "txtDado2";
            this.txtDado2.Size = new System.Drawing.Size(100, 20);
            this.txtDado2.TabIndex = 1;
            this.txtDado2.ReadOnly = true;

            // 
            // txtDado16
            // 
            this.txtDado16.Location = new System.Drawing.Point(240, 20);
            this.txtDado16.Name = "txtDado16";
            this.txtDado16.Size = new System.Drawing.Size(100, 20);
            this.txtDado16.TabIndex = 2;
            this.txtDado16.ReadOnly = true;

            // 
            // grpLeds
            // 
            this.grpLeds.Location = new System.Drawing.Point(20, 60);
            this.grpLeds.Name = "grpLeds";
            this.grpLeds.Size = new System.Drawing.Size(600, 300);
            this.grpLeds.TabIndex = 3;
            this.grpLeds.TabStop = false;
            this.grpLeds.Text = "Controle de LEDs";

            // Configuração de LEDs
            for (int i = 0; i < 8; i++)
            {
                // 
                // chkLeds[i]
                // 
                this.chkLeds[i].Location = new System.Drawing.Point(20 + i * 70, 30);
                this.chkLeds[i].Name = $"chkLed{i + 1}";
                this.chkLeds[i].Size = new System.Drawing.Size(70, 20);
                this.chkLeds[i].Text = $"LED {i + 1}";
                this.chkLeds[i].UseVisualStyleBackColor = true;

                // 
                // picLeds[i]
                // 
                this.picLeds[i].Location = new System.Drawing.Point(20 + i * 70, 60);
                this.picLeds[i].Name = $"picLed{i + 1}";
                this.picLeds[i].Size = new System.Drawing.Size(50, 50);
                this.picLeds[i].TabStop = false;

                // 
                // btnLedOn[i]
                // 
                this.btnLedOn[i].Location = new System.Drawing.Point(20 + i * 70, 120);
                this.btnLedOn[i].Name = $"btnLed{i + 1}ON";
                this.btnLedOn[i].Size = new System.Drawing.Size(50, 25);
                this.btnLedOn[i].Text = "ON";
                this.btnLedOn[i].UseVisualStyleBackColor = true;
                this.btnLedOn[i].Click += new System.EventHandler(this.btnLed_Click);

                // 
                // btnLedOff[i]
                // 
                this.btnLedOff[i].Location = new System.Drawing.Point(20 + i * 70, 150);
                this.btnLedOff[i].Name = $"btnLed{i + 1}OFF";
                this.btnLedOff[i].Size = new System.Drawing.Size(50, 25);
                this.btnLedOff[i].Text = "OFF";
                this.btnLedOff[i].UseVisualStyleBackColor = true;
                this.btnLedOff[i].Click += new System.EventHandler(this.btnLed_Click);

                // Adiciona controles ao GroupBox
                this.grpLeds.Controls.Add(this.chkLeds[i]);
                this.grpLeds.Controls.Add(this.picLeds[i]);
                this.grpLeds.Controls.Add(this.btnLedOn[i]);
                this.grpLeds.Controls.Add(this.btnLedOff[i]);
            }

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDado);
            this.Controls.Add(this.txtDado2);
            this.Controls.Add(this.txtDado16);
            this.Controls.Add(this.grpLeds);
            this.Name = "Form1";
            this.Text = "Controle de LEDs";
            this.grpLeds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDado;
        private System.Windows.Forms.TextBox txtDado2;
        private System.Windows.Forms.TextBox txtDado16;
        private System.Windows.Forms.GroupBox grpLeds;
        private System.Windows.Forms.CheckBox[] chkLeds;
        private System.Windows.Forms.PictureBox[] picLeds;
        private System.Windows.Forms.Button[] btnLedOn;
        private System.Windows.Forms.Button[] btnLedOff;
    }
}
