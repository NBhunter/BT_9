
namespace BT_9
{
    partial class Form2
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
            this.lbKQ = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(63, 82);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(208, 29);
            this.lbKQ.TabIndex = 0;
            this.lbKQ.Text = "X là số hoàn hảo";
            this.lbKQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(136, 164);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(184, 69);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 291);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lbKQ);
            this.Name = "Form2";
            this.Text = "kiểm tra số hoàn hảo";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Button btnexit;
    }
}