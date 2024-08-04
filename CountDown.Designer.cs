namespace DA1_formLogin
{
    partial class CountDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountDown));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbl_Timer = new Label();
            button2 = new Button();
            btn_thanhtooanok = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 81);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 393);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.Location = new Point(52, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 19);
            label1.TabIndex = 4;
            label1.Text = "Vui Lòng Quét QR Ngân Hàng Để Thanh Toán!";
            // 
            // lbl_Timer
            // 
            lbl_Timer.AutoSize = true;
            lbl_Timer.Font = new Font("Segoe UI", 20F);
            lbl_Timer.Location = new Point(506, 229);
            lbl_Timer.Name = "lbl_Timer";
            lbl_Timer.Size = new Size(95, 46);
            lbl_Timer.TabIndex = 2;
            lbl_Timer.Text = "00.0s";
            lbl_Timer.Click += Timer_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 8F);
            button2.Location = new Point(591, 370);
            button2.Name = "button2";
            button2.Size = new Size(120, 50);
            button2.TabIndex = 1;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_thanhtooanok
            // 
            btn_thanhtooanok.Font = new Font("Segoe UI", 8F);
            btn_thanhtooanok.Location = new Point(409, 370);
            btn_thanhtooanok.Name = "btn_thanhtooanok";
            btn_thanhtooanok.Size = new Size(128, 50);
            btn_thanhtooanok.TabIndex = 0;
            btn_thanhtooanok.Text = "Đã Thanh Toán";
            btn_thanhtooanok.UseVisualStyleBackColor = true;
            btn_thanhtooanok.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(462, 181);
            label2.Name = "label2";
            label2.Size = new Size(174, 19);
            label2.TabIndex = 5;
            label2.Text = "Thời Gian Hiệu Lực Còn Lại";
            // 
            // CountDown
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 763);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(btn_thanhtooanok);
            Controls.Add(lbl_Timer);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10F);
            Name = "CountDown";
            Text = "CountDown";
            Load += CountDown_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbl_Timer;
        private Button button2;
        private Button btn_thanhtooanok;
        private Label label2;
    }
}