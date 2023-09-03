namespace GridMaster
{
    partial class HandDrawing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandDrawing));
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtWhiteExt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.numCols = new System.Windows.Forms.NumericUpDown();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClock = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtText.Location = new System.Drawing.Point(19, 48);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(642, 34);
            this.txtText.TabIndex = 1;
            this.txtText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyUp);
            // 
            // txtPreview
            // 
            this.txtPreview.BackColor = System.Drawing.Color.Black;
            this.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreview.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPreview.ForeColor = System.Drawing.Color.Lime;
            this.txtPreview.Location = new System.Drawing.Point(24, 155);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.Size = new System.Drawing.Size(374, 148);
            this.txtPreview.TabIndex = 3;
            this.txtPreview.Text = "$";
            this.txtPreview.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(647, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(581, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 36);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Location = new System.Drawing.Point(561, 114);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(40, 39);
            this.btnPause.TabIndex = 14;
            this.btnPause.TabStop = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // txtBlue
            // 
            this.txtBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBlue.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBlue.Location = new System.Drawing.Point(180, 375);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(50, 34);
            this.txtBlue.TabIndex = 19;
            this.txtBlue.Text = "all";
            this.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGreen
            // 
            this.txtGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGreen.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGreen.Location = new System.Drawing.Point(254, 365);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(51, 34);
            this.txtGreen.TabIndex = 17;
            this.txtGreen.Text = "xlsx";
            this.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRed
            // 
            this.txtRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRed.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRed.Location = new System.Drawing.Point(336, 377);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(60, 34);
            this.txtRed.TabIndex = 18;
            this.txtRed.Text = "pdf";
            this.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWhiteExt
            // 
            this.txtWhiteExt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWhiteExt.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWhiteExt.Location = new System.Drawing.Point(104, 376);
            this.txtWhiteExt.Name = "txtWhiteExt";
            this.txtWhiteExt.Size = new System.Drawing.Size(54, 34);
            this.txtWhiteExt.TabIndex = 15;
            this.txtWhiteExt.Text = "txt";
            this.txtWhiteExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(14, 381);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 34);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "jpg";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(9, 453);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(239, 36);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // numCols
            // 
            this.numCols.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCols.Font = new System.Drawing.Font("Mj_Parand", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numCols.Location = new System.Drawing.Point(481, 236);
            this.numCols.Name = "numCols";
            this.numCols.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numCols.Size = new System.Drawing.Size(66, 51);
            this.numCols.TabIndex = 21;
            this.numCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCols.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numCols.ValueChanged += new System.EventHandler(this.numCols_ValueChanged);
            // 
            // numRows
            // 
            this.numRows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numRows.Font = new System.Drawing.Font("Mj_Parand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numRows.Location = new System.Drawing.Point(497, 305);
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(64, 48);
            this.numRows.TabIndex = 9;
            this.numRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRows.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numRows.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numRows.ValueChanged += new System.EventHandler(this.numRows_ValueChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(440, 456);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(239, 36);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnClock
            // 
            this.btnClock.BackColor = System.Drawing.Color.Transparent;
            this.btnClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClock.Location = new System.Drawing.Point(283, 452);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(125, 36);
            this.btnClock.TabIndex = 23;
            this.btnClock.TabStop = false;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(620, 115);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 39);
            this.btnNext.TabIndex = 24;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(641, 391);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 39);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(596, 391);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 39);
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // txtPath
            // 
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(448, 401);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(142, 16);
            this.txtPath.TabIndex = 27;
            // 
            // HandDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 501);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.numRows);
            this.Controls.Add(this.numCols);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.txtWhiteExt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.txtText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HandDrawing";
            this.Text = "HandDrawing";
            this.Load += new System.EventHandler(this.HandDrawing_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandDrawing_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandDrawing_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandDrawing_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtText;
        private TextBox txtPreview;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private FolderBrowserDialog folderBrowserDialog1;
        private PictureBox btnPause;
        private TextBox txtBlue;
        private TextBox txtGreen;
        private TextBox txtRed;
        private TextBox txtWhiteExt;
        private TextBox textBox3;
        private PictureBox pictureBox3;
        private NumericUpDown numCols;
        private NumericUpDown numRows;
        private PictureBox pictureBox4;
        private PictureBox btnClock;
        private PictureBox btnNext;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox txtPath;
    }
}