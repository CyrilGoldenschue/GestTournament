namespace GestionTournament
{
    partial class FrmPlayers
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
            this.txtNbPlayer = new System.Windows.Forms.Label();
            this.nudPlayer = new System.Windows.Forms.NumericUpDown();
            this.nudConsole = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPool = new System.Windows.Forms.NumericUpDown();
            this.lblNbPool = new System.Windows.Forms.Label();
            this.cmdFinish = new System.Windows.Forms.Button();
            this.cmdUseOldTournament = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPool)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNbPlayer
            // 
            this.txtNbPlayer.AutoSize = true;
            this.txtNbPlayer.Location = new System.Drawing.Point(13, 13);
            this.txtNbPlayer.Name = "txtNbPlayer";
            this.txtNbPlayer.Size = new System.Drawing.Size(96, 13);
            this.txtNbPlayer.TabIndex = 0;
            this.txtNbPlayer.Text = "Nombre de joueurs";
            // 
            // nudPlayer
            // 
            this.nudPlayer.Location = new System.Drawing.Point(16, 30);
            this.nudPlayer.Name = "nudPlayer";
            this.nudPlayer.Size = new System.Drawing.Size(93, 20);
            this.nudPlayer.TabIndex = 1;
            // 
            // nudConsole
            // 
            this.nudConsole.Location = new System.Drawing.Point(16, 87);
            this.nudConsole.Name = "nudConsole";
            this.nudConsole.Size = new System.Drawing.Size(93, 20);
            this.nudConsole.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de console avec le jeu";
            // 
            // nudPool
            // 
            this.nudPool.Location = new System.Drawing.Point(16, 146);
            this.nudPool.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPool.Name = "nudPool";
            this.nudPool.Size = new System.Drawing.Size(93, 20);
            this.nudPool.TabIndex = 5;
            this.nudPool.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblNbPool
            // 
            this.lblNbPool.AutoSize = true;
            this.lblNbPool.Location = new System.Drawing.Point(13, 129);
            this.lblNbPool.Name = "lblNbPool";
            this.lblNbPool.Size = new System.Drawing.Size(59, 13);
            this.lblNbPool.TabIndex = 4;
            this.lblNbPool.Text = "Nb de pool";
            // 
            // cmdFinish
            // 
            this.cmdFinish.Location = new System.Drawing.Point(16, 179);
            this.cmdFinish.Name = "cmdFinish";
            this.cmdFinish.Size = new System.Drawing.Size(164, 23);
            this.cmdFinish.TabIndex = 6;
            this.cmdFinish.Text = "Terminer";
            this.cmdFinish.UseVisualStyleBackColor = true;
            // 
            // cmdUseOldTournament
            // 
            this.cmdUseOldTournament.Location = new System.Drawing.Point(16, 209);
            this.cmdUseOldTournament.Name = "cmdUseOldTournament";
            this.cmdUseOldTournament.Size = new System.Drawing.Size(164, 23);
            this.cmdUseOldTournament.TabIndex = 7;
            this.cmdUseOldTournament.Text = "Utiliser un tournois déjà créé";
            this.cmdUseOldTournament.UseVisualStyleBackColor = true;
            // 
            // FrmPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 243);
            this.Controls.Add(this.cmdUseOldTournament);
            this.Controls.Add(this.cmdFinish);
            this.Controls.Add(this.nudPool);
            this.Controls.Add(this.lblNbPool);
            this.Controls.Add(this.nudConsole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPlayer);
            this.Controls.Add(this.txtNbPlayer);
            this.Name = "FrmPlayers";
            this.Text = "Players";
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNbPlayer;
        private System.Windows.Forms.NumericUpDown nudPlayer;
        private System.Windows.Forms.NumericUpDown nudConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPool;
        private System.Windows.Forms.Label lblNbPool;
        private System.Windows.Forms.Button cmdFinish;
        private System.Windows.Forms.Button cmdUseOldTournament;
    }
}