namespace Project.Presentation
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.modlink = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mods = new System.Windows.Forms.TextBox();
            this.codes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.dobt = new System.Windows.Forms.TextBox();
            this.stdname = new System.Windows.Forms.TextBox();
            this.stdsname = new System.Windows.Forms.TextBox();
            this.StdNum = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.search);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(584, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 45);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(22, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Enter Student Number:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(180, 18);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(208, 20);
            this.search.TabIndex = 9;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(422, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(584, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 273);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(584, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 68);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(422, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(291, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Remove Student";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update Information";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.desc);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.modlink);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.mods);
            this.groupBox1.Controls.Add(this.codes);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.gen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.Phone);
            this.groupBox1.Controls.Add(this.dobt);
            this.groupBox1.Controls.Add(this.stdname);
            this.groupBox1.Controls.Add(this.stdsname);
            this.groupBox1.Controls.Add(this.StdNum);
            this.groupBox1.Location = new System.Drawing.Point(8, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 390);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(298, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Module Link:";
            // 
            // modlink
            // 
            this.modlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.modlink.Location = new System.Drawing.Point(380, 181);
            this.modlink.Name = "modlink";
            this.modlink.Size = new System.Drawing.Size(171, 21);
            this.modlink.TabIndex = 29;
            this.modlink.TextChanged += new System.EventHandler(this.modlink_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Module Name:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Module Description:";
            // 
            // mods
            // 
            this.mods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mods.Location = new System.Drawing.Point(110, 258);
            this.mods.Name = "mods";
            this.mods.Size = new System.Drawing.Size(171, 21);
            this.mods.TabIndex = 26;
            this.mods.TextChanged += new System.EventHandler(this.mods_TextChanged);
            // 
            // codes
            // 
            this.codes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.codes.Location = new System.Drawing.Point(111, 215);
            this.codes.Name = "codes";
            this.codes.Size = new System.Drawing.Size(171, 21);
            this.codes.TabIndex = 25;
            this.codes.TextChanged += new System.EventHandler(this.codes_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Image:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(377, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 141);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(53, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Gender:";
            // 
            // gen
            // 
            this.gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gen.FormattingEnabled = true;
            this.gen.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.gen.Location = new System.Drawing.Point(111, 132);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(121, 23);
            this.gen.TabIndex = 9;
            this.gen.SelectedIndexChanged += new System.EventHandler(this.gen_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Module Codes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(334, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(56, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(301, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date ofBirth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(315, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(60, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(5, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student Number:";
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Address.Location = new System.Drawing.Point(110, 175);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(171, 21);
            this.Address.TabIndex = 6;
            this.Address.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Phone.Location = new System.Drawing.Point(381, 134);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(171, 21);
            this.Phone.TabIndex = 5;
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            // 
            // dobt
            // 
            this.dobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dobt.Location = new System.Drawing.Point(380, 91);
            this.dobt.Name = "dobt";
            this.dobt.Size = new System.Drawing.Size(175, 21);
            this.dobt.TabIndex = 4;
            this.dobt.TextChanged += new System.EventHandler(this.dobt_TextChanged);
            // 
            // stdname
            // 
            this.stdname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.stdname.Location = new System.Drawing.Point(110, 91);
            this.stdname.Name = "stdname";
            this.stdname.Size = new System.Drawing.Size(175, 21);
            this.stdname.TabIndex = 3;
            this.stdname.TextChanged += new System.EventHandler(this.stdname_TextChanged);
            // 
            // stdsname
            // 
            this.stdsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.stdsname.Location = new System.Drawing.Point(381, 51);
            this.stdsname.Name = "stdsname";
            this.stdsname.Size = new System.Drawing.Size(175, 21);
            this.stdsname.TabIndex = 2;
            this.stdsname.TextChanged += new System.EventHandler(this.stdsname_TextChanged);
            // 
            // StdNum
            // 
            this.StdNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.StdNum.Location = new System.Drawing.Point(111, 51);
            this.StdNum.Name = "StdNum";
            this.StdNum.Size = new System.Drawing.Size(175, 21);
            this.StdNum.TabIndex = 0;
            this.StdNum.TextChanged += new System.EventHandler(this.StdNum_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(438, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(333, 121);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(526, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 39);
            this.button6.TabIndex = 31;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // desc
            // 
            this.desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.desc.Location = new System.Drawing.Point(108, 299);
            this.desc.Name = "desc";
            this.desc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.desc.Size = new System.Drawing.Size(171, 21);
            this.desc.TabIndex = 32;
            this.desc.TextChanged += new System.EventHandler(this.desc_TextChanged);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1154, 531);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox gen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox dobt;
        private System.Windows.Forms.TextBox stdname;
        private System.Windows.Forms.TextBox stdsname;
        private System.Windows.Forms.TextBox StdNum;
        private System.Windows.Forms.TextBox codes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mods;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox modlink;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox desc;
    }
}