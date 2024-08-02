namespace DA1_formLogin
{
    partial class QLSoLuong
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
            label1 = new Label();
            btn_ok = new Button();
            txt_chonsoluong = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(167, 119);
            label1.Name = "label1";
            label1.Size = new Size(210, 23);
            label1.TabIndex = 0;
            label1.Text = "Chọn Số Lượng Sản Phẩm";
            // 
            // btn_ok
            // 
            btn_ok.BackColor = Color.Aquamarine;
            btn_ok.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_ok.ForeColor = SystemColors.ActiveCaptionText;
            btn_ok.Location = new Point(193, 190);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(132, 47);
            btn_ok.TabIndex = 1;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = false;
            btn_ok.Click += btn_ok_Click;
            // 
            // txt_chonsoluong
            // 
            txt_chonsoluong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_chonsoluong.Location = new Point(106, 145);
            txt_chonsoluong.Name = "txt_chonsoluong";
            txt_chonsoluong.ScrollBars = ScrollBars.Vertical;
            txt_chonsoluong.Size = new Size(330, 27);
            txt_chonsoluong.TabIndex = 2;
            // 
            // QLSoLuong
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 354);
            Controls.Add(txt_chonsoluong);
            Controls.Add(btn_ok);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Name = "QLSoLuong";
            Text = "QLSoLuong";
            Load += QLSoLuong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_ok;
        private TextBox txt_chonsoluong;
    }
}