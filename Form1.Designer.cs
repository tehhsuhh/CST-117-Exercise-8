namespace CST_117_Exercise_8
{
    partial class CaloriesCalcForm
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
            this.carbCaloriesOutputLabel = new System.Windows.Forms.Label();
            this.fatCaloriesOutputLabel = new System.Windows.Forms.Label();
            this.ToolBarTextAlignCaloriesLabel = new System.Windows.Forms.Label();
            this.carbGramTextBox = new System.Windows.Forms.TextBox();
            this.fatGramTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carbCaloriesOutputLabel
            // 
            this.carbCaloriesOutputLabel.Location = new System.Drawing.Point(66, 139);
            this.carbCaloriesOutputLabel.Name = "carbCaloriesOutputLabel";
            this.carbCaloriesOutputLabel.Size = new System.Drawing.Size(157, 23);
            this.carbCaloriesOutputLabel.TabIndex = 1;
            this.carbCaloriesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatCaloriesOutputLabel
            // 
            this.fatCaloriesOutputLabel.Location = new System.Drawing.Point(66, 162);
            this.fatCaloriesOutputLabel.Name = "fatCaloriesOutputLabel";
            this.fatCaloriesOutputLabel.Size = new System.Drawing.Size(157, 23);
            this.fatCaloriesOutputLabel.TabIndex = 2;
            this.fatCaloriesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToolBarTextAlignCaloriesLabel
            // 
            this.ToolBarTextAlignCaloriesLabel.Location = new System.Drawing.Point(66, 185);
            this.ToolBarTextAlignCaloriesLabel.Name = "ToolBarTextAlignCaloriesLabel";
            this.ToolBarTextAlignCaloriesLabel.Size = new System.Drawing.Size(157, 25);
            this.ToolBarTextAlignCaloriesLabel.TabIndex = 3;
            this.ToolBarTextAlignCaloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carbGramTextBox
            // 
            this.carbGramTextBox.Location = new System.Drawing.Point(89, 40);
            this.carbGramTextBox.Name = "carbGramTextBox";
            this.carbGramTextBox.Size = new System.Drawing.Size(100, 20);
            this.carbGramTextBox.TabIndex = 4;
            this.carbGramTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fatGramTextBox
            // 
            this.fatGramTextBox.Location = new System.Drawing.Point(78, 79);
            this.fatGramTextBox.Name = "fatGramTextBox";
            this.fatGramTextBox.Size = new System.Drawing.Size(127, 20);
            this.fatGramTextBox.TabIndex = 5;
            this.fatGramTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(105, 113);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Total Number of Fat Grams ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Total Number of Carb Grams";
            // 
            // CaloriesCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.fatGramTextBox);
            this.Controls.Add(this.carbGramTextBox);
            this.Controls.Add(this.ToolBarTextAlignCaloriesLabel);
            this.Controls.Add(this.fatCaloriesOutputLabel);
            this.Controls.Add(this.carbCaloriesOutputLabel);
            this.Name = "CaloriesCalcForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label carbCaloriesOutputLabel;
        private System.Windows.Forms.Label fatCaloriesOutputLabel;
        private System.Windows.Forms.Label ToolBarTextAlignCaloriesLabel;
        private System.Windows.Forms.TextBox carbGramTextBox;
        private System.Windows.Forms.TextBox fatGramTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

