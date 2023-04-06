namespace ShapeClient
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.param1 = new System.Windows.Forms.TextBox();
            this.param2 = new System.Windows.Forms.TextBox();
            this.param3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paraml1 = new System.Windows.Forms.Label();
            this.paraml2 = new System.Windows.Forms.Label();
            this.paraml3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // param1
            // 
            this.param1.Location = new System.Drawing.Point(134, 127);
            this.param1.Name = "param1";
            this.param1.Size = new System.Drawing.Size(100, 20);
            this.param1.TabIndex = 2;
            // 
            // param2
            // 
            this.param2.Location = new System.Drawing.Point(134, 186);
            this.param2.Name = "param2";
            this.param2.Size = new System.Drawing.Size(100, 20);
            this.param2.TabIndex = 3;
            // 
            // param3
            // 
            this.param3.Location = new System.Drawing.Point(134, 244);
            this.param3.Name = "param3";
            this.param3.Size = new System.Drawing.Size(100, 20);
            this.param3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Compute";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(186, 363);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(37, 13);
            this.result.TabIndex = 6;
            this.result.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Shape :";
            // 
            // paraml1
            // 
            this.paraml1.AutoSize = true;
            this.paraml1.Location = new System.Drawing.Point(75, 134);
            this.paraml1.Name = "paraml1";
            this.paraml1.Size = new System.Drawing.Size(43, 13);
            this.paraml1.TabIndex = 8;
            this.paraml1.Text = "Param1";
            // 
            // paraml2
            // 
            this.paraml2.AutoSize = true;
            this.paraml2.Location = new System.Drawing.Point(75, 189);
            this.paraml2.Name = "paraml2";
            this.paraml2.Size = new System.Drawing.Size(43, 13);
            this.paraml2.TabIndex = 9;
            this.paraml2.Text = "Param2";
            // 
            // paraml3
            // 
            this.paraml3.AutoSize = true;
            this.paraml3.Location = new System.Drawing.Point(75, 247);
            this.paraml3.Name = "paraml3";
            this.paraml3.Size = new System.Drawing.Size(43, 13);
            this.paraml3.TabIndex = 10;
            this.paraml3.Text = "Param3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Perimeter :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paraml3);
            this.Controls.Add(this.paraml2);
            this.Controls.Add(this.paraml1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.param3);
            this.Controls.Add(this.param2);
            this.Controls.Add(this.param1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox param1;
        private System.Windows.Forms.TextBox param2;
        private System.Windows.Forms.TextBox param3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label paraml1;
        private System.Windows.Forms.Label paraml2;
        private System.Windows.Forms.Label paraml3;
        private System.Windows.Forms.Label label5;
    }
}

