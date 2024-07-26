namespace ExcelDataMerger
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            file1_name = new Label();
            file2_name = new Label();
            close = new PictureBox();
            minimize = new PictureBox();
            sColumnMatch = new TextBox();
            sColumnTake = new TextBox();
            tColumnUpdate = new TextBox();
            tColumnMatch = new TextBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 38);
            label1.Name = "label1";
            label1.Size = new Size(259, 42);
            label1.TabIndex = 0;
            label1.Text = "Excel Data Merger";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "(.xlsx;.xls)|*.xlsx;*.xls";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.Filter = "(.xlsx;.xls)|*.xlsx;*.xls";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(125, 214);
            label3.Name = "label3";
            label3.Size = new Size(283, 27);
            label3.TabIndex = 2;
            label3.Text = "Select Target Excel File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 151);
            label2.Name = "label2";
            label2.Size = new Size(282, 27);
            label2.TabIndex = 1;
            label2.Text = "Select Source Excel File";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkViolet;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(418, 133);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(210, 56);
            button1.TabIndex = 3;
            button1.Text = "Browse Source";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkViolet;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(418, 205);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(210, 57);
            button2.TabIndex = 4;
            button2.Text = "Browse Target";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(329, 326);
            button3.Name = "button3";
            button3.Padding = new Padding(40, 0, 0, 0);
            button3.Size = new Size(257, 50);
            button3.TabIndex = 5;
            button3.Text = "Start Merging";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // file1_name
            // 
            file1_name.AutoSize = true;
            file1_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            file1_name.Location = new Point(649, 147);
            file1_name.Name = "file1_name";
            file1_name.Size = new Size(0, 21);
            file1_name.TabIndex = 6;
            // 
            // file2_name
            // 
            file2_name.AutoSize = true;
            file2_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            file2_name.Location = new Point(649, 205);
            file2_name.Name = "file2_name";
            file2_name.Size = new Size(0, 21);
            file2_name.TabIndex = 7;
            // 
            // close
            // 
            close.Cursor = Cursors.Hand;
            close.Image = (Image)resources.GetObject("close.Image");
            close.Location = new Point(900, 2);
            close.Name = "close";
            close.Size = new Size(31, 34);
            close.SizeMode = PictureBoxSizeMode.CenterImage;
            close.TabIndex = 8;
            close.TabStop = false;
            close.Click += close_Click;
            // 
            // minimize
            // 
            minimize.Cursor = Cursors.Hand;
            minimize.Image = (Image)resources.GetObject("minimize.Image");
            minimize.Location = new Point(862, 2);
            minimize.Name = "minimize";
            minimize.Size = new Size(32, 34);
            minimize.SizeMode = PictureBoxSizeMode.CenterImage;
            minimize.TabIndex = 9;
            minimize.TabStop = false;
            minimize.Click += minimize_Click;
            // 
            // sColumnMatch
            // 
            sColumnMatch.Location = new Point(631, 137);
            sColumnMatch.Name = "sColumnMatch";
            sColumnMatch.Size = new Size(45, 23);
            sColumnMatch.TabIndex = 10;
            sColumnMatch.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(sColumnMatch, "Enter the source column index to match.");
            // 
            // sColumnTake
            // 
            sColumnTake.Location = new Point(631, 166);
            sColumnTake.Name = "sColumnTake";
            sColumnTake.Size = new Size(45, 23);
            sColumnTake.TabIndex = 11;
            sColumnTake.TextAlign = HorizontalAlignment.Center;
            toolTip2.SetToolTip(sColumnTake, "Enter the source column index to take the value from.");
            // 
            // tColumnUpdate
            // 
            tColumnUpdate.Location = new Point(631, 239);
            tColumnUpdate.Name = "tColumnUpdate";
            tColumnUpdate.Size = new Size(45, 23);
            tColumnUpdate.TabIndex = 13;
            tColumnUpdate.TextAlign = HorizontalAlignment.Center;
            toolTip4.SetToolTip(tColumnUpdate, "Enter the target column index to update the value.");
            // 
            // tColumnMatch
            // 
            tColumnMatch.Location = new Point(631, 210);
            tColumnMatch.Name = "tColumnMatch";
            tColumnMatch.Size = new Size(45, 23);
            tColumnMatch.TabIndex = 12;
            tColumnMatch.TextAlign = HorizontalAlignment.Center;
            toolTip3.SetToolTip(tColumnMatch, "Enter the target column index to match.");
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 200;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Source Column Index";
            // 
            // toolTip2
            // 
            toolTip2.AutomaticDelay = 200;
            toolTip2.IsBalloon = true;
            toolTip2.ToolTipTitle = "Source Column Take";
            // 
            // toolTip3
            // 
            toolTip3.AutomaticDelay = 200;
            toolTip3.IsBalloon = true;
            toolTip3.ToolTipTitle = "Traget Column Index";
            // 
            // toolTip4
            // 
            toolTip4.AutomaticDelay = 200;
            toolTip4.IsBalloon = true;
            toolTip4.ToolTipTitle = "Target Column Update";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(935, 499);
            Controls.Add(tColumnUpdate);
            Controls.Add(tColumnMatch);
            Controls.Add(sColumnTake);
            Controls.Add(sColumnMatch);
            Controls.Add(minimize);
            Controls.Add(close);
            Controls.Add(file2_name);
            Controls.Add(file1_name);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label file1_name;
        private Label file2_name;
        private PictureBox close;
        private PictureBox minimize;
        private TextBox sColumnMatch;
        private TextBox sColumnTake;
        private TextBox tColumnUpdate;
        private TextBox tColumnMatch;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
    }
}
