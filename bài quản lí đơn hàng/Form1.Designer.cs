

namespace bài_quản_lí_đơn_hàng
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.lableLog = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.inputUserName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lableLog
            // 
            this.lableLog.AutoSize = true;
            this.lableLog.BackColor = System.Drawing.Color.Transparent;
            this.lableLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lableLog.Location = new System.Drawing.Point(154, 53);
            this.lableLog.Name = "lableLog";
            this.lableLog.Size = new System.Drawing.Size(357, 135);
            this.lableLog.TabIndex = 0;
            this.lableLog.Text = "Login";
            this.lableLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lableLog.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(121, 246);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(116, 25);
            this.Username.TabIndex = 1;
            this.Username.Text = "User name";
            // 
            // inputUserName
            // 
            this.inputUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUserName.Location = new System.Drawing.Point(126, 283);
            this.inputUserName.Name = "inputUserName";
            this.inputUserName.Size = new System.Drawing.Size(408, 49);
            this.inputUserName.TabIndex = 2;
            this.inputUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputUserName.TextChanged += new System.EventHandler(this.inputUserName_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(676, 853);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.lableLog);
            this.Controls.Add(this.inputUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(694, 900);
            this.MinimumSize = new System.Drawing.Size(694, 900);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

 
           


        }

        #endregion

        private System.Windows.Forms.Label lableLog;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox inputUserName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

