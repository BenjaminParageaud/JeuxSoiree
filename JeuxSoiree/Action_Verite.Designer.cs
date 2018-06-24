namespace JeuxSoiree
{
    partial class Action_Verite
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
            this.nbrPersonnes = new System.Windows.Forms.ComboBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nbrPersonnes
            // 
            this.nbrPersonnes.FormattingEnabled = true;
            this.nbrPersonnes.Location = new System.Drawing.Point(180, 76);
            this.nbrPersonnes.Name = "nbrPersonnes";
            this.nbrPersonnes.Size = new System.Drawing.Size(128, 21);
            this.nbrPersonnes.TabIndex = 0;
            this.nbrPersonnes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(177, 28);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(35, 13);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "label1";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(13, 84);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer.TabIndex = 2;
            this.labelPlayer.Text = "label2";
            // 
            // Action_Verite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 466);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.nbrPersonnes);
            this.Name = "Action_Verite";
            this.Text = "Action_Verite";
            this.Load += new System.EventHandler(this.Action_Verite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nbrPersonnes;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label labelPlayer;
    }
}