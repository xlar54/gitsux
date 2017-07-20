namespace Gitsux
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWorkingDirectory = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListUntracked = new System.Windows.Forms.Button();
            this.btnDisplayLog = new System.Windows.Forms.Button();
            this.btnListBranches = new System.Windows.Forms.Button();
            this.btnCreateBranch = new System.Windows.Forms.Button();
            this.btnChangeBranches = new System.Windows.Forms.Button();
            this.lblCurrentBranch = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteBranch = new System.Windows.Forms.Button();
            this.btnMergeBranch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUndoCheckIn = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 498);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1103, 143);
            this.textBox1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(8, 115);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(108, 44);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Create a new repository";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Working Directory:";
            // 
            // lblWorkingDirectory
            // 
            this.lblWorkingDirectory.AutoSize = true;
            this.lblWorkingDirectory.Location = new System.Drawing.Point(108, 9);
            this.lblWorkingDirectory.Name = "lblWorkingDirectory";
            this.lblWorkingDirectory.Size = new System.Drawing.Size(62, 13);
            this.lblWorkingDirectory.TabIndex = 6;
            this.lblWorkingDirectory.Text = "Not defined";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(776, 65);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(111, 44);
            this.btnStatus.TabIndex = 7;
            this.btnStatus.Text = "Get Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(8, 65);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(108, 44);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open Exiting Repository";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(454, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Commit staged changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnListUntracked
            // 
            this.btnListUntracked.Location = new System.Drawing.Point(236, 65);
            this.btnListUntracked.Name = "btnListUntracked";
            this.btnListUntracked.Size = new System.Drawing.Size(108, 44);
            this.btnListUntracked.TabIndex = 11;
            this.btnListUntracked.Text = "List untracked (new) files";
            this.btnListUntracked.UseVisualStyleBackColor = true;
            this.btnListUntracked.Click += new System.EventHandler(this.btnListUntracked_Click);
            // 
            // btnDisplayLog
            // 
            this.btnDisplayLog.Location = new System.Drawing.Point(776, 115);
            this.btnDisplayLog.Name = "btnDisplayLog";
            this.btnDisplayLog.Size = new System.Drawing.Size(111, 44);
            this.btnDisplayLog.TabIndex = 12;
            this.btnDisplayLog.Text = "Display Log For Current Branch";
            this.btnDisplayLog.UseVisualStyleBackColor = true;
            this.btnDisplayLog.Click += new System.EventHandler(this.btnDisplayLog_Click);
            // 
            // btnListBranches
            // 
            this.btnListBranches.Location = new System.Drawing.Point(122, 165);
            this.btnListBranches.Name = "btnListBranches";
            this.btnListBranches.Size = new System.Drawing.Size(108, 44);
            this.btnListBranches.TabIndex = 13;
            this.btnListBranches.Text = "List local branches";
            this.btnListBranches.UseVisualStyleBackColor = true;
            this.btnListBranches.Click += new System.EventHandler(this.btnListBranches_Click);
            // 
            // btnCreateBranch
            // 
            this.btnCreateBranch.Location = new System.Drawing.Point(122, 65);
            this.btnCreateBranch.Name = "btnCreateBranch";
            this.btnCreateBranch.Size = new System.Drawing.Size(108, 44);
            this.btnCreateBranch.TabIndex = 14;
            this.btnCreateBranch.Text = "Create branch";
            this.btnCreateBranch.UseVisualStyleBackColor = true;
            this.btnCreateBranch.Click += new System.EventHandler(this.btnCreateBranch_Click);
            // 
            // btnChangeBranches
            // 
            this.btnChangeBranches.Location = new System.Drawing.Point(122, 115);
            this.btnChangeBranches.Name = "btnChangeBranches";
            this.btnChangeBranches.Size = new System.Drawing.Size(108, 44);
            this.btnChangeBranches.TabIndex = 15;
            this.btnChangeBranches.Text = "Change branches";
            this.btnChangeBranches.UseVisualStyleBackColor = true;
            this.btnChangeBranches.Click += new System.EventHandler(this.btnChangeBranches_Click);
            // 
            // lblCurrentBranch
            // 
            this.lblCurrentBranch.AutoSize = true;
            this.lblCurrentBranch.Location = new System.Drawing.Point(553, 9);
            this.lblCurrentBranch.Name = "lblCurrentBranch";
            this.lblCurrentBranch.Size = new System.Drawing.Size(62, 13);
            this.lblCurrentBranch.TabIndex = 17;
            this.lblCurrentBranch.Text = "Not defined";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Current branch:";
            // 
            // btnDeleteBranch
            // 
            this.btnDeleteBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteBranch.Location = new System.Drawing.Point(122, 265);
            this.btnDeleteBranch.Name = "btnDeleteBranch";
            this.btnDeleteBranch.Size = new System.Drawing.Size(108, 44);
            this.btnDeleteBranch.TabIndex = 18;
            this.btnDeleteBranch.Text = "Delete a branch";
            this.btnDeleteBranch.UseVisualStyleBackColor = false;
            this.btnDeleteBranch.Click += new System.EventHandler(this.btnDeleteBranch_Click);
            // 
            // btnMergeBranch
            // 
            this.btnMergeBranch.Location = new System.Drawing.Point(122, 315);
            this.btnMergeBranch.Name = "btnMergeBranch";
            this.btnMergeBranch.Size = new System.Drawing.Size(108, 44);
            this.btnMergeBranch.TabIndex = 19;
            this.btnMergeBranch.Text = "Merge with a branch";
            this.btnMergeBranch.UseVisualStyleBackColor = true;
            this.btnMergeBranch.Click += new System.EventHandler(this.btnMergeBranch_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(350, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 44);
            this.button3.TabIndex = 22;
            this.button3.Text = "Stage all for commit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(349, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 44);
            this.button4.TabIndex = 23;
            this.button4.Text = "List uncommited (staged) files";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(236, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 44);
            this.button5.TabIndex = 24;
            this.button5.Text = "List tracked changed files";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Location = new System.Drawing.Point(349, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 44);
            this.button6.TabIndex = 25;
            this.button6.Text = "Stage specific file for commit";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(454, 265);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 44);
            this.button7.TabIndex = 26;
            this.button7.Text = "List commited files";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button8.Location = new System.Drawing.Point(350, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 44);
            this.button8.TabIndex = 27;
            this.button8.Text = "Unstage all files";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Branching";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(7, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 40);
            this.panel1.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(679, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Checkout";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Repo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Workspace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Staging / Index";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Local Repo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(803, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Info";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button9.Location = new System.Drawing.Point(349, 215);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 44);
            this.button9.TabIndex = 32;
            this.button9.Text = "Unstage specific file";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(776, 165);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(111, 44);
            this.button10.TabIndex = 34;
            this.button10.Text = "Display short log for current branch";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(670, 65);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(97, 44);
            this.button11.TabIndex = 35;
            this.button11.Text = "Checkout specific commit";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(454, 315);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(97, 44);
            this.button12.TabIndex = 36;
            this.button12.Text = "Tag this commit";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(776, 215);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(111, 44);
            this.button13.TabIndex = 37;
            this.button13.Text = "Show all tags";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(670, 115);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(97, 44);
            this.button14.TabIndex = 38;
            this.button14.Text = "Checkout latest file";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(670, 165);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(97, 44);
            this.button15.TabIndex = 39;
            this.button15.Text = "Undo checkout";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(557, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 94);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.Text = "Lose history";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Keep history";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(454, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 44);
            this.button2.TabIndex = 42;
            this.button2.Text = "Revert to specific commit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUndoCheckIn
            // 
            this.btnUndoCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUndoCheckIn.Location = new System.Drawing.Point(454, 165);
            this.btnUndoCheckIn.Name = "btnUndoCheckIn";
            this.btnUndoCheckIn.Size = new System.Drawing.Size(97, 44);
            this.btnUndoCheckIn.TabIndex = 41;
            this.btnUndoCheckIn.Text = "Revert to last commit";
            this.btnUndoCheckIn.UseVisualStyleBackColor = false;
            this.btnUndoCheckIn.Click += new System.EventHandler(this.btnUndoCheckIn_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(235, 215);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(108, 44);
            this.button16.TabIndex = 43;
            this.button16.Text = "Stash changes";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(233, 365);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(108, 44);
            this.button17.TabIndex = 44;
            this.button17.Text = "List stashes";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(234, 265);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(108, 44);
            this.button18.TabIndex = 45;
            this.button18.Text = "Apply stash";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(234, 415);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(108, 44);
            this.button19.TabIndex = 46;
            this.button19.Text = "Delete stash";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(233, 315);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(108, 44);
            this.button20.TabIndex = 47;
            this.button20.Text = "Apply and drop stash";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(236, 165);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(108, 44);
            this.button21.TabIndex = 48;
            this.button21.Text = "Untrack a file";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button22.Location = new System.Drawing.Point(454, 115);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(97, 44);
            this.button22.TabIndex = 49;
            this.button22.Text = "Amend latest commit";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(902, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Remote";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(893, 215);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(97, 44);
            this.button23.TabIndex = 50;
            this.button23.Text = "List remotes";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(893, 315);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(97, 44);
            this.button24.TabIndex = 51;
            this.button24.Text = "Create remote";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button25.Location = new System.Drawing.Point(893, 115);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(97, 44);
            this.button25.TabIndex = 52;
            this.button25.Text = "Fetch from remote";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button26.Location = new System.Drawing.Point(893, 65);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(97, 44);
            this.button26.TabIndex = 53;
            this.button26.Text = "Push to remote";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(893, 265);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(97, 44);
            this.button27.TabIndex = 54;
            this.button27.Text = "Show detail";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(893, 365);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(97, 44);
            this.button28.TabIndex = 55;
            this.button28.Text = "Rename remote";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(893, 415);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(97, 44);
            this.button29.TabIndex = 56;
            this.button29.Text = "Delete remote";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(8, 165);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(108, 44);
            this.button30.TabIndex = 57;
            this.button30.Text = "Clone a remote repository";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Manual:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 472);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(388, 20);
            this.textBox2.TabIndex = 59;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(452, 472);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(78, 20);
            this.button31.TabIndex = 60;
            this.button31.Text = "Execute";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(122, 215);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(108, 44);
            this.button32.TabIndex = 61;
            this.button32.Text = "List local and remote branches";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(1013, 183);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(97, 50);
            this.button33.TabIndex = 62;
            this.button33.Text = "local vs remote branch";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1022, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Compare";
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button34.Location = new System.Drawing.Point(893, 165);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(97, 44);
            this.button34.TabIndex = 63;
            this.button34.Text = "Pull from remote (includes merge)";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(1012, 127);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(97, 50);
            this.button35.TabIndex = 64;
            this.button35.Text = "workspace vs local repo";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(1012, 71);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(97, 50);
            this.button36.TabIndex = 65;
            this.button36.Text = "workspace vs staging";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 650);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUndoCheckIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMergeBranch);
            this.Controls.Add(this.btnDeleteBranch);
            this.Controls.Add(this.lblCurrentBranch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChangeBranches);
            this.Controls.Add(this.btnCreateBranch);
            this.Controls.Add(this.btnListBranches);
            this.Controls.Add(this.btnDisplayLog);
            this.Controls.Add(this.btnListUntracked);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.lblWorkingDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Gitsux";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWorkingDirectory;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListUntracked;
        private System.Windows.Forms.Button btnDisplayLog;
        private System.Windows.Forms.Button btnListBranches;
        private System.Windows.Forms.Button btnCreateBranch;
        private System.Windows.Forms.Button btnChangeBranches;
        private System.Windows.Forms.Label lblCurrentBranch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteBranch;
        private System.Windows.Forms.Button btnMergeBranch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUndoCheckIn;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
    }
}

