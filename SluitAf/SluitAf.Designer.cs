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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SluitAf));
            this.lbMinuten = new System.Windows.Forms.Label();
            this.nudMinuten = new System.Windows.Forms.NumericUpDown();
            this.cbAnders = new System.Windows.Forms.CheckBox();
            this.btOk = new System.Windows.Forms.Button();
            this.rb1H = new System.Windows.Forms.RadioButton();
            this.rb30Min = new System.Windows.Forms.RadioButton();
            this.rb10Min = new System.Windows.Forms.RadioButton();
            this.rb5Min = new System.Windows.Forms.RadioButton();
            this.btAnnuleren = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbTijd = new System.Windows.Forms.TextBox();
            this.rbSlaapstand = new System.Windows.Forms.RadioButton();
            this.rbAfsluiten = new System.Windows.Forms.RadioButton();
            this.btn_obt_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bekijkHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuten)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMinuten
            // 
            resources.ApplyResources(this.lbMinuten, "lbMinuten");
            this.lbMinuten.Name = "lbMinuten";
            // 
            // nudMinuten
            // 
            resources.ApplyResources(this.nudMinuten, "nudMinuten");
            this.nudMinuten.Name = "nudMinuten";
            // 
            // cbAnders
            // 
            resources.ApplyResources(this.cbAnders, "cbAnders");
            this.cbAnders.Name = "cbAnders";
            this.cbAnders.UseVisualStyleBackColor = true;
            this.cbAnders.CheckedChanged += new System.EventHandler(this.cbAnders_CheckedChanged);
            // 
            // btOk
            // 
            resources.ApplyResources(this.btOk, "btOk");
            this.btOk.Name = "btOk";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // rb1H
            // 
            resources.ApplyResources(this.rb1H, "rb1H");
            this.rb1H.Name = "rb1H";
            this.rb1H.TabStop = true;
            this.rb1H.UseVisualStyleBackColor = true;
            this.rb1H.CheckedChanged += new System.EventHandler(this.rb1H_CheckedChanged);
            // 
            // rb30Min
            // 
            resources.ApplyResources(this.rb30Min, "rb30Min");
            this.rb30Min.Name = "rb30Min";
            this.rb30Min.TabStop = true;
            this.rb30Min.UseVisualStyleBackColor = true;
            this.rb30Min.CheckedChanged += new System.EventHandler(this.rb30Min_CheckedChanged);
            // 
            // rb10Min
            // 
            resources.ApplyResources(this.rb10Min, "rb10Min");
            this.rb10Min.Name = "rb10Min";
            this.rb10Min.TabStop = true;
            this.rb10Min.UseVisualStyleBackColor = true;
            this.rb10Min.CheckedChanged += new System.EventHandler(this.rb10Min_CheckedChanged);
            // 
            // rb5Min
            // 
            resources.ApplyResources(this.rb5Min, "rb5Min");
            this.rb5Min.Name = "rb5Min";
            this.rb5Min.TabStop = true;
            this.rb5Min.UseVisualStyleBackColor = true;
            this.rb5Min.CheckedChanged += new System.EventHandler(this.rb5Min_CheckedChanged);
            // 
            // btAnnuleren
            // 
            resources.ApplyResources(this.btAnnuleren, "btAnnuleren");
            this.btAnnuleren.Name = "btAnnuleren";
            this.btAnnuleren.UseVisualStyleBackColor = true;
            this.btAnnuleren.Click += new System.EventHandler(this.btAnnuleren_Click);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.btOk);
            this.tabPage1.Controls.Add(this.btAnnuleren);
            this.tabPage1.Controls.Add(this.rb5Min);
            this.tabPage1.Controls.Add(this.lbMinuten);
            this.tabPage1.Controls.Add(this.rb10Min);
            this.tabPage1.Controls.Add(this.nudMinuten);
            this.tabPage1.Controls.Add(this.rb30Min);
            this.tabPage1.Controls.Add(this.cbAnders);
            this.tabPage1.Controls.Add(this.rb1H);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.tbTijd);
            this.tabPage2.Controls.Add(this.rbSlaapstand);
            this.tabPage2.Controls.Add(this.rbAfsluiten);
            this.tabPage2.Controls.Add(this.btn_obt_OK);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbTijd
            // 
            resources.ApplyResources(this.tbTijd, "tbTijd");
            this.tbTijd.Name = "tbTijd";
            // 
            // rbSlaapstand
            // 
            resources.ApplyResources(this.rbSlaapstand, "rbSlaapstand");
            this.rbSlaapstand.Name = "rbSlaapstand";
            this.rbSlaapstand.UseVisualStyleBackColor = true;
            // 
            // rbAfsluiten
            // 
            resources.ApplyResources(this.rbAfsluiten, "rbAfsluiten");
            this.rbAfsluiten.Checked = true;
            this.rbAfsluiten.Name = "rbAfsluiten";
            this.rbAfsluiten.TabStop = true;
            this.rbAfsluiten.UseVisualStyleBackColor = true;
            // 
            // btn_obt_OK
            // 
            resources.ApplyResources(this.btn_obt_OK, "btn_obt_OK");
            this.btn_obt_OK.Name = "btn_obt_OK";
            this.btn_obt_OK.UseVisualStyleBackColor = true;
            this.btn_obt_OK.Click += new System.EventHandler(this.btn_obt_OK_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            resources.ApplyResources(this.bestandToolStripMenuItem, "bestandToolStripMenuItem");
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            // 
            // afsluitenToolStripMenuItem
            // 
            resources.ApplyResources(this.afsluitenToolStripMenuItem, "afsluitenToolStripMenuItem");
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bekijkHelpToolStripMenuItem,
            this.overToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // bekijkHelpToolStripMenuItem
            // 
            resources.ApplyResources(this.bekijkHelpToolStripMenuItem, "bekijkHelpToolStripMenuItem");
            this.bekijkHelpToolStripMenuItem.Name = "bekijkHelpToolStripMenuItem";
            this.bekijkHelpToolStripMenuItem.Click += new System.EventHandler(this.bekijkHelpToolStripMenuItem_Click);
            // 
            // overToolStripMenuItem
            // 
            resources.ApplyResources(this.overToolStripMenuItem, "overToolStripMenuItem");
            this.overToolStripMenuItem.Name = "overToolStripMenuItem";
            this.overToolStripMenuItem.Click += new System.EventHandler(this.overToolStripMenuItem_Click);
            // 
            // SluitAf
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SluitAf";
            this.Load += new System.EventHandler(this.SluitAf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuten)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_obt_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSlaapstand;
        private System.Windows.Forms.RadioButton rbAfsluiten;
        private System.Windows.Forms.TextBox tbTijd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bekijkHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overToolStripMenuItem;
    }
}

