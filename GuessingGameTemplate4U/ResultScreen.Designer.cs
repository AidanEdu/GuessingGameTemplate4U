namespace GuessingGameTemplate4U
{
    partial class ResultScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultLabel = new System.Windows.Forms.Label();
            this.nameLabelOne = new System.Windows.Forms.Label();
            this.orginalOrderLabel = new System.Windows.Forms.Label();
            this.sortedOrderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.guessCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(67, 45);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(129, 46);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Results";
            this.resultLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // nameLabelOne
            // 
            this.nameLabelOne.AutoSize = true;
            this.nameLabelOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabelOne.ForeColor = System.Drawing.Color.White;
            this.nameLabelOne.Location = new System.Drawing.Point(37, 118);
            this.nameLabelOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabelOne.Name = "nameLabelOne";
            this.nameLabelOne.Size = new System.Drawing.Size(138, 28);
            this.nameLabelOne.TabIndex = 7;
            this.nameLabelOne.Text = "Original Order";
            // 
            // orginalOrderLabel
            // 
            this.orginalOrderLabel.AutoSize = true;
            this.orginalOrderLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orginalOrderLabel.ForeColor = System.Drawing.Color.White;
            this.orginalOrderLabel.Location = new System.Drawing.Point(37, 146);
            this.orginalOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orginalOrderLabel.Name = "orginalOrderLabel";
            this.orginalOrderLabel.Size = new System.Drawing.Size(0, 23);
            this.orginalOrderLabel.TabIndex = 8;
            // 
            // sortedOrderLabel
            // 
            this.sortedOrderLabel.AutoSize = true;
            this.sortedOrderLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortedOrderLabel.ForeColor = System.Drawing.Color.White;
            this.sortedOrderLabel.Location = new System.Drawing.Point(38, 252);
            this.sortedOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortedOrderLabel.Name = "sortedOrderLabel";
            this.sortedOrderLabel.Size = new System.Drawing.Size(0, 23);
            this.sortedOrderLabel.TabIndex = 10;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(38, 224);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(127, 28);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Sorted Order";
            // 
            // guessCountLabel
            // 
            this.guessCountLabel.AutoSize = true;
            this.guessCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessCountLabel.ForeColor = System.Drawing.Color.White;
            this.guessCountLabel.Location = new System.Drawing.Point(38, 313);
            this.guessCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guessCountLabel.Name = "guessCountLabel";
            this.guessCountLabel.Size = new System.Drawing.Size(127, 28);
            this.guessCountLabel.TabIndex = 11;
            this.guessCountLabel.Text = "Sorted Order";
            // 
            // ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.guessCountLabel);
            this.Controls.Add(this.sortedOrderLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.orginalOrderLabel);
            this.Controls.Add(this.nameLabelOne);
            this.Controls.Add(this.resultLabel);
            this.Name = "ResultScreen";
            this.Size = new System.Drawing.Size(400, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label nameLabelOne;
        private System.Windows.Forms.Label orginalOrderLabel;
        private System.Windows.Forms.Label sortedOrderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label guessCountLabel;
    }
}
