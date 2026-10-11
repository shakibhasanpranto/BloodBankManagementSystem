namespace BloodBankManagementSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblDepeloper = new System.Windows.Forms.Label();
            this.labelDevTitle = new System.Windows.Forms.Label();
            this.labelAppName = new System.Windows.Forms.Label();
            this.panelOpositive = new System.Windows.Forms.Panel();
            this.lblNames = new System.Windows.Forms.Label();
            this.lblOposittveCount = new System.Windows.Forms.Label();
            this.lblOpositive = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnegativeCount = new System.Windows.Forms.Label();
            this.lblOnegative = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOneativeCount = new System.Windows.Forms.Label();
            this.lblAnegetive = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApositiveCount = new System.Windows.Forms.Label();
            this.lblApositive = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblABnegativecount = new System.Windows.Forms.Label();
            this.lblABnegative = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAbpositiveCount = new System.Windows.Forms.Label();
            this.lblABpositive = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBnegativeCount = new System.Windows.Forms.Label();
            this.lblBnegative = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBpositiveCount = new System.Windows.Forms.Label();
            this.lblBpositive = new System.Windows.Forms.Label();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxCloseICon = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelOpositive.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseICon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.donorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStrip1.Size = new System.Drawing.Size(1135, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripTop";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.donorsToolStripMenuItem.Text = "Donors";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.Control;
            this.panelFooter.Controls.Add(this.lblDepeloper);
            this.panelFooter.Controls.Add(this.labelDevTitle);
            this.panelFooter.Controls.Add(this.labelAppName);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 558);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1135, 52);
            this.panelFooter.TabIndex = 1;
            this.panelFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDepeloper
            // 
            this.lblDepeloper.AutoSize = true;
            this.lblDepeloper.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepeloper.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDepeloper.Location = new System.Drawing.Point(643, 13);
            this.lblDepeloper.Name = "lblDepeloper";
            this.lblDepeloper.Size = new System.Drawing.Size(371, 30);
            this.lblDepeloper.TabIndex = 2;
            this.lblDepeloper.Text = "Students of Syeda Asrafa Islam Mam";
            this.lblDepeloper.Click += new System.EventHandler(this.lblDepeloper_Click);
            // 
            // labelDevTitle
            // 
            this.labelDevTitle.AutoSize = true;
            this.labelDevTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevTitle.ForeColor = System.Drawing.Color.Black;
            this.labelDevTitle.Location = new System.Drawing.Point(493, 13);
            this.labelDevTitle.Name = "labelDevTitle";
            this.labelDevTitle.Size = new System.Drawing.Size(154, 30);
            this.labelDevTitle.TabIndex = 1;
            this.labelDevTitle.Text = "Developed By -";
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.labelAppName.Location = new System.Drawing.Point(169, 13);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(318, 30);
            this.labelAppName.TabIndex = 0;
            this.labelAppName.Text = "Blood Bank Management System";
            // 
            // panelOpositive
            // 
            this.panelOpositive.BackColor = System.Drawing.SystemColors.Control;
            this.panelOpositive.Controls.Add(this.lblNames);
            this.panelOpositive.Controls.Add(this.lblOposittveCount);
            this.panelOpositive.Controls.Add(this.lblOpositive);
            this.panelOpositive.Location = new System.Drawing.Point(12, 87);
            this.panelOpositive.Name = "panelOpositive";
            this.panelOpositive.Size = new System.Drawing.Size(200, 100);
            this.panelOpositive.TabIndex = 2;
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblNames.Location = new System.Drawing.Point(130, 52);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(60, 21);
            this.lblNames.TabIndex = 2;
            this.lblNames.Text = "Donors";
            // 
            // lblOposittveCount
            // 
            this.lblOposittveCount.AutoSize = true;
            this.lblOposittveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOposittveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOposittveCount.Location = new System.Drawing.Point(116, 5);
            this.lblOposittveCount.Name = "lblOposittveCount";
            this.lblOposittveCount.Size = new System.Drawing.Size(77, 47);
            this.lblOposittveCount.TabIndex = 1;
            this.lblOposittveCount.Text = "100";
            // 
            // lblOpositive
            // 
            this.lblOpositive.AutoSize = true;
            this.lblOpositive.BackColor = System.Drawing.SystemColors.Control;
            this.lblOpositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOpositive.Location = new System.Drawing.Point(26, 17);
            this.lblOpositive.Name = "lblOpositive";
            this.lblOpositive.Size = new System.Drawing.Size(98, 65);
            this.lblOpositive.TabIndex = 0;
            this.lblOpositive.Text = "O+";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblOnegativeCount);
            this.panel1.Controls.Add(this.lblOnegative);
            this.panel1.Location = new System.Drawing.Point(227, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(130, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Donors";
            // 
            // lblOnegativeCount
            // 
            this.lblOnegativeCount.AutoSize = true;
            this.lblOnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOnegativeCount.Location = new System.Drawing.Point(116, 5);
            this.lblOnegativeCount.Name = "lblOnegativeCount";
            this.lblOnegativeCount.Size = new System.Drawing.Size(77, 47);
            this.lblOnegativeCount.TabIndex = 1;
            this.lblOnegativeCount.Text = "100";
            // 
            // lblOnegative
            // 
            this.lblOnegative.AutoSize = true;
            this.lblOnegative.BackColor = System.Drawing.SystemColors.Control;
            this.lblOnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOnegative.Location = new System.Drawing.Point(26, 17);
            this.lblOnegative.Name = "lblOnegative";
            this.lblOnegative.Size = new System.Drawing.Size(83, 65);
            this.lblOnegative.TabIndex = 0;
            this.lblOnegative.Text = "O-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblOneativeCount);
            this.panel2.Controls.Add(this.lblAnegetive);
            this.panel2.Location = new System.Drawing.Point(227, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(130, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Donors";
            // 
            // lblOneativeCount
            // 
            this.lblOneativeCount.AutoSize = true;
            this.lblOneativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOneativeCount.Location = new System.Drawing.Point(116, 5);
            this.lblOneativeCount.Name = "lblOneativeCount";
            this.lblOneativeCount.Size = new System.Drawing.Size(77, 47);
            this.lblOneativeCount.TabIndex = 1;
            this.lblOneativeCount.Text = "100";
            // 
            // lblAnegetive
            // 
            this.lblAnegetive.AutoSize = true;
            this.lblAnegetive.BackColor = System.Drawing.SystemColors.Control;
            this.lblAnegetive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegetive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAnegetive.Location = new System.Drawing.Point(26, 17);
            this.lblAnegetive.Name = "lblAnegetive";
            this.lblAnegetive.Size = new System.Drawing.Size(81, 65);
            this.lblAnegetive.TabIndex = 0;
            this.lblAnegetive.Text = "A-";
            this.lblAnegetive.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblApositiveCount);
            this.panel3.Controls.Add(this.lblApositive);
            this.panel3.Location = new System.Drawing.Point(12, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.label7.Location = new System.Drawing.Point(130, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Donors";
            // 
            // lblApositiveCount
            // 
            this.lblApositiveCount.AutoSize = true;
            this.lblApositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblApositiveCount.Location = new System.Drawing.Point(116, 5);
            this.lblApositiveCount.Name = "lblApositiveCount";
            this.lblApositiveCount.Size = new System.Drawing.Size(77, 47);
            this.lblApositiveCount.TabIndex = 1;
            this.lblApositiveCount.Text = "100";
            this.lblApositiveCount.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblApositive
            // 
            this.lblApositive.AutoSize = true;
            this.lblApositive.BackColor = System.Drawing.SystemColors.Control;
            this.lblApositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblApositive.Location = new System.Drawing.Point(26, 17);
            this.lblApositive.Name = "lblApositive";
            this.lblApositive.Size = new System.Drawing.Size(96, 65);
            this.lblApositive.TabIndex = 0;
            this.lblApositive.Text = "A+";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblABnegativecount);
            this.panel4.Controls.Add(this.lblABnegative);
            this.panel4.Location = new System.Drawing.Point(227, 446);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.label10.Location = new System.Drawing.Point(130, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Donors";
            // 
            // lblABnegativecount
            // 
            this.lblABnegativecount.AutoSize = true;
            this.lblABnegativecount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegativecount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABnegativecount.Location = new System.Drawing.Point(116, 5);
            this.lblABnegativecount.Name = "lblABnegativecount";
            this.lblABnegativecount.Size = new System.Drawing.Size(77, 47);
            this.lblABnegativecount.TabIndex = 1;
            this.lblABnegativecount.Text = "100";
            // 
            // lblABnegative
            // 
            this.lblABnegative.AutoSize = true;
            this.lblABnegative.BackColor = System.Drawing.SystemColors.Control;
            this.lblABnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABnegative.Location = new System.Drawing.Point(26, 17);
            this.lblABnegative.Name = "lblABnegative";
            this.lblABnegative.Size = new System.Drawing.Size(112, 65);
            this.lblABnegative.TabIndex = 0;
            this.lblABnegative.Text = "AB-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.lblAbpositiveCount);
            this.panel5.Controls.Add(this.lblABpositive);
            this.panel5.Location = new System.Drawing.Point(12, 446);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.label13.Location = new System.Drawing.Point(130, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Donors";
            // 
            // lblAbpositiveCount
            // 
            this.lblAbpositiveCount.AutoSize = true;
            this.lblAbpositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbpositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAbpositiveCount.Location = new System.Drawing.Point(120, 5);
            this.lblAbpositiveCount.Name = "lblAbpositiveCount";
            this.lblAbpositiveCount.Size = new System.Drawing.Size(77, 47);
            this.lblAbpositiveCount.TabIndex = 1;
            this.lblAbpositiveCount.Text = "100";
            this.lblAbpositiveCount.Click += new System.EventHandler(this.lblAbpositiveCount_Click);
            // 
            // lblABpositive
            // 
            this.lblABpositive.AutoSize = true;
            this.lblABpositive.BackColor = System.Drawing.SystemColors.Control;
            this.lblABpositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABpositive.Location = new System.Drawing.Point(17, 17);
            this.lblABpositive.Name = "lblABpositive";
            this.lblABpositive.Size = new System.Drawing.Size(127, 65);
            this.lblABpositive.TabIndex = 0;
            this.lblABpositive.Text = "AB+";
            this.lblABpositive.Click += new System.EventHandler(this.lblABpositive_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.lblBnegativeCount);
            this.panel6.Controls.Add(this.lblBnegative);
            this.panel6.Location = new System.Drawing.Point(227, 327);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.label16.Location = new System.Drawing.Point(130, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "Donors";
            // 
            // lblBnegativeCount
            // 
            this.lblBnegativeCount.AutoSize = true;
            this.lblBnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBnegativeCount.Location = new System.Drawing.Point(116, 5);
            this.lblBnegativeCount.Name = "lblBnegativeCount";
            this.lblBnegativeCount.Size = new System.Drawing.Size(77, 47);
            this.lblBnegativeCount.TabIndex = 1;
            this.lblBnegativeCount.Text = "100";
            // 
            // lblBnegative
            // 
            this.lblBnegative.AutoSize = true;
            this.lblBnegative.BackColor = System.Drawing.SystemColors.Control;
            this.lblBnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBnegative.Location = new System.Drawing.Point(26, 17);
            this.lblBnegative.Name = "lblBnegative";
            this.lblBnegative.Size = new System.Drawing.Size(78, 65);
            this.lblBnegative.TabIndex = 0;
            this.lblBnegative.Text = "B-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.lblBpositiveCount);
            this.panel7.Controls.Add(this.lblBpositive);
            this.panel7.Location = new System.Drawing.Point(12, 327);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.label19.Location = new System.Drawing.Point(130, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "Donors";
            // 
            // lblBpositiveCount
            // 
            this.lblBpositiveCount.AutoSize = true;
            this.lblBpositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBpositiveCount.Location = new System.Drawing.Point(120, 5);
            this.lblBpositiveCount.Name = "lblBpositiveCount";
            this.lblBpositiveCount.Size = new System.Drawing.Size(77, 47);
            this.lblBpositiveCount.TabIndex = 1;
            this.lblBpositiveCount.Text = "100";
            this.lblBpositiveCount.Click += new System.EventHandler(this.lblBpositiveCount_Click);
            // 
            // lblBpositive
            // 
            this.lblBpositive.AutoSize = true;
            this.lblBpositive.BackColor = System.Drawing.SystemColors.Control;
            this.lblBpositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBpositive.Location = new System.Drawing.Point(26, 17);
            this.lblBpositive.Name = "lblBpositive";
            this.lblBpositive.Size = new System.Drawing.Size(93, 65);
            this.lblBpositive.TabIndex = 0;
            this.lblBpositive.Text = "B+";
            // 
            // dgvDonors
            // 
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(464, 186);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.Size = new System.Drawing.Size(659, 366);
            this.dgvDonors.TabIndex = 10;
            this.dgvDonors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(460, 154);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(116, 21);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search Donors";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(592, 154);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(531, 29);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1784, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(41, 41);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 13;
            this.pictureBoxClose.TabStop = false;
            // 
            // pictureBoxCloseICon
            // 
            this.pictureBoxCloseICon.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxCloseICon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCloseICon.Image")));
            this.pictureBoxCloseICon.Location = new System.Drawing.Point(1091, 0);
            this.pictureBoxCloseICon.Name = "pictureBoxCloseICon";
            this.pictureBoxCloseICon.Size = new System.Drawing.Size(44, 41);
            this.pictureBoxCloseICon.TabIndex = 14;
            this.pictureBoxCloseICon.TabStop = false;
            this.pictureBoxCloseICon.Click += new System.EventHandler(this.pictureBoxCloseICon_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1135, 610);
            this.Controls.Add(this.pictureBoxCloseICon);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvDonors);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOpositive);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelOpositive.ResumeLayout(false);
            this.panelOpositive.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseICon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label lblDepeloper;
        private System.Windows.Forms.Label labelDevTitle;
        private System.Windows.Forms.Panel panelOpositive;
        private System.Windows.Forms.Label lblOpositive;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblOposittveCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnegativeCount;
        private System.Windows.Forms.Label lblOnegative;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOneativeCount;
        private System.Windows.Forms.Label lblAnegetive;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApositiveCount;
        private System.Windows.Forms.Label lblApositive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblABnegativecount;
        private System.Windows.Forms.Label lblABnegative;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAbpositiveCount;
        private System.Windows.Forms.Label lblABpositive;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBnegativeCount;
        private System.Windows.Forms.Label lblBnegative;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBpositiveCount;
        private System.Windows.Forms.Label lblBpositive;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxCloseICon;
    }
}

