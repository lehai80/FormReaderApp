namespace FormReaderApp
{
    partial class btn_datainsert
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cotso1 = new System.Windows.Forms.TextBox();
            this.txt_cotso2 = new System.Windows.Forms.TextBox();
            this.txt_cotso3 = new System.Windows.Forms.TextBox();
            this.btn_accept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "cotso1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "cotso2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "cotso3";
            // 
            // txt_cotso1
            // 
            this.txt_cotso1.Location = new System.Drawing.Point(183, 26);
            this.txt_cotso1.Name = "txt_cotso1";
            this.txt_cotso1.Size = new System.Drawing.Size(193, 22);
            this.txt_cotso1.TabIndex = 3;
            // 
            // txt_cotso2
            // 
            this.txt_cotso2.Location = new System.Drawing.Point(183, 90);
            this.txt_cotso2.Name = "txt_cotso2";
            this.txt_cotso2.Size = new System.Drawing.Size(193, 22);
            this.txt_cotso2.TabIndex = 4;
            // 
            // txt_cotso3
            // 
            this.txt_cotso3.Location = new System.Drawing.Point(183, 157);
            this.txt_cotso3.Name = "txt_cotso3";
            this.txt_cotso3.Size = new System.Drawing.Size(193, 22);
            this.txt_cotso3.TabIndex = 5;
            // 
            // btn_accept
            // 
            this.btn_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.Location = new System.Drawing.Point(167, 232);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(141, 32);
            this.btn_accept.TabIndex = 6;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cotso3);
            this.groupBox1.Controls.Add(this.txt_cotso2);
            this.groupBox1.Controls.Add(this.txt_cotso1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 199);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_datainsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 272);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.groupBox1);
            this.Name = "btn_datainsert";
            this.Text = "Insert new data";
            this.Load += new System.EventHandler(this.btn_datainsert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cotso1;
        private System.Windows.Forms.TextBox txt_cotso2;
        private System.Windows.Forms.TextBox txt_cotso3;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}