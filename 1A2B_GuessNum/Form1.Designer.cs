using System;

namespace _1A2B_GuessNum
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.keyInBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.guessColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.testLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9F);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess Number:";
            // 
            // keyInBox
            // 
            this.keyInBox.Location = new System.Drawing.Point(112, 36);
            this.keyInBox.Name = "keyInBox";
            this.keyInBox.ShortcutsEnabled = false;
            this.keyInBox.Size = new System.Drawing.Size(74, 25);
            this.keyInBox.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.guessColumn,
            this.resultColumn});
            this.listView1.Location = new System.Drawing.Point(15, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(257, 186);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // guessColumn
            // 
            this.guessColumn.Text = "Guess Number";
            this.guessColumn.Width = 126;
            // 
            // resultColumn
            // 
            this.resultColumn.Text = "Result";
            this.resultColumn.Width = 153;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(12, 9);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(50, 15);
            this.testLabel.TabIndex = 4;
            this.testLabel.Text = "Answer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guess";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.keyInBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Guess Number Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyInBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader guessColumn;
        private System.Windows.Forms.ColumnHeader resultColumn;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button button1;
    }
}

