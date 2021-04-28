namespace ORSAPR
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
            this.components = new System.ComponentModel.Container();
            this.BuildButton = new System.Windows.Forms.Button();
            this.CaseLengthLabel1 = new System.Windows.Forms.Label();
            this.CaseDepthLabel1 = new System.Windows.Forms.Label();
            this.DoorLengthLabel1 = new System.Windows.Forms.Label();
            this.DiameterOfButtonsLabel1 = new System.Windows.Forms.Label();
            this.CaseLengthLabel = new System.Windows.Forms.Label();
            this.CaseDepthLabel = new System.Windows.Forms.Label();
            this.CaseHeightLabel = new System.Windows.Forms.Label();
            this.DoorLengthLabel = new System.Windows.Forms.Label();
            this.DiameterOfButtonsLabel = new System.Windows.Forms.Label();
            this.ErrorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CaseHeightLabel1 = new System.Windows.Forms.Label();
            this.ButtonLengthLabel1 = new System.Windows.Forms.Label();
            this.ButtonHeightLabel1 = new System.Windows.Forms.Label();
            this.ButtonLengthLabel = new System.Windows.Forms.Label();
            this.ButtonHeightLabel = new System.Windows.Forms.Label();
            this.DoorHeightLabel1 = new System.Windows.Forms.Label();
            this.DoorHeightLabel = new System.Windows.Forms.Label();
            this.CaseLengthTextBox = new System.Windows.Forms.TextBox();
            this.CaseDepthTextBox = new System.Windows.Forms.TextBox();
            this.CaseHeightTextBox = new System.Windows.Forms.TextBox();
            this.DiameterOfButtonsTextBox = new System.Windows.Forms.TextBox();
            this.ButtonLengthTextBox = new System.Windows.Forms.TextBox();
            this.ButtonHeightTextBox = new System.Windows.Forms.TextBox();
            this.DoorLengthTextBox = new System.Windows.Forms.TextBox();
            this.DoorHeightTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(115, 231);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(142, 34);
            this.BuildButton.TabIndex = 21;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // CaseLengthLabel1
            // 
            this.CaseLengthLabel1.AutoSize = true;
            this.CaseLengthLabel1.Location = new System.Drawing.Point(15, 9);
            this.CaseLengthLabel1.Name = "CaseLengthLabel1";
            this.CaseLengthLabel1.Size = new System.Drawing.Size(102, 13);
            this.CaseLengthLabel1.TabIndex = 5;
            this.CaseLengthLabel1.Text = "Длина корпуса (L):";
            // 
            // CaseDepthLabel1
            // 
            this.CaseDepthLabel1.AutoSize = true;
            this.CaseDepthLabel1.Location = new System.Drawing.Point(15, 36);
            this.CaseDepthLabel1.Name = "CaseDepthLabel1";
            this.CaseDepthLabel1.Size = new System.Drawing.Size(115, 13);
            this.CaseDepthLabel1.TabIndex = 6;
            this.CaseDepthLabel1.Text = "Глубина корпуса (W):";
            // 
            // DoorLengthLabel1
            // 
            this.DoorLengthLabel1.AutoSize = true;
            this.DoorLengthLabel1.Location = new System.Drawing.Point(15, 171);
            this.DoorLengthLabel1.Name = "DoorLengthLabel1";
            this.DoorLengthLabel1.Size = new System.Drawing.Size(99, 13);
            this.DoorLengthLabel1.TabIndex = 8;
            this.DoorLengthLabel1.Text = "Длина дверцы (L):";
            // 
            // DiameterOfButtonsLabel1
            // 
            this.DiameterOfButtonsLabel1.AutoSize = true;
            this.DiameterOfButtonsLabel1.Location = new System.Drawing.Point(15, 90);
            this.DiameterOfButtonsLabel1.Name = "DiameterOfButtonsLabel1";
            this.DiameterOfButtonsLabel1.Size = new System.Drawing.Size(112, 13);
            this.DiameterOfButtonsLabel1.TabIndex = 9;
            this.DiameterOfButtonsLabel1.Text = "Диаметр кнопок (D):";
            // 
            // CaseLengthLabel
            // 
            this.CaseLengthLabel.AutoSize = true;
            this.CaseLengthLabel.Location = new System.Drawing.Point(263, 9);
            this.CaseLengthLabel.Name = "CaseLengthLabel";
            this.CaseLengthLabel.Size = new System.Drawing.Size(74, 13);
            this.CaseLengthLabel.TabIndex = 15;
            this.CaseLengthLabel.Text = "400 - 500 мм.";
            // 
            // CaseDepthLabel
            // 
            this.CaseDepthLabel.AutoSize = true;
            this.CaseDepthLabel.Location = new System.Drawing.Point(263, 36);
            this.CaseDepthLabel.Name = "CaseDepthLabel";
            this.CaseDepthLabel.Size = new System.Drawing.Size(74, 13);
            this.CaseDepthLabel.TabIndex = 16;
            this.CaseDepthLabel.Text = "300 - 450 мм.";
            // 
            // CaseHeightLabel
            // 
            this.CaseHeightLabel.AutoSize = true;
            this.CaseHeightLabel.Location = new System.Drawing.Point(263, 63);
            this.CaseHeightLabel.Name = "CaseHeightLabel";
            this.CaseHeightLabel.Size = new System.Drawing.Size(74, 13);
            this.CaseHeightLabel.TabIndex = 17;
            this.CaseHeightLabel.Text = "250 - 300 мм.";
            // 
            // DoorLengthLabel
            // 
            this.DoorLengthLabel.AutoSize = true;
            this.DoorLengthLabel.Location = new System.Drawing.Point(263, 171);
            this.DoorLengthLabel.Name = "DoorLengthLabel";
            this.DoorLengthLabel.Size = new System.Drawing.Size(74, 13);
            this.DoorLengthLabel.TabIndex = 18;
            this.DoorLengthLabel.Text = "220 - 235 мм.";
            // 
            // DiameterOfButtonsLabel
            // 
            this.DiameterOfButtonsLabel.AutoSize = true;
            this.DiameterOfButtonsLabel.Location = new System.Drawing.Point(263, 90);
            this.DiameterOfButtonsLabel.Name = "DiameterOfButtonsLabel";
            this.DiameterOfButtonsLabel.Size = new System.Drawing.Size(62, 13);
            this.DiameterOfButtonsLabel.TabIndex = 19;
            this.DiameterOfButtonsLabel.Text = "20 - 40 мм.";
            // 
            // ErrorToolTip
            // 
            this.ErrorToolTip.AutoPopDelay = 0;
            this.ErrorToolTip.InitialDelay = 0;
            this.ErrorToolTip.ReshowDelay = 100;
            this.ErrorToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ErrorToolTip.ToolTipTitle = "Ошибка.";
            // 
            // CaseHeightLabel1
            // 
            this.CaseHeightLabel1.AutoSize = true;
            this.CaseHeightLabel1.Location = new System.Drawing.Point(15, 63);
            this.CaseHeightLabel1.Name = "CaseHeightLabel1";
            this.CaseHeightLabel1.Size = new System.Drawing.Size(109, 13);
            this.CaseHeightLabel1.TabIndex = 23;
            this.CaseHeightLabel1.Text = "Высота корпуса (H):";
            // 
            // ButtonLengthLabel1
            // 
            this.ButtonLengthLabel1.AutoSize = true;
            this.ButtonLengthLabel1.Location = new System.Drawing.Point(15, 117);
            this.ButtonLengthLabel1.Name = "ButtonLengthLabel1";
            this.ButtonLengthLabel1.Size = new System.Drawing.Size(104, 13);
            this.ButtonLengthLabel1.TabIndex = 24;
            this.ButtonLengthLabel1.Text = "Длина кнопки (LB):";
            // 
            // ButtonHeightLabel1
            // 
            this.ButtonHeightLabel1.AutoSize = true;
            this.ButtonHeightLabel1.Location = new System.Drawing.Point(15, 144);
            this.ButtonHeightLabel1.Name = "ButtonHeightLabel1";
            this.ButtonHeightLabel1.Size = new System.Drawing.Size(111, 13);
            this.ButtonHeightLabel1.TabIndex = 26;
            this.ButtonHeightLabel1.Text = "Высота кнопки (HB):";
            // 
            // ButtonLengthLabel
            // 
            this.ButtonLengthLabel.AutoSize = true;
            this.ButtonLengthLabel.Location = new System.Drawing.Point(263, 117);
            this.ButtonLengthLabel.Name = "ButtonLengthLabel";
            this.ButtonLengthLabel.Size = new System.Drawing.Size(68, 13);
            this.ButtonLengthLabel.TabIndex = 28;
            this.ButtonLengthLabel.Text = "60 - 100 мм.";
            // 
            // ButtonHeightLabel
            // 
            this.ButtonHeightLabel.AutoSize = true;
            this.ButtonHeightLabel.Location = new System.Drawing.Point(263, 144);
            this.ButtonHeightLabel.Name = "ButtonHeightLabel";
            this.ButtonHeightLabel.Size = new System.Drawing.Size(62, 13);
            this.ButtonHeightLabel.TabIndex = 29;
            this.ButtonHeightLabel.Text = "30 - 50 мм.";
            // 
            // DoorHeightLabel1
            // 
            this.DoorHeightLabel1.AutoSize = true;
            this.DoorHeightLabel1.Location = new System.Drawing.Point(15, 198);
            this.DoorHeightLabel1.Name = "DoorHeightLabel1";
            this.DoorHeightLabel1.Size = new System.Drawing.Size(106, 13);
            this.DoorHeightLabel1.TabIndex = 30;
            this.DoorHeightLabel1.Text = "Высота дверцы (H):";
            // 
            // DoorHeightLabel
            // 
            this.DoorHeightLabel.AutoSize = true;
            this.DoorHeightLabel.Location = new System.Drawing.Point(263, 198);
            this.DoorHeightLabel.Name = "DoorHeightLabel";
            this.DoorHeightLabel.Size = new System.Drawing.Size(74, 13);
            this.DoorHeightLabel.TabIndex = 32;
            this.DoorHeightLabel.Text = "200 - 225 мм.";
            // 
            // CaseLengthTextBox
            // 
            this.CaseLengthTextBox.Location = new System.Drawing.Point(136, 9);
            this.CaseLengthTextBox.Name = "CaseLengthTextBox";
            this.CaseLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.CaseLengthTextBox.TabIndex = 33;
            this.CaseLengthTextBox.TextChanged += new System.EventHandler(this.CaseLengthTextBox_TextChanged);
            // 
            // CaseDepthTextBox
            // 
            this.CaseDepthTextBox.Location = new System.Drawing.Point(136, 33);
            this.CaseDepthTextBox.Name = "CaseDepthTextBox";
            this.CaseDepthTextBox.Size = new System.Drawing.Size(100, 20);
            this.CaseDepthTextBox.TabIndex = 34;
            this.CaseDepthTextBox.TextChanged += new System.EventHandler(this.CaseDepthTextBox_TextChanged);
            // 
            // CaseHeightTextBox
            // 
            this.CaseHeightTextBox.Location = new System.Drawing.Point(136, 59);
            this.CaseHeightTextBox.Name = "CaseHeightTextBox";
            this.CaseHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.CaseHeightTextBox.TabIndex = 35;
            this.CaseHeightTextBox.TextChanged += new System.EventHandler(this.CaseHeightTextBox_TextChanged);
            // 
            // DiameterOfButtonsTextBox
            // 
            this.DiameterOfButtonsTextBox.Location = new System.Drawing.Point(136, 85);
            this.DiameterOfButtonsTextBox.Name = "DiameterOfButtonsTextBox";
            this.DiameterOfButtonsTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiameterOfButtonsTextBox.TabIndex = 36;
            this.DiameterOfButtonsTextBox.TextChanged += new System.EventHandler(this.DiameterOfButtonsTextBox_TextChanged);
            // 
            // ButtonLengthTextBox
            // 
            this.ButtonLengthTextBox.Location = new System.Drawing.Point(136, 114);
            this.ButtonLengthTextBox.Name = "ButtonLengthTextBox";
            this.ButtonLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.ButtonLengthTextBox.TabIndex = 37;
            this.ButtonLengthTextBox.TextChanged += new System.EventHandler(this.ButtonLengthTextBox_TextChanged);
            // 
            // ButtonHeightTextBox
            // 
            this.ButtonHeightTextBox.Location = new System.Drawing.Point(136, 141);
            this.ButtonHeightTextBox.Name = "ButtonHeightTextBox";
            this.ButtonHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.ButtonHeightTextBox.TabIndex = 38;
            this.ButtonHeightTextBox.TextChanged += new System.EventHandler(this.ButtonHeightTextBox_TextChanged);
            // 
            // DoorLengthTextBox
            // 
            this.DoorLengthTextBox.Location = new System.Drawing.Point(136, 169);
            this.DoorLengthTextBox.Name = "DoorLengthTextBox";
            this.DoorLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.DoorLengthTextBox.TabIndex = 39;
            this.DoorLengthTextBox.TextChanged += new System.EventHandler(this.DoorLengthTextBox_TextChanged);
            // 
            // DoorHeightTextBox
            // 
            this.DoorHeightTextBox.Location = new System.Drawing.Point(136, 195);
            this.DoorHeightTextBox.Name = "DoorHeightTextBox";
            this.DoorHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.DoorHeightTextBox.TabIndex = 40;
            this.DoorHeightTextBox.TextChanged += new System.EventHandler(this.DoorHeightTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 271);
            this.Controls.Add(this.DoorHeightTextBox);
            this.Controls.Add(this.DoorLengthTextBox);
            this.Controls.Add(this.ButtonHeightTextBox);
            this.Controls.Add(this.ButtonLengthTextBox);
            this.Controls.Add(this.DiameterOfButtonsTextBox);
            this.Controls.Add(this.CaseHeightTextBox);
            this.Controls.Add(this.CaseDepthTextBox);
            this.Controls.Add(this.CaseLengthTextBox);
            this.Controls.Add(this.DoorHeightLabel);
            this.Controls.Add(this.DoorHeightLabel1);
            this.Controls.Add(this.ButtonHeightLabel);
            this.Controls.Add(this.ButtonLengthLabel);
            this.Controls.Add(this.ButtonHeightLabel1);
            this.Controls.Add(this.ButtonLengthLabel1);
            this.Controls.Add(this.CaseHeightLabel1);
            this.Controls.Add(this.DiameterOfButtonsLabel);
            this.Controls.Add(this.DoorLengthLabel);
            this.Controls.Add(this.CaseHeightLabel);
            this.Controls.Add(this.CaseDepthLabel);
            this.Controls.Add(this.CaseLengthLabel);
            this.Controls.Add(this.DiameterOfButtonsLabel1);
            this.Controls.Add(this.DoorLengthLabel1);
            this.Controls.Add(this.CaseDepthLabel1);
            this.Controls.Add(this.CaseLengthLabel1);
            this.Controls.Add(this.BuildButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(372, 310);
            this.MinimumSize = new System.Drawing.Size(372, 310);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Микроволновка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Label CaseLengthLabel1;
        private System.Windows.Forms.Label CaseDepthLabel1;
        private System.Windows.Forms.Label DoorLengthLabel1;
        private System.Windows.Forms.Label DiameterOfButtonsLabel1;
        private System.Windows.Forms.Label CaseLengthLabel;
        private System.Windows.Forms.Label CaseDepthLabel;
        private System.Windows.Forms.Label CaseHeightLabel;
        private System.Windows.Forms.Label DoorLengthLabel;
        private System.Windows.Forms.Label DiameterOfButtonsLabel;
        private System.Windows.Forms.ToolTip ErrorToolTip;
        private System.Windows.Forms.Label CaseHeightLabel1;
        private System.Windows.Forms.Label ButtonLengthLabel1;
        private System.Windows.Forms.Label ButtonHeightLabel1;
        private System.Windows.Forms.Label ButtonLengthLabel;
        private System.Windows.Forms.Label ButtonHeightLabel;
        private System.Windows.Forms.Label DoorHeightLabel1;
        private System.Windows.Forms.Label DoorHeightLabel;
        private System.Windows.Forms.TextBox CaseLengthTextBox;
        private System.Windows.Forms.TextBox CaseDepthTextBox;
        private System.Windows.Forms.TextBox CaseHeightTextBox;
        private System.Windows.Forms.TextBox DiameterOfButtonsTextBox;
        private System.Windows.Forms.TextBox ButtonLengthTextBox;
        private System.Windows.Forms.TextBox ButtonHeightTextBox;
        private System.Windows.Forms.TextBox DoorLengthTextBox;
        private System.Windows.Forms.TextBox DoorHeightTextBox;
    }
}

