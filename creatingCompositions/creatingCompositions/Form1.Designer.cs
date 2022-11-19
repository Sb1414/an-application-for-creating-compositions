namespace creatingCompositions
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMaximiz = new System.Windows.Forms.Button();
            this.btMinimiz = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelUp2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.предмет1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mVaseCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mTeapot1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mCupCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mPlateC = new System.Windows.Forms.ToolStripMenuItem();
            this.предмет2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mVaseLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mCupLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.Teapot2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mPlateL = new System.Windows.Forms.ToolStripMenuItem();
            this.предмет3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mVaseRight = new System.Windows.Forms.ToolStripMenuItem();
            this.mCupRight = new System.Windows.Forms.ToolStripMenuItem();
            this.mTeapot = new System.Windows.Forms.ToolStripMenuItem();
            this.mPlateR = new System.Windows.Forms.ToolStripMenuItem();
            this.фонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mNo = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panelUp2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btMaximiz);
            this.panel1.Controls.Add(this.btMinimiz);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseMove);
            // 
            // btMaximiz
            // 
            this.btMaximiz.BackColor = System.Drawing.Color.Transparent;
            this.btMaximiz.BackgroundImage = global::creatingCompositions.Properties.Resources.icons8_macos_полный_экран_20;
            this.btMaximiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMaximiz.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMaximiz.FlatAppearance.BorderSize = 0;
            this.btMaximiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btMaximiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btMaximiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximiz.Location = new System.Drawing.Point(60, 0);
            this.btMaximiz.Name = "btMaximiz";
            this.btMaximiz.Size = new System.Drawing.Size(30, 30);
            this.btMaximiz.TabIndex = 2;
            this.btMaximiz.UseVisualStyleBackColor = false;
            this.btMaximiz.Click += new System.EventHandler(this.btMaximiz_Click);
            // 
            // btMinimiz
            // 
            this.btMinimiz.BackColor = System.Drawing.Color.Transparent;
            this.btMinimiz.BackgroundImage = global::creatingCompositions.Properties.Resources.icons8_macos_свернуть_20;
            this.btMinimiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMinimiz.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMinimiz.FlatAppearance.BorderSize = 0;
            this.btMinimiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btMinimiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btMinimiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimiz.Location = new System.Drawing.Point(30, 0);
            this.btMinimiz.Name = "btMinimiz";
            this.btMinimiz.Size = new System.Drawing.Size(30, 30);
            this.btMinimiz.TabIndex = 1;
            this.btMinimiz.UseVisualStyleBackColor = false;
            this.btMinimiz.Click += new System.EventHandler(this.btMinimiz_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.BackgroundImage = global::creatingCompositions.Properties.Resources.icons8_macos_закрыть_20;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(0, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(30, 30);
            this.btClose.TabIndex = 0;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 30);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 539);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panelUp2
            // 
            this.panelUp2.Controls.Add(this.menuStrip1);
            this.panelUp2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp2.Location = new System.Drawing.Point(3, 30);
            this.panelUp2.Name = "panelUp2";
            this.panelUp2.Size = new System.Drawing.Size(797, 30);
            this.panelUp2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::creatingCompositions.Properties.Resources.panel;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.предмет1ToolStripMenuItem,
            this.предмет2ToolStripMenuItem,
            this.предмет3ToolStripMenuItem,
            this.фонToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // предмет1ToolStripMenuItem
            // 
            this.предмет1ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.предмет1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mVaseCenter,
            this.mTeapot1,
            this.mCupCenter,
            this.mPlateC});
            this.предмет1ToolStripMenuItem.Name = "предмет1ToolStripMenuItem";
            this.предмет1ToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.предмет1ToolStripMenuItem.Text = "предмет 1";
            // 
            // mVaseCenter
            // 
            this.mVaseCenter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mVaseCenter.Name = "mVaseCenter";
            this.mVaseCenter.Size = new System.Drawing.Size(146, 26);
            this.mVaseCenter.Text = "ваза";
            this.mVaseCenter.Click += new System.EventHandler(this.mVaseCenter_Click);
            // 
            // mTeapot1
            // 
            this.mTeapot1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mTeapot1.Name = "mTeapot1";
            this.mTeapot1.Size = new System.Drawing.Size(146, 26);
            this.mTeapot1.Text = "чайник";
            this.mTeapot1.Click += new System.EventHandler(this.mTeapot1_Click);
            // 
            // mCupCenter
            // 
            this.mCupCenter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mCupCenter.Name = "mCupCenter";
            this.mCupCenter.Size = new System.Drawing.Size(146, 26);
            this.mCupCenter.Text = "кружка";
            this.mCupCenter.Click += new System.EventHandler(this.mCupCenter_Click);
            // 
            // mPlateC
            // 
            this.mPlateC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mPlateC.Name = "mPlateC";
            this.mPlateC.Size = new System.Drawing.Size(146, 26);
            this.mPlateC.Text = "тарелка";
            this.mPlateC.Click += new System.EventHandler(this.mPlateC_Click);
            // 
            // предмет2ToolStripMenuItem
            // 
            this.предмет2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mVaseLeft,
            this.mCupLeft,
            this.Teapot2,
            this.mPlateL});
            this.предмет2ToolStripMenuItem.Name = "предмет2ToolStripMenuItem";
            this.предмет2ToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.предмет2ToolStripMenuItem.Text = "предмет 2";
            // 
            // mVaseLeft
            // 
            this.mVaseLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mVaseLeft.Name = "mVaseLeft";
            this.mVaseLeft.Size = new System.Drawing.Size(146, 26);
            this.mVaseLeft.Text = "ваза";
            this.mVaseLeft.Click += new System.EventHandler(this.mVaseLeft_Click);
            // 
            // mCupLeft
            // 
            this.mCupLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mCupLeft.Name = "mCupLeft";
            this.mCupLeft.Size = new System.Drawing.Size(146, 26);
            this.mCupLeft.Text = "кружка";
            this.mCupLeft.Click += new System.EventHandler(this.mCupLeft_Click);
            // 
            // Teapot2
            // 
            this.Teapot2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Teapot2.Name = "Teapot2";
            this.Teapot2.Size = new System.Drawing.Size(146, 26);
            this.Teapot2.Text = "чайник";
            this.Teapot2.Click += new System.EventHandler(this.Teapot2_Click);
            // 
            // mPlateL
            // 
            this.mPlateL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mPlateL.Name = "mPlateL";
            this.mPlateL.Size = new System.Drawing.Size(146, 26);
            this.mPlateL.Text = "тарелка";
            this.mPlateL.Click += new System.EventHandler(this.mPlateL_Click);
            // 
            // предмет3ToolStripMenuItem
            // 
            this.предмет3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mVaseRight,
            this.mCupRight,
            this.mTeapot,
            this.mPlateR});
            this.предмет3ToolStripMenuItem.Name = "предмет3ToolStripMenuItem";
            this.предмет3ToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.предмет3ToolStripMenuItem.Text = "предмет 3";
            // 
            // mVaseRight
            // 
            this.mVaseRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mVaseRight.Name = "mVaseRight";
            this.mVaseRight.Size = new System.Drawing.Size(146, 26);
            this.mVaseRight.Text = "ваза";
            this.mVaseRight.Click += new System.EventHandler(this.mVaseRight_Click);
            // 
            // mCupRight
            // 
            this.mCupRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mCupRight.Name = "mCupRight";
            this.mCupRight.Size = new System.Drawing.Size(146, 26);
            this.mCupRight.Text = "кружка";
            this.mCupRight.Click += new System.EventHandler(this.mCupRight_Click);
            // 
            // mTeapot
            // 
            this.mTeapot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mTeapot.Name = "mTeapot";
            this.mTeapot.Size = new System.Drawing.Size(146, 26);
            this.mTeapot.Text = "чайник";
            this.mTeapot.Click += new System.EventHandler(this.mTeapot_Click);
            // 
            // mPlateR
            // 
            this.mPlateR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mPlateR.Name = "mPlateR";
            this.mPlateR.Size = new System.Drawing.Size(146, 26);
            this.mPlateR.Text = "тарелка";
            this.mPlateR.Click += new System.EventHandler(this.mPlateR_Click);
            // 
            // фонToolStripMenuItem
            // 
            this.фонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.столToolStripMenuItem,
            this.mNo});
            this.фонToolStripMenuItem.Name = "фонToolStripMenuItem";
            this.фонToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.фонToolStripMenuItem.Text = "фон";
            // 
            // столToolStripMenuItem
            // 
            this.столToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.столToolStripMenuItem.Name = "столToolStripMenuItem";
            this.столToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.столToolStripMenuItem.Text = "стол";
            this.столToolStripMenuItem.Click += new System.EventHandler(this.столToolStripMenuItem_Click);
            // 
            // buttonRes
            // 
            this.buttonRes.BackColor = System.Drawing.Color.Transparent;
            this.buttonRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRes.FlatAppearance.BorderSize = 0;
            this.buttonRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRes.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRes.Location = new System.Drawing.Point(323, 474);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(168, 55);
            this.buttonRes.TabIndex = 5;
            this.buttonRes.Text = "Res";
            this.buttonRes.UseVisualStyleBackColor = false;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 22);
            this.label1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(30, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // mNo
            // 
            this.mNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mNo.Name = "mNo";
            this.mNo.Size = new System.Drawing.Size(224, 26);
            this.mNo.Text = "нет";
            this.mNo.Click += new System.EventHandler(this.mNo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::creatingCompositions.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelUp2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panelUp2.ResumeLayout(false);
            this.panelUp2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMaximiz;
        private System.Windows.Forms.Button btMinimiz;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelUp2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem предмет1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mVaseCenter;
        private System.Windows.Forms.ToolStripMenuItem mTeapot1;
        private System.Windows.Forms.ToolStripMenuItem mCupCenter;
        private System.Windows.Forms.ToolStripMenuItem предмет2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mVaseLeft;
        private System.Windows.Forms.ToolStripMenuItem mCupLeft;
        private System.Windows.Forms.ToolStripMenuItem Teapot2;
        private System.Windows.Forms.ToolStripMenuItem предмет3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mVaseRight;
        private System.Windows.Forms.ToolStripMenuItem mCupRight;
        private System.Windows.Forms.ToolStripMenuItem mTeapot;
        private System.Windows.Forms.ToolStripMenuItem фонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mPlateC;
        private System.Windows.Forms.ToolStripMenuItem mPlateL;
        private System.Windows.Forms.ToolStripMenuItem mPlateR;
        private System.Windows.Forms.ToolStripMenuItem mNo;
    }
}

