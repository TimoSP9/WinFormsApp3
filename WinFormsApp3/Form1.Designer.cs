
namespace WinFormsApp3
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
            this.textBoxdata = new System.Windows.Forms.TextBox();
            this.lbl_inputdata = new System.Windows.Forms.Label();
            this.lbl_empty = new System.Windows.Forms.Label();
            this.btn_proses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxdata
            // 
            this.textBoxdata.Location = new System.Drawing.Point(71, 95);
            this.textBoxdata.Name = "textBoxdata";
            this.textBoxdata.Size = new System.Drawing.Size(307, 27);
            this.textBoxdata.TabIndex = 0;
            // 
            // lbl_inputdata
            // 
            this.lbl_inputdata.AutoSize = true;
            this.lbl_inputdata.Location = new System.Drawing.Point(71, 53);
            this.lbl_inputdata.Name = "lbl_inputdata";
            this.lbl_inputdata.Size = new System.Drawing.Size(94, 20);
            this.lbl_inputdata.TabIndex = 1;
            this.lbl_inputdata.Text = "INPUT DATA:";
            this.lbl_inputdata.Click += new System.EventHandler(this.lbl_inputdata_Click);
            // 
            // lbl_empty
            // 
            this.lbl_empty.AutoSize = true;
            this.lbl_empty.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_empty.Location = new System.Drawing.Point(71, 172);
            this.lbl_empty.Name = "lbl_empty";
            this.lbl_empty.Size = new System.Drawing.Size(129, 41);
            this.lbl_empty.TabIndex = 2;
            this.lbl_empty.Text = "[EMPTY]";
            // 
            // btn_proses
            // 
            this.btn_proses.Location = new System.Drawing.Point(71, 129);
            this.btn_proses.Name = "btn_proses";
            this.btn_proses.Size = new System.Drawing.Size(94, 29);
            this.btn_proses.TabIndex = 3;
            this.btn_proses.Text = "Proses";
            this.btn_proses.UseVisualStyleBackColor = true;
            this.btn_proses.Click += new System.EventHandler(this.btn_proses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_proses);
            this.Controls.Add(this.lbl_empty);
            this.Controls.Add(this.lbl_inputdata);
            this.Controls.Add(this.textBoxdata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxdata;
        private System.Windows.Forms.Label lbl_inputdata;
        private System.Windows.Forms.Label lbl_empty;
        private System.Windows.Forms.Button btn_proses;
    }
}

