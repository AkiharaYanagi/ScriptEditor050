using ScriptEditorUtility;
using Chara050;


namespace ScriptEditor
{
	public partial class FormMain
	{

		private void フォルダFToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			FormUtility.OpenCurrentDir ();
		}

		private void 上書保存SToolStripMenuItem_Click ( object sender, EventArgs e )
		{

		}

		private void 読込ToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			//ダイアログ中の初期ファイル名
	//		openFileDialog1.FileName = stgs.LastFilepath;
			openFileDialog1.Title = "読込 ( *.dat )";
			openFileDialog1.DefaultExt = "dat";
			openFileDialog1.Filter = "キャラデータファイル(*.dat)|*.dat";

			//ダイアログ開始
			if ( openFileDialog1.ShowDialog () == DialogResult.OK )
			{
				LoadCharaBin lcb = new LoadCharaBin ();
				lcb.Do ( openFileDialog1.FileName, chara );
	//			SavePath_Stg ( openFileDialog1.FileName );      //パスの保存
			}
		}

		private void 名前チェックCToolStripMenuItem_Click ( object sender, EventArgs e )
		{

		}

	}
}
