namespace Lilypad
{
    partial class AddFavoriteForm
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
            this.ServerIPInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerNameInput = new System.Windows.Forms.Label();
            this.ServerPortInput = new System.Windows.Forms.NumericUpDown();
            this.ServerVersionInput = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SubmitForm = new System.Windows.Forms.Button();
            this.CancelForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServerPortInput)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerIPInput
            // 
            this.ServerIPInput.Location = new System.Drawing.Point(56, 12);
            this.ServerIPInput.Name = "ServerIPInput";
            this.ServerIPInput.Size = new System.Drawing.Size(120, 20);
            this.ServerIPInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Version";
            // 
            // ServerNameInput
            // 
            this.ServerNameInput.AutoSize = true;
            this.ServerNameInput.Location = new System.Drawing.Point(15, 94);
            this.ServerNameInput.Name = "ServerNameInput";
            this.ServerNameInput.Size = new System.Drawing.Size(35, 13);
            this.ServerNameInput.TabIndex = 4;
            this.ServerNameInput.Text = "Name";
            // 
            // ServerPortInput
            // 
            this.ServerPortInput.Location = new System.Drawing.Point(56, 38);
            this.ServerPortInput.Name = "ServerPortInput";
            this.ServerPortInput.Size = new System.Drawing.Size(120, 20);
            this.ServerPortInput.TabIndex = 5;
            // 
            // ServerVersionInput
            // 
            this.ServerVersionInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerVersionInput.FormattingEnabled = true;
            this.ServerVersionInput.Location = new System.Drawing.Point(56, 64);
            this.ServerVersionInput.Name = "ServerVersionInput";
            this.ServerVersionInput.Size = new System.Drawing.Size(121, 21);
            this.ServerVersionInput.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // SubmitForm
            // 
            this.SubmitForm.Location = new System.Drawing.Point(11, 118);
            this.SubmitForm.Name = "SubmitForm";
            this.SubmitForm.Size = new System.Drawing.Size(83, 23);
            this.SubmitForm.TabIndex = 8;
            this.SubmitForm.Text = "Add Favorite";
            this.SubmitForm.UseVisualStyleBackColor = true;
            // 
            // CancelForm
            // 
            this.CancelForm.Location = new System.Drawing.Point(101, 118);
            this.CancelForm.Name = "CancelForm";
            this.CancelForm.Size = new System.Drawing.Size(83, 23);
            this.CancelForm.TabIndex = 9;
            this.CancelForm.Text = "Cancel";
            this.CancelForm.UseVisualStyleBackColor = true;
            this.CancelForm.Click += new System.EventHandler(this.CancelForm_Click);
            // 
            // AddFavoriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 148);
            this.ControlBox = false;
            this.Controls.Add(this.CancelForm);
            this.Controls.Add(this.SubmitForm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ServerVersionInput);
            this.Controls.Add(this.ServerPortInput);
            this.Controls.Add(this.ServerNameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerIPInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddFavoriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Favorite";
            ((System.ComponentModel.ISupportInitialize)(this.ServerPortInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerIPInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ServerNameInput;
        private System.Windows.Forms.NumericUpDown ServerPortInput;
        private System.Windows.Forms.ComboBox ServerVersionInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SubmitForm;
        private System.Windows.Forms.Button CancelForm;
    }
}