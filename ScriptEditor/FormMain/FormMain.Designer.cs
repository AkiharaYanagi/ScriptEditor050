namespace ScriptEditor
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			menuStrip1 = new MenuStrip ();
			フォルダFToolStripMenuItem = new ToolStripMenuItem ();
			上書保存SToolStripMenuItem = new ToolStripMenuItem ();
			特殊保存ToolStripMenuItem = new ToolStripMenuItem ();
			読込ToolStripMenuItem = new ToolStripMenuItem ();
			特殊読込ToolStripMenuItem = new ToolStripMenuItem ();
			名前チェックCToolStripMenuItem = new ToolStripMenuItem ();
			statusStrip1 = new StatusStrip ();
			toolStripStatusLabel1 = new ToolStripStatusLabel ();
			openFileDialog1 = new OpenFileDialog ();
			saveFileDialog1 = new SaveFileDialog ();
			tabControl1 = new TabControl ();
			tabRoute = new TabPage ();
			tabBranch = new TabPage ();
			tabCommand = new TabPage ();
			tabFrameE = new TabPage ();
			tabEffect = new TabPage ();
			tabFrameA = new TabPage ();
			tabAction = new TabPage ();
			menuStrip1.SuspendLayout ();
			statusStrip1.SuspendLayout ();
			tabControl1.SuspendLayout ();
			SuspendLayout ();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange ( new ToolStripItem [] { フォルダFToolStripMenuItem, 上書保存SToolStripMenuItem, 特殊保存ToolStripMenuItem, 読込ToolStripMenuItem, 特殊読込ToolStripMenuItem, 名前チェックCToolStripMenuItem } );
			menuStrip1.Location = new Point ( 0, 0 );
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size ( 766, 24 );
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// フォルダFToolStripMenuItem
			// 
			フォルダFToolStripMenuItem.Name = "フォルダFToolStripMenuItem";
			フォルダFToolStripMenuItem.Size = new Size ( 68, 20 );
			フォルダFToolStripMenuItem.Text = "フォルダ(&F)";
			フォルダFToolStripMenuItem.Click +=  フォルダFToolStripMenuItem_Click ;
			// 
			// 上書保存SToolStripMenuItem
			// 
			上書保存SToolStripMenuItem.BackColor = Color.FromArgb (   192,   192,   255 );
			上書保存SToolStripMenuItem.Name = "上書保存SToolStripMenuItem";
			上書保存SToolStripMenuItem.Size = new Size ( 81, 20 );
			上書保存SToolStripMenuItem.Text = "上書保存(&S)";
			上書保存SToolStripMenuItem.Click +=  上書保存SToolStripMenuItem_Click ;
			// 
			// 特殊保存ToolStripMenuItem
			// 
			特殊保存ToolStripMenuItem.BackColor = Color.FromArgb (   192,   192,   255 );
			特殊保存ToolStripMenuItem.Name = "特殊保存ToolStripMenuItem";
			特殊保存ToolStripMenuItem.Size = new Size ( 83, 20 );
			特殊保存ToolStripMenuItem.Text = "特殊保存(&A)";
			// 
			// 読込ToolStripMenuItem
			// 
			読込ToolStripMenuItem.BackColor = Color.FromArgb (   255,   255,   192 );
			読込ToolStripMenuItem.Name = "読込ToolStripMenuItem";
			読込ToolStripMenuItem.Size = new Size ( 60, 20 );
			読込ToolStripMenuItem.Text = "読込(&O)";
			読込ToolStripMenuItem.Click +=  読込ToolStripMenuItem_Click ;
			// 
			// 特殊読込ToolStripMenuItem
			// 
			特殊読込ToolStripMenuItem.BackColor = Color.FromArgb (   255,   255,   192 );
			特殊読込ToolStripMenuItem.Name = "特殊読込ToolStripMenuItem";
			特殊読込ToolStripMenuItem.Size = new Size ( 81, 20 );
			特殊読込ToolStripMenuItem.Text = "特殊読込(&T)";
			// 
			// 名前チェックCToolStripMenuItem
			// 
			名前チェックCToolStripMenuItem.Name = "名前チェックCToolStripMenuItem";
			名前チェックCToolStripMenuItem.Size = new Size ( 91, 20 );
			名前チェックCToolStripMenuItem.Text = "名前チェック(&C)";
			名前チェックCToolStripMenuItem.Click +=  名前チェックCToolStripMenuItem_Click ;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange ( new ToolStripItem [] { toolStripStatusLabel1 } );
			statusStrip1.Location = new Point ( 0, 512 );
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size ( 766, 22 );
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size ( 27, 17 );
			toolStripStatusLabel1.Text = "Init.";
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// tabControl1
			// 
			tabControl1.Anchor =     AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
			tabControl1.Controls.Add ( tabAction );
			tabControl1.Controls.Add ( tabFrameA );
			tabControl1.Controls.Add ( tabEffect );
			tabControl1.Controls.Add ( tabFrameE );
			tabControl1.Controls.Add ( tabCommand );
			tabControl1.Controls.Add ( tabBranch );
			tabControl1.Controls.Add ( tabRoute );
			tabControl1.Location = new Point ( 0, 27 );
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size ( 766, 482 );
			tabControl1.TabIndex = 2;
			// 
			// tabRoute
			// 
			tabRoute.Location = new Point ( 4, 24 );
			tabRoute.Name = "tabRoute";
			tabRoute.Size = new Size ( 750, 426 );
			tabRoute.TabIndex = 6;
			tabRoute.Text = "ルート";
			tabRoute.UseVisualStyleBackColor = true;
			// 
			// tabBranch
			// 
			tabBranch.Location = new Point ( 4, 24 );
			tabBranch.Name = "tabBranch";
			tabBranch.Size = new Size ( 750, 426 );
			tabBranch.TabIndex = 5;
			tabBranch.Text = "ブランチ";
			tabBranch.UseVisualStyleBackColor = true;
			// 
			// tabCommand
			// 
			tabCommand.Location = new Point ( 4, 24 );
			tabCommand.Name = "tabCommand";
			tabCommand.Size = new Size ( 750, 426 );
			tabCommand.TabIndex = 4;
			tabCommand.Text = "コマンド";
			tabCommand.UseVisualStyleBackColor = true;
			// 
			// tabFrameE
			// 
			tabFrameE.Location = new Point ( 4, 24 );
			tabFrameE.Name = "tabFrameE";
			tabFrameE.Size = new Size ( 750, 426 );
			tabFrameE.TabIndex = 3;
			tabFrameE.Text = "->フレーム(E)";
			tabFrameE.UseVisualStyleBackColor = true;
			// 
			// tabEffect
			// 
			tabEffect.Location = new Point ( 4, 24 );
			tabEffect.Name = "tabEffect";
			tabEffect.Size = new Size ( 750, 426 );
			tabEffect.TabIndex = 2;
			tabEffect.Text = "エフェクト";
			tabEffect.UseVisualStyleBackColor = true;
			// 
			// tabFrameA
			// 
			tabFrameA.Location = new Point ( 4, 24 );
			tabFrameA.Name = "tabFrameA";
			tabFrameA.Padding = new Padding ( 3 );
			tabFrameA.Size = new Size ( 750, 426 );
			tabFrameA.TabIndex = 1;
			tabFrameA.Text = "->フレーム(A)";
			tabFrameA.UseVisualStyleBackColor = true;
			// 
			// tabAction
			// 
			tabAction.Location = new Point ( 4, 24 );
			tabAction.Name = "tabAction";
			tabAction.Padding = new Padding ( 3 );
			tabAction.Size = new Size ( 758, 454 );
			tabAction.TabIndex = 0;
			tabAction.Text = "アクション";
			tabAction.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF ( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size ( 766, 534 );
			Controls.Add ( tabControl1 );
			Controls.Add ( statusStrip1 );
			Controls.Add ( menuStrip1 );
			MainMenuStrip = menuStrip1;
			Name = "FormMain";
			Text = "FormMain";
			menuStrip1.ResumeLayout ( false );
			menuStrip1.PerformLayout ();
			statusStrip1.ResumeLayout ( false );
			statusStrip1.PerformLayout ();
			tabControl1.ResumeLayout ( false );
			ResumeLayout ( false );
			PerformLayout ();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem フォルダFToolStripMenuItem;
		private ToolStripMenuItem 上書保存SToolStripMenuItem;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripMenuItem 特殊保存ToolStripMenuItem;
		private ToolStripMenuItem 読込ToolStripMenuItem;
		private ToolStripMenuItem 特殊読込ToolStripMenuItem;
		private ToolStripMenuItem 名前チェックCToolStripMenuItem;
		private OpenFileDialog openFileDialog1;
		private SaveFileDialog saveFileDialog1;
		private TabControl tabControl1;
		private TabPage tabAction;
		private TabPage tabFrameA;
		private TabPage tabEffect;
		private TabPage tabFrameE;
		private TabPage tabCommand;
		private TabPage tabBranch;
		private TabPage tabRoute;
	}
}