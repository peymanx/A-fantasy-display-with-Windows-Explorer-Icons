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
            this.txtBlack = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.numCols = new System.Windows.Forms.NumericUpDown();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.PictureBox();
            this.btnClock = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اتصالبهوبکمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.بازکردنفایلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ذخیرهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نسخهمدرنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پاکسازیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ساعتدیجیتالToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازیهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.باقیماندنرویصفحهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMin = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سورسپروژهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهبرنامهنویسToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnPre = new System.Windows.Forms.PictureBox();
            this.lblNim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtText.Location = new System.Drawing.Point(75, 105);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(642, 29);
            this.txtText.TabIndex = 1;
            this.txtText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyUp);
            // 
            // txtPreview
            // 
            this.txtPreview.BackColor = System.Drawing.Color.Black;
            this.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreview.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPreview.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtPreview.Location = new System.Drawing.Point(79, 208);
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
            this.pictureBox1.Image = global::GridMaster.Properties.Resources.btnClose;
            this.pictureBox1.Location = new System.Drawing.Point(697, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(628, 22);
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
            this.btnPause.Location = new System.Drawing.Point(617, 168);
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
            this.txtBlue.Location = new System.Drawing.Point(236, 426);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(50, 34);
            this.txtBlue.TabIndex = 19;
            this.txtBlue.Text = "all";
            this.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBlue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBlue_KeyUp);
            // 
            // txtGreen
            // 
            this.txtGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGreen.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGreen.Location = new System.Drawing.Point(400, 427);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(51, 34);
            this.txtGreen.TabIndex = 17;
            this.txtGreen.Text = "xlsx";
            this.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGreen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGreen_KeyUp);
            // 
            // txtRed
            // 
            this.txtRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRed.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRed.Location = new System.Drawing.Point(315, 411);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(51, 34);
            this.txtRed.TabIndex = 18;
            this.txtRed.Text = "pdf";
            this.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRed_KeyUp);
            // 
            // txtWhiteExt
            // 
            this.txtWhiteExt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWhiteExt.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWhiteExt.Location = new System.Drawing.Point(160, 426);
            this.txtWhiteExt.Name = "txtWhiteExt";
            this.txtWhiteExt.Size = new System.Drawing.Size(54, 34);
            this.txtWhiteExt.TabIndex = 15;
            this.txtWhiteExt.Text = "txt";
            this.txtWhiteExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWhiteExt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWhiteExt_KeyUp);
            // 
            // txtBlack
            // 
            this.txtBlack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBlack.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBlack.Location = new System.Drawing.Point(70, 434);
            this.txtBlack.Name = "txtBlack";
            this.txtBlack.Size = new System.Drawing.Size(56, 34);
            this.txtBlack.TabIndex = 16;
            this.txtBlack.Text = "jpg";
            this.txtBlack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBlack.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::GridMaster.Properties.Resources.btnPaint;
            this.pictureBox3.Location = new System.Drawing.Point(49, 487);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // numCols
            // 
            this.numCols.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCols.Font = new System.Drawing.Font("Mj_Parand", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numCols.Location = new System.Drawing.Point(535, 287);
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
            this.numRows.Location = new System.Drawing.Point(548, 356);
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = global::GridMaster.Properties.Resources.update_normal;
            this.btnUpdate.Location = new System.Drawing.Point(464, 487);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(276, 56);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Click += new System.EventHandler(this.pictureBox4_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            this.btnUpdate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnUpdate_MouseMove);
            // 
            // btnClock
            // 
            this.btnClock.BackColor = System.Drawing.Color.Transparent;
            this.btnClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClock.Image = global::GridMaster.Properties.Resources.btnClock_hover2;
            this.btnClock.Location = new System.Drawing.Point(272, 487);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(129, 51);
            this.btnClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClock.TabIndex = 23;
            this.btnClock.TabStop = false;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            this.btnClock.MouseLeave += new System.EventHandler(this.btnClock_MouseLeave);
            this.btnClock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnClock_MouseMove);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Image = global::GridMaster.Properties.Resources.btnNext;
            this.btnNext.Location = new System.Drawing.Point(661, 158);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(61, 65);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnNext.TabIndex = 24;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseDown);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(684, 432);
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
            this.pictureBox6.Location = new System.Drawing.Point(642, 432);
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
            this.txtPath.Location = new System.Drawing.Point(504, 445);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(142, 16);
            this.txtPath.TabIndex = 27;
            this.txtPath.MouseHover += new System.EventHandler(this.txtPath_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Mj_Parand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(52, 59);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 34);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اتصالبهوبکمToolStripMenuItem,
            this.toolStripMenuItem2,
            this.بازکردنفایلToolStripMenuItem,
            this.ذخیرهToolStripMenuItem,
            this.toolStripMenuItem1,
            this.خروجToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fileToolStripMenuItem.Text = "فایل";
            // 
            // اتصالبهوبکمToolStripMenuItem
            // 
            this.اتصالبهوبکمToolStripMenuItem.Name = "اتصالبهوبکمToolStripMenuItem";
            this.اتصالبهوبکمToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.اتصالبهوبکمToolStripMenuItem.Text = "...اتصال به وبکم";
            this.اتصالبهوبکمToolStripMenuItem.Click += new System.EventHandler(this.اتصالبهوبکمToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 6);
            // 
            // بازکردنفایلToolStripMenuItem
            // 
            this.بازکردنفایلToolStripMenuItem.Name = "بازکردنفایلToolStripMenuItem";
            this.بازکردنفایلToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.بازکردنفایلToolStripMenuItem.Text = "بازکردن";
            this.بازکردنفایلToolStripMenuItem.Click += new System.EventHandler(this.بازکردنفایلToolStripMenuItem_Click);
            // 
            // ذخیرهToolStripMenuItem
            // 
            this.ذخیرهToolStripMenuItem.Name = "ذخیرهToolStripMenuItem";
            this.ذخیرهToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.ذخیرهToolStripMenuItem.Text = "ذخیره";
            this.ذخیرهToolStripMenuItem.Click += new System.EventHandler(this.ذخیرهToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.نسخهمدرنToolStripMenuItem,
            this.پاکسازیToolStripMenuItem,
            this.ساعتدیجیتالToolStripMenuItem,
            this.بازیهاToolStripMenuItem,
            this.toolStripMenuItem4,
            this.باقیماندنرویصفحهToolStripMenuItem,
            this.btnMin});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(63, 30);
            this.editToolStripMenuItem.Text = "ابزارها";
            // 
            // نسخهمدرنToolStripMenuItem
            // 
            this.نسخهمدرنToolStripMenuItem.Name = "نسخهمدرنToolStripMenuItem";
            this.نسخهمدرنToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.نسخهمدرنToolStripMenuItem.Text = "نسخه مدرن";
            this.نسخهمدرنToolStripMenuItem.Click += new System.EventHandler(this.نسخهمدرنToolStripMenuItem_Click);
            // 
            // پاکسازیToolStripMenuItem
            // 
            this.پاکسازیToolStripMenuItem.Name = "پاکسازیToolStripMenuItem";
            this.پاکسازیToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.پاکسازیToolStripMenuItem.Text = "پاک سازی";
            this.پاکسازیToolStripMenuItem.Click += new System.EventHandler(this.پاکسازیToolStripMenuItem_Click);
            // 
            // ساعتدیجیتالToolStripMenuItem
            // 
            this.ساعتدیجیتالToolStripMenuItem.Name = "ساعتدیجیتالToolStripMenuItem";
            this.ساعتدیجیتالToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.ساعتدیجیتالToolStripMenuItem.Text = "ساعت دیجیتال";
            this.ساعتدیجیتالToolStripMenuItem.Click += new System.EventHandler(this.ساعتدیجیتالToolStripMenuItem_Click);
            // 
            // بازیهاToolStripMenuItem
            // 
            this.بازیهاToolStripMenuItem.Name = "بازیهاToolStripMenuItem";
            this.بازیهاToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.بازیهاToolStripMenuItem.Text = "بازی ها";
            this.بازیهاToolStripMenuItem.Click += new System.EventHandler(this.بازیهاToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(220, 6);
            // 
            // باقیماندنرویصفحهToolStripMenuItem
            // 
            this.باقیماندنرویصفحهToolStripMenuItem.Checked = true;
            this.باقیماندنرویصفحهToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.باقیماندنرویصفحهToolStripMenuItem.Name = "باقیماندنرویصفحهToolStripMenuItem";
            this.باقیماندنرویصفحهToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.باقیماندنرویصفحهToolStripMenuItem.Text = "باقی ماندن روی صفحه";
            this.باقیماندنرویصفحهToolStripMenuItem.Click += new System.EventHandler(this.باقیماندنرویصفحهToolStripMenuItem_Click);
            // 
            // btnMin
            // 
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(223, 34);
            this.btnMin.Text = "کوچولو شو";
            this.btnMin.Click += new System.EventHandler(this.کوچولوشوToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.سورسپروژهToolStripMenuItem,
            this.دربارهبرنامهنویسToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 30);
            this.helpToolStripMenuItem.Text = "کمک";
            // 
            // سورسپروژهToolStripMenuItem
            // 
            this.سورسپروژهToolStripMenuItem.Name = "سورسپروژهToolStripMenuItem";
            this.سورسپروژهToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.سورسپروژهToolStripMenuItem.Text = "سورس پروژه";
            // 
            // دربارهبرنامهنویسToolStripMenuItem
            // 
            this.دربارهبرنامهنویسToolStripMenuItem.Name = "دربارهبرنامهنویسToolStripMenuItem";
            this.دربارهبرنامهنویسToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.دربارهبرنامهنویسToolStripMenuItem.Text = "درباره برنامه نویس";
            this.دربارهبرنامهنویسToolStripMenuItem.Click += new System.EventHandler(this.دربارهبرنامهنویسToolStripMenuItem_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Image = global::GridMaster.Properties.Resources.btnPlay;
            this.btnPlay.Location = new System.Drawing.Point(552, 160);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(59, 60);
            this.btnPlay.TabIndex = 29;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPlay_MouseDown);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnPlay.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            this.btnPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPlay_MouseMove);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.Transparent;
            this.btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPre.Location = new System.Drawing.Point(491, 168);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(52, 39);
            this.btnPre.TabIndex = 30;
            this.btnPre.TabStop = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // lblNim
            // 
            this.lblNim.BackColor = System.Drawing.Color.Lime;
            this.lblNim.Location = new System.Drawing.Point(12, 195);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(776, 376);
            this.lblNim.TabIndex = 31;
            this.lblNim.Visible = false;
            // 
            // HandDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GridMaster.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(782, 568);
            this.Controls.Add(this.lblNim);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.numRows);
            this.Controls.Add(this.numCols);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.txtWhiteExt);
            this.Controls.Add(this.txtBlack);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HandDrawing";
            this.Text = "HandDrawing";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.HandDrawing_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandDrawing_MouseDown);
            this.MouseHover += new System.EventHandler(this.HandDrawing_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandDrawing_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandDrawing_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPre)).EndInit();
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
        private TextBox txtBlack;
        private PictureBox pictureBox3;
        private NumericUpDown numCols;
        private NumericUpDown numRows;
        private PictureBox btnUpdate;
        private PictureBox btnClock;
        private PictureBox btnNext;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox txtPath;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem خروجToolStripMenuItem;
        private PictureBox btnPlay;
        private PictureBox btnPre;
        private ToolStripMenuItem بازکردنفایلToolStripMenuItem;
        private ToolStripMenuItem ذخیرهToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem پاکسازیToolStripMenuItem;
        private ToolStripMenuItem اتصالبهوبکمToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem سورسپروژهToolStripMenuItem;
        private ToolStripMenuItem دربارهبرنامهنویسToolStripMenuItem;
        private Label lblNim;
        private ToolStripMenuItem btnMin;
        private ToolStripMenuItem ساعتدیجیتالToolStripMenuItem;
        private ToolStripMenuItem بازیهاToolStripMenuItem;
        private ToolStripMenuItem باقیماندنرویصفحهToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem نسخهمدرنToolStripMenuItem;
    }
}