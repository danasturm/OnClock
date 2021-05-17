
namespace OnClock
{
    partial class Clockin_in
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
            this.txt_employeename = new System.Windows.Forms.TextBox();
            this.txt_employeeid = new System.Windows.Forms.TextBox();
            this.lbl_employeename = new System.Windows.Forms.Label();
            this.lbl_employeeid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_backtoselect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_employeename
            // 
            this.txt_employeename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employeename.Location = new System.Drawing.Point(184, 79);
            this.txt_employeename.Name = "txt_employeename";
            this.txt_employeename.Size = new System.Drawing.Size(296, 30);
            this.txt_employeename.TabIndex = 9;
            this.txt_employeename.TextChanged += new System.EventHandler(this.txt_employeename_TextChanged);
            // 
            // txt_employeeid
            // 
            this.txt_employeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employeeid.Location = new System.Drawing.Point(184, 21);
            this.txt_employeeid.Name = "txt_employeeid";
            this.txt_employeeid.Size = new System.Drawing.Size(296, 30);
            this.txt_employeeid.TabIndex = 8;
            this.txt_employeeid.TextChanged += new System.EventHandler(this.txt_employeeid_TextChanged);
            // 
            // lbl_employeename
            // 
            this.lbl_employeename.AutoSize = true;
            this.lbl_employeename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employeename.Location = new System.Drawing.Point(26, 85);
            this.lbl_employeename.Name = "lbl_employeename";
            this.lbl_employeename.Size = new System.Drawing.Size(156, 25);
            this.lbl_employeename.TabIndex = 7;
            this.lbl_employeename.Text = "Employee Name";
            // 
            // lbl_employeeid
            // 
            this.lbl_employeeid.AutoSize = true;
            this.lbl_employeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employeeid.Location = new System.Drawing.Point(26, 21);
            this.lbl_employeeid.Name = "lbl_employeeid";
            this.lbl_employeeid.Size = new System.Drawing.Size(123, 25);
            this.lbl_employeeid.TabIndex = 6;
            this.lbl_employeeid.Text = "Employee ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 454);
            this.dataGridView1.TabIndex = 10;
           
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(916, 614);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(115, 46);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_backtoselect
            // 
            this.btn_backtoselect.Location = new System.Drawing.Point(1070, 614);
            this.btn_backtoselect.Name = "btn_backtoselect";
            this.btn_backtoselect.Size = new System.Drawing.Size(111, 46);
            this.btn_backtoselect.TabIndex = 11;
            this.btn_backtoselect.Text = "Back";
            this.btn_backtoselect.UseVisualStyleBackColor = true;
            this.btn_backtoselect.Click += new System.EventHandler(this.btn_backtoselect_Click);
            // 
            // Clockin_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 725);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_backtoselect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_employeename);
            this.Controls.Add(this.txt_employeeid);
            this.Controls.Add(this.lbl_employeename);
            this.Controls.Add(this.lbl_employeeid);
            this.Name = "Clockin_in";
            this.Text = "Clockin_in";
            this.Load += new System.EventHandler(this.Clockin_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_employeename;
        private System.Windows.Forms.TextBox txt_employeeid;
        private System.Windows.Forms.Label lbl_employeename;
        private System.Windows.Forms.Label lbl_employeeid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_backtoselect;
    }
}