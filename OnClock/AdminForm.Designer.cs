
namespace OnClock
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btn_logoutadmin = new System.Windows.Forms.Button();
            this.btn_submitadmin = new System.Windows.Forms.Button();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_locationadmin = new System.Windows.Forms.Label();
            this.lbl_gateadmin = new System.Windows.Forms.Label();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.dgw_gate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_gate)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logoutadmin
            // 
            this.btn_logoutadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logoutadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logoutadmin.Location = new System.Drawing.Point(364, 391);
            this.btn_logoutadmin.Name = "btn_logoutadmin";
            this.btn_logoutadmin.Size = new System.Drawing.Size(203, 64);
            this.btn_logoutadmin.TabIndex = 1;
            this.btn_logoutadmin.Text = "Log Out";
            this.btn_logoutadmin.UseVisualStyleBackColor = true;
            this.btn_logoutadmin.Click += new System.EventHandler(this.btn_logoutadmin_Click);
            // 
            // btn_submitadmin
            // 
            this.btn_submitadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submitadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_submitadmin.Location = new System.Drawing.Point(161, 315);
            this.btn_submitadmin.Name = "btn_submitadmin";
            this.btn_submitadmin.Size = new System.Drawing.Size(203, 64);
            this.btn_submitadmin.TabIndex = 4;
            this.btn_submitadmin.Text = "Submit";
            this.btn_submitadmin.UseVisualStyleBackColor = true;
            this.btn_submitadmin.Click += new System.EventHandler(this.btn_submitadmin_Click);
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_country.Location = new System.Drawing.Point(32, 31);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(81, 25);
            this.lbl_country.TabIndex = 5;
            this.lbl_country.Text = "Country";
            // 
            // lbl_locationadmin
            // 
            this.lbl_locationadmin.AutoSize = true;
            this.lbl_locationadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_locationadmin.Location = new System.Drawing.Point(32, 99);
            this.lbl_locationadmin.Name = "lbl_locationadmin";
            this.lbl_locationadmin.Size = new System.Drawing.Size(86, 25);
            this.lbl_locationadmin.TabIndex = 6;
            this.lbl_locationadmin.Text = "Location";
            // 
            // lbl_gateadmin
            // 
            this.lbl_gateadmin.AutoSize = true;
            this.lbl_gateadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gateadmin.Location = new System.Drawing.Point(32, 163);
            this.lbl_gateadmin.Name = "lbl_gateadmin";
            this.lbl_gateadmin.Size = new System.Drawing.Size(54, 25);
            this.lbl_gateadmin.TabIndex = 7;
            this.lbl_gateadmin.Text = "Gate";
            // 
            // txt_country
            // 
            this.txt_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_country.Location = new System.Drawing.Point(161, 31);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(406, 30);
            this.txt_country.TabIndex = 8;
            this.txt_country.TextChanged += new System.EventHandler(this.txt_country_TextChanged);
            // 
            // txt_location
            // 
            this.txt_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location.Location = new System.Drawing.Point(161, 99);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(406, 30);
            this.txt_location.TabIndex = 9;
            this.txt_location.TextChanged += new System.EventHandler(this.lbl_location_TextChanged);
            // 
            // dgw_gate
            // 
            this.dgw_gate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_gate.Location = new System.Drawing.Point(161, 163);
            this.dgw_gate.Name = "dgw_gate";
            this.dgw_gate.RowHeadersWidth = 62;
            this.dgw_gate.RowTemplate.Height = 28;
            this.dgw_gate.Size = new System.Drawing.Size(406, 126);
            this.dgw_gate.TabIndex = 10;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 544);
            this.Controls.Add(this.dgw_gate);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.lbl_gateadmin);
            this.Controls.Add(this.lbl_locationadmin);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.btn_submitadmin);
            this.Controls.Add(this.btn_logoutadmin);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_gate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logoutadmin;
        private System.Windows.Forms.Button btn_submitadmin;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_locationadmin;
        private System.Windows.Forms.Label lbl_gateadmin;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.DataGridView dgw_gate;
    }
}