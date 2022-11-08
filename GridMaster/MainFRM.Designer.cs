namespace GridMaster
{
    partial class MainFRM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numCols = new System.Windows.Forms.NumericUpDown();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtWhiteExt = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioCBlack = new System.Windows.Forms.RadioButton();
            this.radioBlack = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtText.Location = new System.Drawing.Point(3, 19);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(768, 50);
            this.txtText.TabIndex = 0;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            this.txtText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text to Display";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numRows);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numCols);
            this.groupBox2.Location = new System.Drawing.Point(474, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Windows Explorer Icon Resolution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "icons";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of rows:";
            // 
            // numRows
            // 
            this.numRows.Location = new System.Drawing.Point(178, 51);
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(54, 23);
            this.numRows.TabIndex = 3;
            this.numRows.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numRows.ValueChanged += new System.EventHandler(this.numRows_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "icons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of columns:";
            // 
            // numCols
            // 
            this.numCols.Location = new System.Drawing.Point(178, 26);
            this.numCols.Name = "numCols";
            this.numCols.Size = new System.Drawing.Size(54, 23);
            this.numCols.TabIndex = 0;
            this.numCols.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numCols.ValueChanged += new System.EventHandler(this.numCols_ValueChanged);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColor = System.Drawing.Color.Cornsilk;
            this.btnOpenFolder.Location = new System.Drawing.Point(6, 51);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(278, 29);
            this.btnOpenFolder.TabIndex = 3;
            this.btnOpenFolder.Text = "📂  Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnPre);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Controls.Add(this.btnPause);
            this.groupBox3.Controls.Add(this.btnPlay);
            this.groupBox3.Location = new System.Drawing.Point(474, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 84);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Media Control";
            // 
            // btnPre
            // 
            this.btnPre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPre.Location = new System.Drawing.Point(37, 29);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(49, 43);
            this.btnPre.TabIndex = 4;
            this.btnPre.Text = "⏮️";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(202, 29);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 43);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "⏭️";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Khaki;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPause.Location = new System.Drawing.Point(147, 29);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(49, 43);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "⏸️";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(92, 29);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(49, 43);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "▶️";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtPath);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnOpenFolder);
            this.groupBox4.Location = new System.Drawing.Point(474, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 90);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Folder Path";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(6, 22);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(237, 23);
            this.txtPath.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnMin);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(14, 363);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(453, 132);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Icons Options";
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(14, 90);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(206, 32);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "Minimize";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtWhiteExt);
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Controls.Add(this.radioButton2);
            this.groupBox7.Location = new System.Drawing.Point(229, 15);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(206, 69);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "White Icon";
            // 
            // txtWhiteExt
            // 
            this.txtWhiteExt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWhiteExt.Location = new System.Drawing.Point(97, 23);
            this.txtWhiteExt.Name = "txtWhiteExt";
            this.txtWhiteExt.Size = new System.Drawing.Size(100, 33);
            this.txtWhiteExt.TabIndex = 2;
            this.txtWhiteExt.Text = "blah";
            this.txtWhiteExt.Click += new System.EventHandler(this.txtWhiteExt_Click);
            this.txtWhiteExt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWhiteExt_KeyUp);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Custom";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 19);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "white.txt";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.apply);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.radioCBlack);
            this.groupBox6.Controls.Add(this.radioBlack);
            this.groupBox6.Location = new System.Drawing.Point(6, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(217, 69);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Black Icon";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(102, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 33);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "HTML";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // radioCBlack
            // 
            this.radioCBlack.AutoSize = true;
            this.radioCBlack.Location = new System.Drawing.Point(8, 44);
            this.radioCBlack.Name = "radioCBlack";
            this.radioCBlack.Size = new System.Drawing.Size(67, 19);
            this.radioCBlack.TabIndex = 1;
            this.radioCBlack.Text = "Custom";
            this.radioCBlack.UseVisualStyleBackColor = true;
            this.radioCBlack.CheckedChanged += new System.EventHandler(this.radioCBlack_CheckedChanged);
            // 
            // radioBlack
            // 
            this.radioBlack.AutoSize = true;
            this.radioBlack.Checked = true;
            this.radioBlack.Location = new System.Drawing.Point(8, 22);
            this.radioBlack.Name = "radioBlack";
            this.radioBlack.Size = new System.Drawing.Size(73, 19);
            this.radioBlack.TabIndex = 0;
            this.radioBlack.TabStop = true;
            this.radioBlack.Text = "black.jpg";
            this.radioBlack.UseVisualStyleBackColor = true;
            this.radioBlack.CheckedChanged += new System.EventHandler(this.radioBlack_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.txtPreview);
            this.groupBox8.Location = new System.Drawing.Point(12, 89);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(456, 204);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Preview";
            // 
            // txtPreview
            // 
            this.txtPreview.BackColor = System.Drawing.Color.Black;
            this.txtPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreview.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPreview.ForeColor = System.Drawing.Color.Lime;
            this.txtPreview.Location = new System.Drawing.Point(3, 19);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPreview.Size = new System.Drawing.Size(450, 182);
            this.txtPreview.TabIndex = 0;
            this.txtPreview.Text = "$";
            this.txtPreview.WordWrap = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.button6);
            this.groupBox9.Controls.Add(this.button5);
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Location = new System.Drawing.Point(473, 415);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(290, 81);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Designer";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(148, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 29);
            this.button6.TabIndex = 7;
            this.button6.Text = "💿 Save Drawing";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button5.Location = new System.Drawing.Point(5, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(278, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "✏️ Paint";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "📂Open Drawing";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnClock
            // 
            this.btnClock.Location = new System.Drawing.Point(288, 20);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(147, 29);
            this.btnClock.TabIndex = 10;
            this.btnClock.Text = "⌚ DIGITAL CLOCK ";
            this.btnClock.UseVisualStyleBackColor = false;
            this.btnClock.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button3);
            this.groupBox10.Controls.Add(this.btnClock);
            this.groupBox10.Location = new System.Drawing.Point(14, 299);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(451, 61);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Special";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "🎮 Games";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 500);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.KeyPreview = true;
            this.Name = "MainFRM";
            this.Opacity = 0.95D;
            this.Text = "PEYMANx Grid Master";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainFRM_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFRM_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtText;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private NumericUpDown numRows;
        private Label label2;
        private Label label1;
        private NumericUpDown numCols;
        private Button btnOpenFolder;
        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox groupBox3;
        private Button btnPre;
        private Button btnNext;
        private Button btnPause;
        private Button btnPlay;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private GroupBox groupBox4;
        private TextBox txtPath;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private TextBox textBox1;
        private RadioButton radioCBlack;
        private RadioButton radioBlack;
        private Button button2;
        private GroupBox groupBox7;
        private TextBox txtWhiteExt;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox8;
        private TextBox txtPreview;
        private Button btnMin;
        private GroupBox groupBox9;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button btnClock;
        private GroupBox groupBox10;
        private Button button3;
    }
}