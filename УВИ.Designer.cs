namespace d1
{
    partial class УВИ
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(УВИ));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.выбратьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.overwatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paladinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьИгруToolStripMenuItem,
            this.выйтиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1950, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// выбратьИгруToolStripMenuItem
			// 
			this.выбратьИгруToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overwatchToolStripMenuItem,
            this.paladinsToolStripMenuItem});
			this.выбратьИгруToolStripMenuItem.Name = "выбратьИгруToolStripMenuItem";
			this.выбратьИгруToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.выбратьИгруToolStripMenuItem.Text = "Выбрать игру";
			// 
			// overwatchToolStripMenuItem
			// 
			this.overwatchToolStripMenuItem.Name = "overwatchToolStripMenuItem";
			this.overwatchToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.overwatchToolStripMenuItem.Text = "Overwatch";
			this.overwatchToolStripMenuItem.Click += new System.EventHandler(this.overwatchToolStripMenuItem_Click);
			// 
			// paladinsToolStripMenuItem
			// 
			this.paladinsToolStripMenuItem.Name = "paladinsToolStripMenuItem";
			this.paladinsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.paladinsToolStripMenuItem.Text = "Paladins";
			this.paladinsToolStripMenuItem.Click += new System.EventHandler(this.paladinsToolStripMenuItem_Click);
			// 
			// выйтиToolStripMenuItem
			// 
			this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
			this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.выйтиToolStripMenuItem.Text = "Выйти";
			this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1930, 835);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(0, 858);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(1950, 96);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 960);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(216, 41);
			this.button1.TabIndex = 4;
			this.button1.Text = "Продолжить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1904, 1041);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overwatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem paladinsToolStripMenuItem;
    }
}

