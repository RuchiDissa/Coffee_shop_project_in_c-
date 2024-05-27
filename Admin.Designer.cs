namespace ProjectCmpe214
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.btnED = new System.Windows.Forms.Button();
            this.btnusers = new System.Windows.Forms.Button();
            this.lblED = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnED
            // 
            this.btnED.BackColor = System.Drawing.Color.SandyBrown;
            this.btnED.Location = new System.Drawing.Point(344, 38);
            this.btnED.Name = "btnED";
            this.btnED.Size = new System.Drawing.Size(214, 44);
            this.btnED.TabIndex = 0;
            this.btnED.Text = "Employee Details";
            this.btnED.UseVisualStyleBackColor = false;
            this.btnED.Click += new System.EventHandler(this.btnED_Click);
            // 
            // btnusers
            // 
            this.btnusers.BackColor = System.Drawing.Color.SandyBrown;
            this.btnusers.Location = new System.Drawing.Point(344, 141);
            this.btnusers.Name = "btnusers";
            this.btnusers.Size = new System.Drawing.Size(214, 45);
            this.btnusers.TabIndex = 2;
            this.btnusers.Text = "Users";
            this.btnusers.UseVisualStyleBackColor = false;
            this.btnusers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.Location = new System.Drawing.Point(34, 54);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(167, 13);
            this.lblED.TabIndex = 3;
            this.lblED.Text = "Check here for Employee Details :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Check here for users :";
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(851, 19);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 23);
            this.btnX.TabIndex = 6;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(780, 453);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 33);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnMenu);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblED);
            this.groupBox1.Controls.Add(this.btnusers);
            this.groupBox1.Controls.Add(this.btnED);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome to the Admin";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMenu.Location = new System.Drawing.Point(344, 227);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(214, 44);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu adjustment";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adjust menu :";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 530);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPage";
            this.Text = "Admin Pannel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnED;
        private System.Windows.Forms.Button btnusers;
        private System.Windows.Forms.Label lblED;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
    }
}