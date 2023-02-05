namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pvPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.whosTurn = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(268, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pvPToolStripMenuItem,
            this.vsComputerToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            // 
            // pvPToolStripMenuItem
            // 
            this.pvPToolStripMenuItem.Name = "pvPToolStripMenuItem";
            this.pvPToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.pvPToolStripMenuItem.Text = "vs Person";
            this.pvPToolStripMenuItem.Click += new System.EventHandler(this.pvPToolStripMenuItem_Click);
            // 
            // vsComputerToolStripMenuItem
            // 
            this.vsComputerToolStripMenuItem.Name = "vsComputerToolStripMenuItem";
            this.vsComputerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.vsComputerToolStripMenuItem.Text = "vs Computer";
            this.vsComputerToolStripMenuItem.Click += new System.EventHandler(this.vsComputerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A1.Location = new System.Drawing.Point(16, 45);
            this.A1.Margin = new System.Windows.Forms.Padding(2);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 81);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.buttonClick);
            this.A1.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.A1.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A2.Location = new System.Drawing.Point(96, 45);
            this.A2.Margin = new System.Windows.Forms.Padding(2);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 81);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.buttonClick);
            this.A2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.A2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A3.Location = new System.Drawing.Point(176, 45);
            this.A3.Margin = new System.Windows.Forms.Padding(2);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 81);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.buttonClick);
            this.A3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.A3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B1.Location = new System.Drawing.Point(16, 131);
            this.B1.Margin = new System.Windows.Forms.Padding(2);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 81);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.buttonClick);
            this.B1.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.B1.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B2.Location = new System.Drawing.Point(96, 131);
            this.B2.Margin = new System.Windows.Forms.Padding(2);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 81);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.buttonClick);
            this.B2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.B2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B3.Location = new System.Drawing.Point(176, 131);
            this.B3.Margin = new System.Windows.Forms.Padding(2);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 81);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.buttonClick);
            this.B3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.B3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C1.Location = new System.Drawing.Point(16, 217);
            this.C1.Margin = new System.Windows.Forms.Padding(2);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 81);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.buttonClick);
            this.C1.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.C1.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C2.Location = new System.Drawing.Point(96, 217);
            this.C2.Margin = new System.Windows.Forms.Padding(2);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 81);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.buttonClick);
            this.C2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.C2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C3.Location = new System.Drawing.Point(176, 217);
            this.C3.Margin = new System.Windows.Forms.Padding(2);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 81);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.buttonClick);
            this.C3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.C3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // whosTurn
            // 
            this.whosTurn.AutoSize = true;
            this.whosTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.whosTurn.Location = new System.Drawing.Point(13, 316);
            this.whosTurn.Name = "whosTurn";
            this.whosTurn.Size = new System.Drawing.Size(69, 25);
            this.whosTurn.TabIndex = 10;
            this.whosTurn.Text = "X turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 374);
            this.Controls.Add(this.whosTurn);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label whosTurn;
        private System.Windows.Forms.ToolStripMenuItem pvPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vsComputerToolStripMenuItem;
    }
}

