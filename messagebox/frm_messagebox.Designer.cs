namespace messagebox
{
    partial class frm_messagebox
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Panel();
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_box
            // 
            this.picture_box.Image = global::messagebox.Properties.Resources.done_64px;
            this.picture_box.Location = new System.Drawing.Point(0, 56);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(350, 69);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box.TabIndex = 20;
            this.picture_box.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(70)))));
            this.lbl_title.Location = new System.Drawing.Point(0, 140);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(350, 30);
            this.lbl_title.TabIndex = 21;
            this.lbl_title.Text = "Oooops!";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.White;
            this.separator.Location = new System.Drawing.Point(12, 188);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(326, 6);
            this.separator.TabIndex = 22;
            // 
            // lbl_message
            // 
            this.lbl_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_message.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_message.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_message.ForeColor = System.Drawing.Color.White;
            this.lbl_message.Location = new System.Drawing.Point(2, 197);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(348, 90);
            this.lbl_message.TabIndex = 47;
            this.lbl_message.Text = "Message..";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(70)))));
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(74, 280);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(200, 40);
            this.btn_confirm.TabIndex = 48;
            this.btn_confirm.Text = "button";
            this.btn_confirm.UseVisualStyleBackColor = false;
            // 
            // btn_yes
            // 
            this.btn_yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(169)))), ((int)(((byte)(248)))));
            this.btn_yes.FlatAppearance.BorderSize = 0;
            this.btn_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_yes.ForeColor = System.Drawing.Color.White;
            this.btn_yes.Location = new System.Drawing.Point(86, 280);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(80, 40);
            this.btn_yes.TabIndex = 49;
            this.btn_yes.Text = "YES";
            this.btn_yes.UseVisualStyleBackColor = false;
            // 
            // btn_no
            // 
            this.btn_no.BackColor = System.Drawing.Color.Gray;
            this.btn_no.FlatAppearance.BorderSize = 0;
            this.btn_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_no.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_no.ForeColor = System.Drawing.Color.White;
            this.btn_no.Location = new System.Drawing.Point(183, 280);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(80, 40);
            this.btn_no.TabIndex = 50;
            this.btn_no.Text = "NO";
            this.btn_no.UseVisualStyleBackColor = false;
            // 
            // frm_messagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.picture_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_messagebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_messagebox";
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picture_box;
        public System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_no;
    }
}

