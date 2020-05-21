namespace FindYourFile
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
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.DriveSelectBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DriveErrorLabel = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.GeneralErrorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AutoOpenBox = new System.Windows.Forms.CheckBox();
            this.PathOpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input your filename below.";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InputBox.Location = new System.Drawing.Point(95, 106);
            this.InputBox.Name = "InputBox";
            this.InputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.InputBox.Size = new System.Drawing.Size(348, 33);
            this.InputBox.TabIndex = 1;
            this.InputBox.Text = "";
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartButton.Location = new System.Drawing.Point(384, 197);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(201, 29);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(197, 77);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(147, 15);
            this.ErrorLabel.TabIndex = 3;
            this.ErrorLabel.Text = "Filename blank or invalid.";
            this.ErrorLabel.Visible = false;
            // 
            // DriveSelectBox
            // 
            this.DriveSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DriveSelectBox.FormattingEnabled = true;
            this.DriveSelectBox.Location = new System.Drawing.Point(745, 106);
            this.DriveSelectBox.Name = "DriveSelectBox";
            this.DriveSelectBox.Size = new System.Drawing.Size(121, 23);
            this.DriveSelectBox.TabIndex = 4;
            this.DriveSelectBox.SelectedIndexChanged += new System.EventHandler(this.DriveSelectBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(766, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Drive to scan:";
            // 
            // ResultBox
            // 
            this.ResultBox.Enabled = false;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResultBox.Location = new System.Drawing.Point(12, 386);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(578, 26);
            this.ResultBox.TabIndex = 6;
            this.ResultBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(273, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result:";
            this.label3.Visible = false;
            // 
            // DriveErrorLabel
            // 
            this.DriveErrorLabel.AutoSize = true;
            this.DriveErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DriveErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.DriveErrorLabel.Location = new System.Drawing.Point(732, 151);
            this.DriveErrorLabel.Name = "DriveErrorLabel";
            this.DriveErrorLabel.Size = new System.Drawing.Size(150, 15);
            this.DriveErrorLabel.TabIndex = 8;
            this.DriveErrorLabel.Text = "Please select a valid drive.";
            this.DriveErrorLabel.Visible = false;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(596, 386);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(107, 26);
            this.CopyButton.TabIndex = 9;
            this.CopyButton.Text = "Copy to Clipboard";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Visible = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // GeneralErrorLabel
            // 
            this.GeneralErrorLabel.AutoSize = true;
            this.GeneralErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.GeneralErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GeneralErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.GeneralErrorLabel.Location = new System.Drawing.Point(178, 287);
            this.GeneralErrorLabel.Name = "GeneralErrorLabel";
            this.GeneralErrorLabel.Size = new System.Drawing.Size(407, 16);
            this.GeneralErrorLabel.TabIndex = 10;
            this.GeneralErrorLabel.Text = "If you see this, something went REALLY wrong (Or you\'re just dumb).\r\n";
            this.GeneralErrorLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(230, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Copied To Clipboard!";
            this.label4.Visible = false;
            // 
            // AutoOpenBox
            // 
            this.AutoOpenBox.AutoSize = true;
            this.AutoOpenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AutoOpenBox.Location = new System.Drawing.Point(644, 207);
            this.AutoOpenBox.Name = "AutoOpenBox";
            this.AutoOpenBox.Size = new System.Drawing.Size(208, 20);
            this.AutoOpenBox.TabIndex = 12;
            this.AutoOpenBox.Text = "Auto open path in File Explorer";
            this.AutoOpenBox.UseVisualStyleBackColor = true;
            this.AutoOpenBox.CheckedChanged += new System.EventHandler(this.AutoOpenBox_CheckedChanged);
            // 
            // PathOpenButton
            // 
            this.PathOpenButton.Location = new System.Drawing.Point(709, 386);
            this.PathOpenButton.Name = "PathOpenButton";
            this.PathOpenButton.Size = new System.Drawing.Size(107, 26);
            this.PathOpenButton.TabIndex = 13;
            this.PathOpenButton.Text = "Open in Explorer";
            this.PathOpenButton.UseVisualStyleBackColor = true;
            this.PathOpenButton.Visible = false;
            this.PathOpenButton.Click += new System.EventHandler(this.PathOpenButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1030, 480);
            this.Controls.Add(this.PathOpenButton);
            this.Controls.Add(this.AutoOpenBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GeneralErrorLabel);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.DriveErrorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DriveSelectBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Find your file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ComboBox DriveSelectBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DriveErrorLabel;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label GeneralErrorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox AutoOpenBox;
        private System.Windows.Forms.Button PathOpenButton;
    }
}

