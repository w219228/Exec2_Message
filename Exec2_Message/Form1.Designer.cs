﻿namespace Exec2_Message
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
			this.displayButton = new System.Windows.Forms.Button();
			this.timeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// displayButton
			// 
			this.displayButton.Location = new System.Drawing.Point(108, 138);
			this.displayButton.Name = "displayButton";
			this.displayButton.Size = new System.Drawing.Size(75, 23);
			this.displayButton.TabIndex = 0;
			this.displayButton.Text = "顯示";
			this.displayButton.UseVisualStyleBackColor = true;
			this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
			// 
			// timeLabel
			// 
			this.timeLabel.Font = new System.Drawing.Font("新細明體", 10F);
			this.timeLabel.Location = new System.Drawing.Point(53, 63);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(192, 41);
			this.timeLabel.TabIndex = 1;
			this.timeLabel.Text = "timeLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 213);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.displayButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button displayButton;
		private System.Windows.Forms.Label timeLabel;
	}
}

