

namespace ScriptEditor
{
	public partial class FormMain
	{
		//==================================================================================
		//	環境初期化
		//==================================================================================
		private void LoadEnvironment ()
		{
#if false
			LoadSetting ();     //設定ファイル初期化
#endif
			LoadCtrl ();        //コントロール初期化
			LoadTab ();         //タブ初期化

#if false
			LoadSubForm ();     //サブフォーム初期化
			SetEnvironment ();
#endif
		}

		//---------------------------------------------------------------------
		//	タブ初期化関連
		//---------------------------------------------------------------------

		//各タブの初期化
		private void LoadTab ()
		{
			TabCommand_Load ();
#if false
			TabAction_Load ();
			TabScript_A_Load ();
			TabEffect_Load ();
			TabScript_E_Load ();
			TabBranch_Load ();
			TabRoute_Load ();
#endif
		}


		//タブ_コマンドの初期化
		private void TabCommand_Load ()
		{
			//タブページに手動追加
			TabPage tp = tabControl1.TabPages [ (int) TAB_NAME.TAB_COMMAND ];
			tp.Controls.Add ( ctrl_Cmd );
		}

	}
}
