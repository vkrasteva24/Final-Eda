namespace FinalEda
{
    partial class Search
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            hi_user = new Label();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            add_watchlist = new Button();
            add_watched = new Button();
            go_watchlist = new Button();
            go_watched = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 92);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search...";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Title", "Genre", "Director", "Language" });
            comboBox1.Location = new Point(217, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(92, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Category";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(62, 137, 207);
            pictureBox1.BackgroundImage = Properties.Resources._1965ab7ef7de87fe748b3c66efbfc73a_removebg_preview__1_;
            pictureBox1.Location = new Point(308, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 23);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // hi_user
            // 
            hi_user.AutoSize = true;
            hi_user.BackColor = Color.Transparent;
            hi_user.Font = new Font("Gadugi", 12F, FontStyle.Italic, GraphicsUnit.Point);
            hi_user.ForeColor = SystemColors.ButtonHighlight;
            hi_user.Location = new Point(186, 53);
            hi_user.Name = "hi_user";
            hi_user.Size = new Size(74, 19);
            hi_user.TabIndex = 3;
            hi_user.Text = "Welcome";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(52, 71, 105);
            dataGridView1.Location = new Point(26, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(306, 374);
            dataGridView1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 542);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Movie ID...";
            textBox2.Size = new Size(136, 23);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(26, 524);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(136, 16);
            label1.TabIndex = 6;
            label1.Text = "Add movie to Watchlist?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(197, 524);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(134, 16);
            label2.TabIndex = 8;
            label2.Text = "Add movie to Watched?";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(196, 542);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Movie ID...";
            textBox3.Size = new Size(136, 23);
            textBox3.TabIndex = 7;
            // 
            // add_watchlist
            // 
            add_watchlist.BackColor = Color.FromArgb(62, 137, 207);
            add_watchlist.FlatAppearance.BorderColor = Color.FromArgb(62, 137, 207);
            add_watchlist.FlatStyle = FlatStyle.Flat;
            add_watchlist.ForeColor = SystemColors.ButtonHighlight;
            add_watchlist.Location = new Point(26, 572);
            add_watchlist.Name = "add_watchlist";
            add_watchlist.Size = new Size(136, 23);
            add_watchlist.TabIndex = 9;
            add_watchlist.Text = "Add";
            add_watchlist.UseVisualStyleBackColor = false;
            // 
            // add_watched
            // 
            add_watched.BackColor = Color.FromArgb(62, 137, 207);
            add_watched.FlatAppearance.BorderColor = Color.FromArgb(62, 137, 207);
            add_watched.FlatStyle = FlatStyle.Flat;
            add_watched.ForeColor = SystemColors.ButtonHighlight;
            add_watched.Location = new Point(196, 571);
            add_watched.Name = "add_watched";
            add_watched.Size = new Size(136, 23);
            add_watched.TabIndex = 10;
            add_watched.Text = "Add";
            add_watched.UseVisualStyleBackColor = false;
            // 
            // go_watchlist
            // 
            go_watchlist.BackColor = Color.FromArgb(67, 137, 207);
            go_watchlist.FlatAppearance.BorderColor = Color.FromArgb(67, 137, 207);
            go_watchlist.FlatStyle = FlatStyle.Flat;
            go_watchlist.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            go_watchlist.ForeColor = SystemColors.ButtonHighlight;
            go_watchlist.Location = new Point(26, 656);
            go_watchlist.Name = "go_watchlist";
            go_watchlist.Size = new Size(306, 37);
            go_watchlist.TabIndex = 11;
            go_watchlist.Text = "Watchlist";
            go_watchlist.UseVisualStyleBackColor = false;
            // 
            // go_watched
            // 
            go_watched.BackColor = Color.FromArgb(67, 137, 207);
            go_watched.FlatAppearance.BorderColor = Color.FromArgb(67, 137, 207);
            go_watched.FlatStyle = FlatStyle.Flat;
            go_watched.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            go_watched.ForeColor = SystemColors.ButtonHighlight;
            go_watched.Location = new Point(26, 711);
            go_watched.Name = "go_watched";
            go_watched.Size = new Size(306, 37);
            go_watched.TabIndex = 12;
            go_watched.Text = "Watched";
            go_watched.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(23, 630);
            label3.Name = "label3";
            label3.Size = new Size(101, 22);
            label3.TabIndex = 13;
            label3.Text = "Check Out:";
            label3.Click += label3_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IMG_7406;
            ClientSize = new Size(357, 776);
            Controls.Add(label3);
            Controls.Add(go_watched);
            Controls.Add(go_watchlist);
            Controls.Add(add_watched);
            Controls.Add(add_watchlist);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(hi_user);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "Search";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label hi_user;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Button add_watchlist;
        private Button add_watched;
        private Button go_watchlist;
        private Button go_watched;
        private Label label3;
    }
}