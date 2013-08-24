﻿namespace VixenModules.App.SuperScheduler
{
	partial class StatusForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonViewLog = new System.Windows.Forms.Button();
			this.buttonNextSong = new System.Windows.Forms.Button();
			this.buttonPauseShow = new System.Windows.Forms.Button();
			this.buttonStopGracefully = new System.Windows.Forms.Button();
			this.buttonStopNow = new System.Windows.Forms.Button();
			this.labelStatus = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonPlayShowGracefully = new System.Windows.Forms.Button();
			this.buttonPlayShowNow = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxShows = new System.Windows.Forms.ComboBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.listBoxLog = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.buttonViewLog);
			this.groupBox1.Controls.Add(this.buttonNextSong);
			this.groupBox1.Controls.Add(this.buttonPauseShow);
			this.groupBox1.Controls.Add(this.buttonStopGracefully);
			this.groupBox1.Controls.Add(this.buttonStopNow);
			this.groupBox1.Controls.Add(this.labelStatus);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(397, 60);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Show Status";
			// 
			// buttonViewLog
			// 
			this.buttonViewLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonViewLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonViewLog.BackgroundImage")));
			this.buttonViewLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonViewLog.Cursor = System.Windows.Forms.Cursors.Default;
			this.buttonViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonViewLog.Location = new System.Drawing.Point(363, 21);
			this.buttonViewLog.Name = "buttonViewLog";
			this.buttonViewLog.Size = new System.Drawing.Size(24, 24);
			this.buttonViewLog.TabIndex = 7;
			this.toolTip1.SetToolTip(this.buttonViewLog, "View Log");
			this.buttonViewLog.UseVisualStyleBackColor = true;
			this.buttonViewLog.Click += new System.EventHandler(this.buttonViewLog_Click);
			// 
			// buttonNextSong
			// 
			this.buttonNextSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonNextSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNextSong.BackgroundImage")));
			this.buttonNextSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonNextSong.Cursor = System.Windows.Forms.Cursors.Default;
			this.buttonNextSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNextSong.Location = new System.Drawing.Point(338, 21);
			this.buttonNextSong.Name = "buttonNextSong";
			this.buttonNextSong.Size = new System.Drawing.Size(24, 24);
			this.buttonNextSong.TabIndex = 6;
			this.toolTip1.SetToolTip(this.buttonNextSong, "Skip to the Next Item");
			this.buttonNextSong.UseVisualStyleBackColor = true;
			// 
			// buttonPauseShow
			// 
			this.buttonPauseShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPauseShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPauseShow.BackgroundImage")));
			this.buttonPauseShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonPauseShow.Cursor = System.Windows.Forms.Cursors.Default;
			this.buttonPauseShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPauseShow.Location = new System.Drawing.Point(313, 21);
			this.buttonPauseShow.Name = "buttonPauseShow";
			this.buttonPauseShow.Size = new System.Drawing.Size(24, 24);
			this.buttonPauseShow.TabIndex = 5;
			this.toolTip1.SetToolTip(this.buttonPauseShow, "Pause the Current Show");
			this.buttonPauseShow.UseVisualStyleBackColor = true;
			// 
			// buttonStopGracefully
			// 
			this.buttonStopGracefully.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStopGracefully.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStopGracefully.BackgroundImage")));
			this.buttonStopGracefully.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonStopGracefully.Cursor = System.Windows.Forms.Cursors.Default;
			this.buttonStopGracefully.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStopGracefully.Location = new System.Drawing.Point(288, 21);
			this.buttonStopGracefully.Name = "buttonStopGracefully";
			this.buttonStopGracefully.Size = new System.Drawing.Size(24, 24);
			this.buttonStopGracefully.TabIndex = 4;
			this.toolTip1.SetToolTip(this.buttonStopGracefully, "Stop Show Gracefully");
			this.buttonStopGracefully.UseVisualStyleBackColor = true;
			this.buttonStopGracefully.Click += new System.EventHandler(this.buttonStopGracefully_Click);
			// 
			// buttonStopNow
			// 
			this.buttonStopNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStopNow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStopNow.BackgroundImage")));
			this.buttonStopNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonStopNow.Cursor = System.Windows.Forms.Cursors.Default;
			this.buttonStopNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStopNow.Location = new System.Drawing.Point(263, 21);
			this.buttonStopNow.Name = "buttonStopNow";
			this.buttonStopNow.Size = new System.Drawing.Size(24, 24);
			this.buttonStopNow.TabIndex = 2;
			this.toolTip1.SetToolTip(this.buttonStopNow, "Stop Show Immediately");
			this.buttonStopNow.UseVisualStyleBackColor = true;
			this.buttonStopNow.Click += new System.EventHandler(this.buttonStopNow_Click);
			// 
			// labelStatus
			// 
			this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelStatus.Location = new System.Drawing.Point(59, 26);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(198, 13);
			this.labelStatus.TabIndex = 1;
			this.labelStatus.Text = "Waiting to run next show...";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Status:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.buttonPlayShowGracefully);
			this.groupBox2.Controls.Add(this.buttonPlayShowNow);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.comboBoxShows);
			this.groupBox2.Location = new System.Drawing.Point(12, 78);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(397, 53);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Show Control";
			// 
			// buttonPlayShowGracefully
			// 
			this.buttonPlayShowGracefully.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPlayShowGracefully.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayShowGracefully.BackgroundImage")));
			this.buttonPlayShowGracefully.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonPlayShowGracefully.Cursor = System.Windows.Forms.Cursors.Default;
			this.buttonPlayShowGracefully.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPlayShowGracefully.Location = new System.Drawing.Point(363, 18);
			this.buttonPlayShowGracefully.Name = "buttonPlayShowGracefully";
			this.buttonPlayShowGracefully.Size = new System.Drawing.Size(24, 24);
			this.buttonPlayShowGracefully.TabIndex = 6;
			this.toolTip1.SetToolTip(this.buttonPlayShowGracefully, "Stop the Current Show Gracefully and Run the Selected Show");
			this.buttonPlayShowGracefully.UseVisualStyleBackColor = true;
			// 
			// buttonPlayShowNow
			// 
			this.buttonPlayShowNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPlayShowNow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayShowNow.BackgroundImage")));
			this.buttonPlayShowNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonPlayShowNow.Cursor = System.Windows.Forms.Cursors.Default;
			this.buttonPlayShowNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPlayShowNow.Location = new System.Drawing.Point(338, 18);
			this.buttonPlayShowNow.Name = "buttonPlayShowNow";
			this.buttonPlayShowNow.Size = new System.Drawing.Size(24, 24);
			this.buttonPlayShowNow.TabIndex = 5;
			this.toolTip1.SetToolTip(this.buttonPlayShowNow, "Stop the Current Show Immediately and Run the Selected Show");
			this.buttonPlayShowNow.UseVisualStyleBackColor = true;
			this.buttonPlayShowNow.Click += new System.EventHandler(this.buttonPlayShowNow_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(9, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Shows:";
			// 
			// comboBoxShows
			// 
			this.comboBoxShows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxShows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxShows.FormattingEnabled = true;
			this.comboBoxShows.Location = new System.Drawing.Point(63, 21);
			this.comboBoxShows.Name = "comboBoxShows";
			this.comboBoxShows.Size = new System.Drawing.Size(269, 21);
			this.comboBoxShows.TabIndex = 0;
			this.comboBoxShows.DropDown += new System.EventHandler(this.comboBoxShows_DropDown);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.listBoxLog);
			this.groupBox3.Location = new System.Drawing.Point(12, 137);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(397, 0);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Log";
			// 
			// listBoxLog
			// 
			this.listBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxLog.FormattingEnabled = true;
			this.listBoxLog.Location = new System.Drawing.Point(6, 23);
			this.listBoxLog.Name = "listBoxLog";
			this.listBoxLog.Size = new System.Drawing.Size(385, 4);
			this.listBoxLog.TabIndex = 0;
			// 
			// StatusForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 143);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "StatusForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Scheduler Status";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatusForm_FormClosing);
			this.Load += new System.EventHandler(this.StatusForm_Load);
			this.LocationChanged += new System.EventHandler(this.StatusForm_LocationChanged);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonStopGracefully;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button buttonStopNow;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonPlayShowGracefully;
		private System.Windows.Forms.Button buttonPlayShowNow;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxShows;
		private System.Windows.Forms.Button buttonNextSong;
		private System.Windows.Forms.Button buttonPauseShow;
		private System.Windows.Forms.Button buttonViewLog;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox listBoxLog;
	}
}