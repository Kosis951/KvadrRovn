namespace KvadrRovn
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.boxA = new System.Windows.Forms.Label();
            this.boxB = new System.Windows.Forms.Label();
            this.boxC = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typPísmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDis = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(94, 112);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(29, 20);
            this.textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(177, 112);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(29, 20);
            this.textBoxB.TabIndex = 1;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(269, 112);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(29, 20);
            this.textBoxC.TabIndex = 2;
            // 
            // boxA
            // 
            this.boxA.AutoSize = true;
            this.boxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxA.Location = new System.Drawing.Point(91, 164);
            this.boxA.Name = "boxA";
            this.boxA.Size = new System.Drawing.Size(15, 13);
            this.boxA.TabIndex = 3;
            this.boxA.Text = "A";
            // 
            // boxB
            // 
            this.boxB.AutoSize = true;
            this.boxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxB.Location = new System.Drawing.Point(174, 164);
            this.boxB.Name = "boxB";
            this.boxB.Size = new System.Drawing.Size(15, 13);
            this.boxB.TabIndex = 4;
            this.boxB.Text = "B";
            // 
            // boxC
            // 
            this.boxC.AutoSize = true;
            this.boxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxC.Location = new System.Drawing.Point(266, 164);
            this.boxC.Name = "boxC";
            this.boxC.Size = new System.Drawing.Size(15, 13);
            this.boxC.TabIndex = 5;
            this.boxC.Text = "C";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.65F);
            this.labelResult.Location = new System.Drawing.Point(88, 232);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 15);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Vysledek";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(366, 112);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 7;
            this.Calculate.Text = "Vypočítej";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.nastaveníToolStripMenuItem,
            this.nápovědaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konecToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barvaToolStripMenuItem,
            this.typPísmaToolStripMenuItem});
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nastaveníToolStripMenuItem.Text = "Nastavení";
            // 
            // barvaToolStripMenuItem
            // 
            this.barvaToolStripMenuItem.Name = "barvaToolStripMenuItem";
            this.barvaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barvaToolStripMenuItem.Text = "Barva";
            this.barvaToolStripMenuItem.Click += new System.EventHandler(this.barvaToolStripMenuItem_Click);
            // 
            // typPísmaToolStripMenuItem
            // 
            this.typPísmaToolStripMenuItem.Name = "typPísmaToolStripMenuItem";
            this.typPísmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.typPísmaToolStripMenuItem.Text = "Typ písma";
            this.typPísmaToolStripMenuItem.Click += new System.EventHandler(this.typPísmaToolStripMenuItem_Click);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikaciToolStripMenuItem});
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // oAplikaciToolStripMenuItem
            // 
            this.oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
            this.oAplikaciToolStripMenuItem.Click += new System.EventHandler(this.oAplikaciToolStripMenuItem_Click);
            // 
            // labelDis
            // 
            this.labelDis.AutoSize = true;
            this.labelDis.Location = new System.Drawing.Point(419, 197);
            this.labelDis.Name = "labelDis";
            this.labelDis.Size = new System.Drawing.Size(64, 13);
            this.labelDis.TabIndex = 10;
            this.labelDis.Text = "Diskriminant";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDis);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.boxC);
            this.Controls.Add(this.boxB);
            this.Controls.Add(this.boxA);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kvadratická rovnice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label boxA;
        private System.Windows.Forms.Label boxB;
        private System.Windows.Forms.Label boxC;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typPísmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nápovědaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikaciToolStripMenuItem;
        private System.Windows.Forms.Label labelDis;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

