using ScriptEditorUtility;


namespace ScriptEditor
{
	public partial class FormMain : Form
	{
		//==================================================================================
		//	繰り返し可能な開始設定
		//==================================================================================

		private void Init ()
		{
			//ステータスバーテキストを登録
			STS_TXT.Tssl = toolStripStatusLabel1;
			STS_TXT.SaveContorlColor ();
			STS_TXT.Trace ( "開始." );

#if false
			//タブの選択
			tabAction_Selected ();  //選択イベントは発生しないので手動で呼ぶ
			tabControl1.SelectedIndex = (int) TAB_NAME.TAB_ACTION;

			//サブフォームの初期表示
			ShowSubForms ();
#endif
		}
	}
}
