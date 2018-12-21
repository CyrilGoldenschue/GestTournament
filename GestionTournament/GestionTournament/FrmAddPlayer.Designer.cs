namespace GestionTournament
{
    partial class FrmAddPlayer
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
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.lblJ = new System.Windows.Forms.Label();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.cmdValidate = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdDeletePlayer = new System.Windows.Forms.Button();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Location = new System.Drawing.Point(12, 9);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(85, 13);
            this.lblNamePlayer.TabIndex = 0;
            this.lblNamePlayer.Text = "Nom du joueur : ";
            // 
            // lblJ
            // 
            this.lblJ.AutoSize = true;
            this.lblJ.Location = new System.Drawing.Point(103, 9);
            this.lblJ.Name = "lblJ";
            this.lblJ.Size = new System.Drawing.Size(21, 13);
            this.lblJ.TabIndex = 1;
            this.lblJ.Text = "J 1";
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.Location = new System.Drawing.Point(15, 26);
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.Size = new System.Drawing.Size(161, 20);
            this.txtNamePlayer.TabIndex = 2;
            // 
            // cmdValidate
            // 
            this.cmdValidate.Location = new System.Drawing.Point(15, 52);
            this.cmdValidate.Name = "cmdValidate";
            this.cmdValidate.Size = new System.Drawing.Size(75, 23);
            this.cmdValidate.TabIndex = 4;
            this.cmdValidate.Text = "Valider";
            this.cmdValidate.UseVisualStyleBackColor = true;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(101, 52);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 5;
            this.cmdClear.Text = "Effacer";
            this.cmdClear.UseVisualStyleBackColor = true;
            // 
            // cmdDeletePlayer
            // 
            this.cmdDeletePlayer.Enabled = false;
            this.cmdDeletePlayer.Location = new System.Drawing.Point(15, 415);
            this.cmdDeletePlayer.Name = "cmdDeletePlayer";
            this.cmdDeletePlayer.Size = new System.Drawing.Size(161, 23);
            this.cmdDeletePlayer.TabIndex = 6;
            this.cmdDeletePlayer.Text = "Supprimer";
            this.cmdDeletePlayer.UseVisualStyleBackColor = true;
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(15, 82);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(161, 329);
            this.lstPlayers.TabIndex = 7;
            // 
            // FrmAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 450);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.cmdDeletePlayer);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdValidate);
            this.Controls.Add(this.txtNamePlayer);
            this.Controls.Add(this.lblJ);
            this.Controls.Add(this.lblNamePlayer);
            this.Name = "FrmAddPlayer";
            this.Text = "FrmAddPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.Label lblJ;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.Button cmdValidate;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdDeletePlayer;
        private System.Windows.Forms.ListBox lstPlayers;
    }
}