namespace RC4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.EncBox = new System.Windows.Forms.TextBox();
            this.DecBox = new System.Windows.Forms.TextBox();
            this.EncButton = new System.Windows.Forms.Button();
            this.DecButton = new System.Windows.Forms.Button();
            this.Keybox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 636);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "DEC";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(73, 139);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(390, 143);
            this.InputBox.TabIndex = 3;
            // 
            // EncBox
            // 
            this.EncBox.Location = new System.Drawing.Point(73, 414);
            this.EncBox.Multiline = true;
            this.EncBox.Name = "EncBox";
            this.EncBox.ReadOnly = true;
            this.EncBox.Size = new System.Drawing.Size(822, 143);
            this.EncBox.TabIndex = 4;
            // 
            // DecBox
            // 
            this.DecBox.Location = new System.Drawing.Point(73, 671);
            this.DecBox.Multiline = true;
            this.DecBox.Name = "DecBox";
            this.DecBox.ReadOnly = true;
            this.DecBox.Size = new System.Drawing.Size(822, 143);
            this.DecBox.TabIndex = 5;
            // 
            // EncButton
            // 
            this.EncButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncButton.Location = new System.Drawing.Point(722, 288);
            this.EncButton.Name = "EncButton";
            this.EncButton.Size = new System.Drawing.Size(173, 75);
            this.EncButton.TabIndex = 6;
            this.EncButton.Text = "Enc";
            this.EncButton.UseVisualStyleBackColor = true;
            this.EncButton.Click += new System.EventHandler(this.EncButton_Click);
            // 
            // DecButton
            // 
            this.DecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecButton.Location = new System.Drawing.Point(722, 563);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(173, 75);
            this.DecButton.TabIndex = 7;
            this.DecButton.Text = "Dec";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // Keybox
            // 
            this.Keybox.Location = new System.Drawing.Point(469, 139);
            this.Keybox.Multiline = true;
            this.Keybox.Name = "Keybox";
            this.Keybox.Size = new System.Drawing.Size(390, 143);
            this.Keybox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(762, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "KEY";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 966);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Keybox);
            this.Controls.Add(this.DecButton);
            this.Controls.Add(this.EncButton);
            this.Controls.Add(this.DecBox);
            this.Controls.Add(this.EncBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Lê Anh Khoa - 22162016";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox EncBox;
        private System.Windows.Forms.TextBox DecBox;
        private System.Windows.Forms.Button EncButton;
        private System.Windows.Forms.Button DecButton;
        private System.Windows.Forms.TextBox Keybox;
        private System.Windows.Forms.Label label4;
    }
}

