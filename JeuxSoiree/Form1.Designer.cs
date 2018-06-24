namespace JeuxSoiree
{
    partial class Menu_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jeuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionVeriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piccoloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blindTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tournoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuxToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.tournoisToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuxToolStripMenuItem
            // 
            this.jeuxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionVeriteToolStripMenuItem,
            this.piccoloToolStripMenuItem,
            this.blindTestToolStripMenuItem});
            this.jeuxToolStripMenuItem.Name = "jeuxToolStripMenuItem";
            this.jeuxToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.jeuxToolStripMenuItem.Text = "Jeux";
            // 
            // actionVeriteToolStripMenuItem
            // 
            this.actionVeriteToolStripMenuItem.Name = "actionVeriteToolStripMenuItem";
            this.actionVeriteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.actionVeriteToolStripMenuItem.Text = "Action_Verite";
            this.actionVeriteToolStripMenuItem.Click += new System.EventHandler(this.actionVeriteToolStripMenuItem_Click);
            // 
            // piccoloToolStripMenuItem
            // 
            this.piccoloToolStripMenuItem.Name = "piccoloToolStripMenuItem";
            this.piccoloToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.piccoloToolStripMenuItem.Text = "Piccolo";
            // 
            // blindTestToolStripMenuItem
            // 
            this.blindTestToolStripMenuItem.Name = "blindTestToolStripMenuItem";
            this.blindTestToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.blindTestToolStripMenuItem.Text = "Blind Test";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // tournoisToolStripMenuItem
            // 
            this.tournoisToolStripMenuItem.Name = "tournoisToolStripMenuItem";
            this.tournoisToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tournoisToolStripMenuItem.Text = "Tournois";
            // 
            // Menu_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 452);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Menu_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionVeriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piccoloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blindTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tournoisToolStripMenuItem;
    }
}

