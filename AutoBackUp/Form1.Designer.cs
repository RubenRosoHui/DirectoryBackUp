namespace AutoBackUp
{
    partial class Form1
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
            this.txt_Source = new System.Windows.Forms.TextBox();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lbl_Source = new System.Windows.Forms.Label();
            this.lbl_Destination = new System.Windows.Forms.Label();
            this.rbtn_Yes = new System.Windows.Forms.RadioButton();
            this.rbtn_No = new System.Windows.Forms.RadioButton();
            this.SubDir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Source
            // 
            this.txt_Source.Location = new System.Drawing.Point(12, 36);
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.Size = new System.Drawing.Size(100, 20);
            this.txt_Source.TabIndex = 0;
            // 
            // txt_Destination
            // 
            this.txt_Destination.Location = new System.Drawing.Point(185, 36);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(100, 20);
            this.txt_Destination.TabIndex = 1;
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(101, 213);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(121, 57);
            this.btn_Enter.TabIndex = 2;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // lbl_Source
            // 
            this.lbl_Source.AutoSize = true;
            this.lbl_Source.Location = new System.Drawing.Point(41, 9);
            this.lbl_Source.Name = "lbl_Source";
            this.lbl_Source.Size = new System.Drawing.Size(41, 13);
            this.lbl_Source.TabIndex = 3;
            this.lbl_Source.Text = "Source";
            // 
            // lbl_Destination
            // 
            this.lbl_Destination.AutoSize = true;
            this.lbl_Destination.Location = new System.Drawing.Point(207, 9);
            this.lbl_Destination.Name = "lbl_Destination";
            this.lbl_Destination.Size = new System.Drawing.Size(60, 13);
            this.lbl_Destination.TabIndex = 4;
            this.lbl_Destination.Text = "Destination";
            // 
            // rbtn_Yes
            // 
            this.rbtn_Yes.AutoSize = true;
            this.rbtn_Yes.Location = new System.Drawing.Point(13, 114);
            this.rbtn_Yes.Name = "rbtn_Yes";
            this.rbtn_Yes.Size = new System.Drawing.Size(43, 17);
            this.rbtn_Yes.TabIndex = 5;
            this.rbtn_Yes.Text = "Yes";
            this.rbtn_Yes.UseVisualStyleBackColor = true;
            // 
            // rbtn_No
            // 
            this.rbtn_No.AutoSize = true;
            this.rbtn_No.Checked = true;
            this.rbtn_No.Location = new System.Drawing.Point(12, 138);
            this.rbtn_No.Name = "rbtn_No";
            this.rbtn_No.Size = new System.Drawing.Size(39, 17);
            this.rbtn_No.TabIndex = 6;
            this.rbtn_No.TabStop = true;
            this.rbtn_No.Text = "No";
            this.rbtn_No.UseVisualStyleBackColor = true;
            // 
            // SubDir
            // 
            this.SubDir.AutoSize = true;
            this.SubDir.Location = new System.Drawing.Point(13, 80);
            this.SubDir.Name = "SubDir";
            this.SubDir.Size = new System.Drawing.Size(168, 13);
            this.SubDir.TabIndex = 7;
            this.SubDir.Text = "Copy Directory to the Destination?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 282);
            this.Controls.Add(this.SubDir);
            this.Controls.Add(this.rbtn_No);
            this.Controls.Add(this.rbtn_Yes);
            this.Controls.Add(this.lbl_Destination);
            this.Controls.Add(this.lbl_Source);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.txt_Destination);
            this.Controls.Add(this.txt_Source);
            this.Name = "Form1";
            this.Text = "USB Backup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Source;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label lbl_Source;
        private System.Windows.Forms.Label lbl_Destination;
        private System.Windows.Forms.RadioButton rbtn_Yes;
        private System.Windows.Forms.RadioButton rbtn_No;
        private System.Windows.Forms.Label SubDir;
    }
}

