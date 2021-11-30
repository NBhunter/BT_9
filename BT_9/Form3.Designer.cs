
namespace BT_9
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMang = new System.Windows.Forms.TextBox();
            this.txtchan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các Phần tử của mảng";
            // 
            // txtMang
            // 
            this.txtMang.Enabled = false;
            this.txtMang.Location = new System.Drawing.Point(119, 66);
            this.txtMang.Name = "txtMang";
            this.txtMang.Size = new System.Drawing.Size(513, 22);
            this.txtMang.TabIndex = 1;
            // 
            // txtchan
            // 
            this.txtchan.Enabled = false;
            this.txtchan.Location = new System.Drawing.Point(258, 181);
            this.txtchan.Name = "txtchan";
            this.txtchan.Size = new System.Drawing.Size(213, 22);
            this.txtchan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Các số Chẵn trong mảng";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(278, 253);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(184, 69);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtchan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMang);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMang;
        private System.Windows.Forms.TextBox txtchan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexit;
    }
}