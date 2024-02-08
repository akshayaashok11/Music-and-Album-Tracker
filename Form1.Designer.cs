namespace DatabaseSQLMusicApp
{
    partial class Form1
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            txt_description = new TextBox();
            txt_ImageURL = new TextBox();
            txt_albumYear = new TextBox();
            txt_albumArtist = new TextBox();
            txt_albumName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button4 = new Button();
            groupBox2 = new GroupBox();
            txt_ID_album = new TextBox();
            txt_lyrics = new TextBox();
            label12 = new Label();
            txt_trackName = new TextBox();
            txt_videoURL = new TextBox();
            txt_Number = new TextBox();
            txt_trackID = new TextBox();
            button5 = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(230, 15);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 246, 246);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(230, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(743, 186);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(623, 15);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 23);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(979, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(174, 222, 252);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_ImageURL);
            groupBox1.Controls.Add(txt_albumYear);
            groupBox1.Controls.Add(txt_albumArtist);
            groupBox1.Controls.Add(txt_albumName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 215);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Location = new Point(62, 186);
            button3.Name = "button3";
            button3.Size = new Size(78, 23);
            button3.TabIndex = 11;
            button3.Text = "ADD";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(90, 153);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(106, 25);
            txt_description.TabIndex = 7;
            txt_description.TextChanged += textBox3_TextChanged;
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Location = new Point(90, 122);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(106, 25);
            txt_ImageURL.TabIndex = 8;
            txt_ImageURL.TextChanged += textBox4_TextChanged;
            // 
            // txt_albumYear
            // 
            txt_albumYear.Location = new Point(90, 91);
            txt_albumYear.Name = "txt_albumYear";
            txt_albumYear.Size = new Size(106, 25);
            txt_albumYear.TabIndex = 9;
            // 
            // txt_albumArtist
            // 
            txt_albumArtist.Location = new Point(90, 60);
            txt_albumArtist.Name = "txt_albumArtist";
            txt_albumArtist.Size = new Size(106, 25);
            txt_albumArtist.TabIndex = 10;
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(90, 29);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(106, 25);
            txt_albumName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 153);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 122);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 60);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 2;
            label3.Text = "Artist";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 91);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 1;
            label2.Text = "Year";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 32);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(174, 222, 252);
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(230, 242);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 6;
            label6.Text = "Tracks";
            label6.Click += label6_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(255, 246, 246);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(233, 264);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(509, 196);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(748, 242);
            webView21.Name = "webView21";
            webView21.Size = new Size(481, 254);
            webView21.TabIndex = 8;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(233, 469);
            button4.Name = "button4";
            button4.Size = new Size(240, 27);
            button4.TabIndex = 9;
            button4.Text = "Delete Selected Track";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(174, 222, 252);
            groupBox2.Controls.Add(txt_ID_album);
            groupBox2.Controls.Add(txt_lyrics);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txt_trackName);
            groupBox2.Controls.Add(txt_videoURL);
            groupBox2.Controls.Add(txt_Number);
            groupBox2.Controls.Add(txt_trackID);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(202, 247);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Track";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txt_ID_album
            // 
            txt_ID_album.Location = new Point(84, 181);
            txt_ID_album.Name = "txt_ID_album";
            txt_ID_album.Size = new Size(106, 25);
            txt_ID_album.TabIndex = 21;
            // 
            // txt_lyrics
            // 
            txt_lyrics.Location = new Point(84, 152);
            txt_lyrics.Name = "txt_lyrics";
            txt_lyrics.Size = new Size(106, 25);
            txt_lyrics.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 155);
            label12.Name = "label12";
            label12.Size = new Size(43, 17);
            label12.TabIndex = 19;
            label12.Text = "Lyrics";
            label12.Click += label12_Click;
            // 
            // txt_trackName
            // 
            txt_trackName.Location = new Point(84, 57);
            txt_trackName.Name = "txt_trackName";
            txt_trackName.Size = new Size(106, 25);
            txt_trackName.TabIndex = 18;
            // 
            // txt_videoURL
            // 
            txt_videoURL.Location = new Point(84, 119);
            txt_videoURL.Name = "txt_videoURL";
            txt_videoURL.Size = new Size(106, 25);
            txt_videoURL.TabIndex = 15;
            txt_videoURL.TextChanged += textBox4_TextChanged_1;
            // 
            // txt_Number
            // 
            txt_Number.Location = new Point(84, 87);
            txt_Number.Name = "txt_Number";
            txt_Number.Size = new Size(106, 25);
            txt_Number.TabIndex = 14;
            // 
            // txt_trackID
            // 
            txt_trackID.Location = new Point(84, 26);
            txt_trackID.Name = "txt_trackID";
            txt_trackID.Size = new Size(106, 25);
            txt_trackID.TabIndex = 13;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.Location = new Point(56, 218);
            button5.Name = "button5";
            button5.Size = new Size(78, 23);
            button5.TabIndex = 12;
            button5.Text = "ADD";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 34);
            label11.Name = "label11";
            label11.Size = new Size(58, 17);
            label11.TabIndex = 5;
            label11.Text = "Track ID";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 65);
            label10.Name = "label10";
            label10.Size = new Size(80, 17);
            label10.TabIndex = 4;
            label10.Text = "Track Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 95);
            label9.Name = "label9";
            label9.Size = new Size(58, 17);
            label9.TabIndex = 3;
            label9.Text = "Number";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 122);
            label8.Name = "label8";
            label8.Size = new Size(68, 17);
            label8.TabIndex = 2;
            label8.Text = "VideoURL";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 181);
            label7.Name = "label7";
            label7.Size = new Size(67, 17);
            label7.TabIndex = 1;
            label7.Text = "Album ID";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(174, 222, 252);
            ClientSize = new Size(1241, 505);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(webView21);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Music Organizer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txt_albumName;
        private TextBox txt_description;
        private TextBox txt_ImageURL;
        private TextBox txt_albumYear;
        private TextBox txt_albumArtist;
        private Button button3;
        private Label label6;
        private DataGridView dataGridView2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button4;
        private GroupBox groupBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button5;
        private TextBox txt_trackName;
        private TextBox txt_videoURL;
        private TextBox txt_Number;
        private TextBox txt_trackID;
        private Label label12;
        private TextBox txt_lyrics;
        private TextBox txt_ID_album;
    }
}