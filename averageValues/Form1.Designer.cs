
namespace averageValues
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Honeydew;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.titleLabel.Location = new System.Drawing.Point(0, -3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(600, 88);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Average Number Solver";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a Number and Press Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "(enter 0 and press Add to calculate average)";
            // 
            // addInput
            // 
            this.addInput.Location = new System.Drawing.Point(167, 237);
            this.addInput.Name = "addInput";
            this.addInput.Size = new System.Drawing.Size(128, 26);
            this.addInput.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightCyan;
            this.addButton.Location = new System.Drawing.Point(321, 228);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 45);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput.Location = new System.Drawing.Point(103, 311);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(385, 80);
            this.textOutput.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.LightCyan;
            this.resetButton.Location = new System.Drawing.Point(482, 478);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(107, 44);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 534);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label textOutput;
        private System.Windows.Forms.Button resetButton;
    }
}

