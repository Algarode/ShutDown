namespace SluitAf
{
    partial class SluitAf
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
            this.lbMinuten = new System.Windows.Forms.Label();
            this.nudMinuten = new System.Windows.Forms.NumericUpDown();
            this.cbAnders = new System.Windows.Forms.CheckBox();
            this.btOk = new System.Windows.Forms.Button();
            this.rb1H = new System.Windows.Forms.RadioButton();
            this.rb30Min = new System.Windows.Forms.RadioButton();
            this.rb10Min = new System.Windows.Forms.RadioButton();
            this.rb5Min = new System.Windows.Forms.RadioButton();
            this.btAnnuleren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuten)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMinuten
            // 
            this.lbMinuten.AutoSize = true;
            this.lbMinuten.Location = new System.Drawing.Point(223, 14);
            this.lbMinuten.Name = "lbMinuten";
            this.lbMinuten.Size = new System.Drawing.Size(44, 13);
            this.lbMinuten.TabIndex = 16;
            this.lbMinuten.Text = "minuten";
            this.lbMinuten.Visible = false;
            // 
            // nudMinuten
            // 
            this.nudMinuten.Location = new System.Drawing.Point(140, 11);
            this.nudMinuten.Name = "nudMinuten";
            this.nudMinuten.Size = new System.Drawing.Size(77, 20);
            this.nudMinuten.TabIndex = 15;
            this.nudMinuten.Visible = false;
            // 
            // cbAnders
            // 
            this.cbAnders.AutoSize = true;
            this.cbAnders.Location = new System.Drawing.Point(12, 107);
            this.cbAnders.Name = "cbAnders";
            this.cbAnders.Size = new System.Drawing.Size(59, 17);
            this.cbAnders.TabIndex = 14;
            this.cbAnders.Text = "Anders";
            this.cbAnders.UseVisualStyleBackColor = true;
            this.cbAnders.CheckedChanged += new System.EventHandler(this.cbAnders_CheckedChanged);
            // 
            // btOk
            // 
            this.btOk.Enabled = false;
            this.btOk.Location = new System.Drawing.Point(190, 69);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 13;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // rb1H
            // 
            this.rb1H.AutoSize = true;
            this.rb1H.Location = new System.Drawing.Point(12, 84);
            this.rb1H.Name = "rb1H";
            this.rb1H.Size = new System.Drawing.Size(49, 17);
            this.rb1H.TabIndex = 12;
            this.rb1H.TabStop = true;
            this.rb1H.Text = "1 uur";
            this.rb1H.UseVisualStyleBackColor = true;
            this.rb1H.CheckedChanged += new System.EventHandler(this.rb1H_CheckedChanged);
            // 
            // rb30Min
            // 
            this.rb30Min.AutoSize = true;
            this.rb30Min.Location = new System.Drawing.Point(12, 60);
            this.rb30Min.Name = "rb30Min";
            this.rb30Min.Size = new System.Drawing.Size(77, 17);
            this.rb30Min.TabIndex = 11;
            this.rb30Min.TabStop = true;
            this.rb30Min.Text = "30 minuten";
            this.rb30Min.UseVisualStyleBackColor = true;
            this.rb30Min.CheckedChanged += new System.EventHandler(this.rb30Min_CheckedChanged);
            // 
            // rb10Min
            // 
            this.rb10Min.AutoSize = true;
            this.rb10Min.Location = new System.Drawing.Point(12, 36);
            this.rb10Min.Name = "rb10Min";
            this.rb10Min.Size = new System.Drawing.Size(77, 17);
            this.rb10Min.TabIndex = 10;
            this.rb10Min.TabStop = true;
            this.rb10Min.Text = "10 minuten";
            this.rb10Min.UseVisualStyleBackColor = true;
            this.rb10Min.CheckedChanged += new System.EventHandler(this.rb10Min_CheckedChanged);
            // 
            // rb5Min
            // 
            this.rb5Min.AutoSize = true;
            this.rb5Min.Location = new System.Drawing.Point(12, 12);
            this.rb5Min.Name = "rb5Min";
            this.rb5Min.Size = new System.Drawing.Size(71, 17);
            this.rb5Min.TabIndex = 9;
            this.rb5Min.TabStop = true;
            this.rb5Min.Text = "5 minuten";
            this.rb5Min.UseVisualStyleBackColor = true;
            this.rb5Min.CheckedChanged += new System.EventHandler(this.rb5Min_CheckedChanged);
            // 
            // btAnnuleren
            // 
            this.btAnnuleren.Enabled = false;
            this.btAnnuleren.Location = new System.Drawing.Point(190, 98);
            this.btAnnuleren.Name = "btAnnuleren";
            this.btAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.btAnnuleren.TabIndex = 17;
            this.btAnnuleren.Text = "Annuleren";
            this.btAnnuleren.UseVisualStyleBackColor = true;
            this.btAnnuleren.Click += new System.EventHandler(this.btAnnuleren_Click);
            // 
            // SluitAf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 133);
            this.Controls.Add(this.btAnnuleren);
            this.Controls.Add(this.lbMinuten);
            this.Controls.Add(this.nudMinuten);
            this.Controls.Add(this.cbAnders);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.rb1H);
            this.Controls.Add(this.rb30Min);
            this.Controls.Add(this.rb10Min);
            this.Controls.Add(this.rb5Min);
            this.Name = "SluitAf";
            this.Text = "Afsluiten";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMinuten;
        private System.Windows.Forms.NumericUpDown nudMinuten;
        private System.Windows.Forms.CheckBox cbAnders;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.RadioButton rb1H;
        private System.Windows.Forms.RadioButton rb30Min;
        private System.Windows.Forms.RadioButton rb10Min;
        private System.Windows.Forms.RadioButton rb5Min;
        private System.Windows.Forms.Button btAnnuleren;
    }
}

