namespace Client
{
    partial class Game
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ThirdLastTurn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SecondLastTurn = new System.Windows.Forms.PictureBox();
            this.LastTurn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdLastTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondLastTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.ForestGreen;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(157, 659);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1240, 120);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ThirdLastTurn
            // 
            this.ThirdLastTurn.Location = new System.Drawing.Point(598, 336);
            this.ThirdLastTurn.Name = "ThirdLastTurn";
            this.ThirdLastTurn.Size = new System.Drawing.Size(100, 119);
            this.ThirdLastTurn.TabIndex = 2;
            this.ThirdLastTurn.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(689, 336);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // SecondLastTurn
            // 
            this.SecondLastTurn.Location = new System.Drawing.Point(642, 336);
            this.SecondLastTurn.Name = "SecondLastTurn";
            this.SecondLastTurn.Size = new System.Drawing.Size(100, 119);
            this.SecondLastTurn.TabIndex = 4;
            this.SecondLastTurn.TabStop = false;
            // 
            // LastTurn
            // 
            this.LastTurn.Location = new System.Drawing.Point(689, 336);
            this.LastTurn.Name = "LastTurn";
            this.LastTurn.Size = new System.Drawing.Size(100, 119);
            this.LastTurn.TabIndex = 5;
            this.LastTurn.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1633, 794);
            this.Controls.Add(this.LastTurn);
            this.Controls.Add(this.SecondLastTurn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ThirdLastTurn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.ThirdLastTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondLastTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastTurn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox ThirdLastTurn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox SecondLastTurn;
        private System.Windows.Forms.PictureBox LastTurn;
    }
}