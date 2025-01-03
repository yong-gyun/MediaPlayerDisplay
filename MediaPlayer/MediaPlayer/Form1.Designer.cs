namespace MediaPlayer
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
            // 폼 설정
            this.Text = "Music Player";
            this.BackColor = Color.FromArgb(200, 200, 200);
            this.ClientSize = new Size(400, 200);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            // 앨범 이미지
            PictureBox albumCover = new PictureBox
            {
                ImageLocation = "your_album_image_path.jpg", // 앨범 이미지 경로 설정
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(60, 60),
                Location = new Point(20, 70)
            };
            this.Controls.Add(albumCover);

            // 날짜 텍스트
            Label dateLabel = new Label
            {
                Text = DateTime.Now.ToString("dddd, MMMM d"),
                Font = new Font("Arial", 12, FontStyle.Regular),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 20)
            };
            this.Controls.Add(dateLabel);

            // 시간 텍스트
            Label timeLabel = new Label
            {
                Text = DateTime.Now.ToString("HH:mm"),
                Font = new Font("Arial", 36, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(100, 60)
            };
            this.Controls.Add(timeLabel);

            // 노래 제목
            Label songTitle = new Label
            {
                Text = "Seventeen's Song", // 노래 제목 설정
                Font = new Font("Arial", 14, FontStyle.Regular),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(100, 120)
            };
            this.Controls.Add(songTitle);

            // 가장자리 둥글게
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void AddSidebarButton(Panel sidebar, string text, int top)
        {
            Button button = new Button
            {
                Text = text,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 180,
                Height = 40,
                Location = new Point(10, top),
                BackColor = Color.FromArgb(33, 33, 33)
            };
            sidebar.Controls.Add(button);
        }
    }
    #endregion
}
