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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMaximiz;
        private System.Windows.Forms.Button btMinimiz;
    }
}

