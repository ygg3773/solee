namespace ImageMacro
{
    partial class SeqForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_open_seq = new System.Windows.Forms.Button();
            this.listView_seq = new System.Windows.Forms.ListView();
            this.btn_create_seq = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.bar_btn = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.target_proc = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Button();
            this.btn_seq_pause = new System.Windows.Forms.Button();
            this.bar_btn.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_file_dialog
            // 
            this.open_file_dialog.FileName = "openFileDialog1";
            this.open_file_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btn_open_seq
            // 
            this.btn_open_seq.BackColor = System.Drawing.Color.Navy;
            this.btn_open_seq.FlatAppearance.BorderSize = 0;
            this.btn_open_seq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open_seq.ForeColor = System.Drawing.Color.White;
            this.btn_open_seq.Location = new System.Drawing.Point(14, 8);
            this.btn_open_seq.Margin = new System.Windows.Forms.Padding(0);
            this.btn_open_seq.Name = "btn_open_seq";
            this.btn_open_seq.Size = new System.Drawing.Size(43, 23);
            this.btn_open_seq.TabIndex = 2;
            this.btn_open_seq.Text = "열기";
            this.btn_open_seq.UseVisualStyleBackColor = false;
            this.btn_open_seq.Click += new System.EventHandler(this.btn_proc_refresh_Click);
            // 
            // listView_seq
            // 
            this.listView_seq.BackColor = System.Drawing.SystemColors.Control;
            this.listView_seq.Location = new System.Drawing.Point(6, 37);
            this.listView_seq.Name = "listView_seq";
            this.listView_seq.Size = new System.Drawing.Size(411, 336);
            this.listView_seq.TabIndex = 3;
            this.listView_seq.UseCompatibleStateImageBehavior = false;
            // 
            // btn_create_seq
            // 
            this.btn_create_seq.BackColor = System.Drawing.Color.Navy;
            this.btn_create_seq.FlatAppearance.BorderSize = 0;
            this.btn_create_seq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_seq.ForeColor = System.Drawing.Color.White;
            this.btn_create_seq.Location = new System.Drawing.Point(80, 8);
            this.btn_create_seq.Margin = new System.Windows.Forms.Padding(0);
            this.btn_create_seq.Name = "btn_create_seq";
            this.btn_create_seq.Size = new System.Drawing.Size(43, 23);
            this.btn_create_seq.TabIndex = 2;
            this.btn_create_seq.Text = "생성";
            this.btn_create_seq.UseVisualStyleBackColor = false;
            this.btn_create_seq.Click += new System.EventHandler(this.btn_proc_refresh_Click);
            // 
            // E
            // 
            this.E.BackColor = System.Drawing.Color.Navy;
            this.E.FlatAppearance.BorderSize = 0;
            this.E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.E.ForeColor = System.Drawing.Color.White;
            this.E.Location = new System.Drawing.Point(145, 8);
            this.E.Margin = new System.Windows.Forms.Padding(0);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(43, 23);
            this.E.TabIndex = 2;
            this.E.Text = "복사";
            this.E.UseVisualStyleBackColor = false;
            this.E.Click += new System.EventHandler(this.btn_proc_refresh_Click);
            // 
            // bar_btn
            // 
            this.bar_btn.BackColor = System.Drawing.SystemColors.Control;
            this.bar_btn.Controls.Add(this.button1);
            this.bar_btn.Controls.Add(this.E);
            this.bar_btn.Controls.Add(this.btn_create_seq);
            this.bar_btn.Controls.Add(this.btn_open_seq);
            this.bar_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar_btn.Location = new System.Drawing.Point(0, 379);
            this.bar_btn.Name = "bar_btn";
            this.bar_btn.Size = new System.Drawing.Size(482, 39);
            this.bar_btn.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(209, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_proc_refresh_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Control;
            this.header.Controls.Add(this.target_proc);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(482, 31);
            this.header.TabIndex = 5;
            // 
            // target_proc
            // 
            this.target_proc.AutoSize = true;
            this.target_proc.Location = new System.Drawing.Point(8, 11);
            this.target_proc.Name = "target_proc";
            this.target_proc.Size = new System.Drawing.Size(65, 12);
            this.target_proc.TabIndex = 1;
            this.target_proc.Text = "Seq_name";
            // 
            // R
            // 
            this.R.BackColor = System.Drawing.Color.Navy;
            this.R.FlatAppearance.BorderSize = 0;
            this.R.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R.ForeColor = System.Drawing.Color.White;
            this.R.Location = new System.Drawing.Point(426, 213);
            this.R.Margin = new System.Windows.Forms.Padding(0);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(43, 23);
            this.R.TabIndex = 2;
            this.R.Text = "▼";
            this.R.UseVisualStyleBackColor = false;
            this.R.Click += new System.EventHandler(this.btn_proc_refresh_Click);
            // 
            // btn_seq_pause
            // 
            this.btn_seq_pause.BackColor = System.Drawing.Color.Navy;
            this.btn_seq_pause.FlatAppearance.BorderSize = 0;
            this.btn_seq_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seq_pause.ForeColor = System.Drawing.Color.White;
            this.btn_seq_pause.Location = new System.Drawing.Point(426, 177);
            this.btn_seq_pause.Margin = new System.Windows.Forms.Padding(0);
            this.btn_seq_pause.Name = "btn_seq_pause";
            this.btn_seq_pause.Size = new System.Drawing.Size(43, 23);
            this.btn_seq_pause.TabIndex = 2;
            this.btn_seq_pause.Text = "▲";
            this.btn_seq_pause.UseVisualStyleBackColor = false;
            this.btn_seq_pause.Click += new System.EventHandler(this.btn_proc_refresh_Click);
            // 
            // SeqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 418);
            this.Controls.Add(this.header);
            this.Controls.Add(this.btn_seq_pause);
            this.Controls.Add(this.R);
            this.Controls.Add(this.bar_btn);
            this.Controls.Add(this.listView_seq);
            this.Name = "SeqForm";
            this.Text = "ImageMacro";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.bar_btn.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog open_file_dialog;
        private System.Windows.Forms.Button btn_open_seq;
        private System.Windows.Forms.ListView listView_seq;
        private System.Windows.Forms.Button btn_create_seq;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Panel bar_btn;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button btn_seq_pause;
        private System.Windows.Forms.Label target_proc;
        private System.Windows.Forms.Button button1;
    }
}

