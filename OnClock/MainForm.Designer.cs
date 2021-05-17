
namespace OnClock
{
    partial class MainForm
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
            this.btn_clockin = new System.Windows.Forms.Button();
            this.btn_clockout = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clockin
            // 
            this.btn_clockin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_clockin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clockin.Location = new System.Drawing.Point(182, 118);
            this.btn_clockin.Name = "btn_clockin";
            this.btn_clockin.Size = new System.Drawing.Size(191, 87);
            this.btn_clockin.TabIndex = 0;
            this.btn_clockin.Text = "Clock In";
            this.btn_clockin.UseVisualStyleBackColor = false;
            this.btn_clockin.Click += new System.EventHandler(this.btn_clockin_Click);
            // 
            // btn_clockout
            // 
            this.btn_clockout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_clockout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clockout.Location = new System.Drawing.Point(470, 118);
            this.btn_clockout.Name = "btn_clockout";
            this.btn_clockout.Size = new System.Drawing.Size(191, 87);
            this.btn_clockout.TabIndex = 1;
            this.btn_clockout.Text = "Clock Out";
            this.btn_clockout.UseVisualStyleBackColor = false;
            this.btn_clockout.Click += new System.EventHandler(this.btn_clockout_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(717, 419);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(117, 45);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(865, 476);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_clockout);
            this.Controls.Add(this.btn_clockin);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clockin;
        private System.Windows.Forms.Button btn_clockout;
        private System.Windows.Forms.Button btn_logout;
    }
}