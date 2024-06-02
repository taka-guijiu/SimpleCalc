
namespace SimpleCalc
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Input1TextBox = new System.Windows.Forms.TextBox();
            this.Input2TextBox = new System.Windows.Forms.TextBox();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input1TextBox
            // 
            this.Input1TextBox.Location = new System.Drawing.Point(46, 70);
            this.Input1TextBox.Name = "Input1TextBox";
            this.Input1TextBox.Size = new System.Drawing.Size(128, 19);
            this.Input1TextBox.TabIndex = 0;
            // 
            // Input2TextBox
            // 
            this.Input2TextBox.Location = new System.Drawing.Point(262, 70);
            this.Input2TextBox.Name = "Input2TextBox";
            this.Input2TextBox.Size = new System.Drawing.Size(128, 19);
            this.Input2TextBox.TabIndex = 1;
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(457, 70);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(128, 19);
            this.AnswerTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "＋";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "＝";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(47, 132);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(538, 45);
            this.CalcButton.TabIndex = 5;
            this.CalcButton.Text = "計算する";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.Input2TextBox);
            this.Controls.Add(this.Input1TextBox);
            this.Name = "Form1";
            this.Text = "簡単計算プログラム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1TextBox;
        private System.Windows.Forms.TextBox Input2TextBox;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalcButton;
    }
}

