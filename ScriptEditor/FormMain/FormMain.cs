using ScriptEditorUtility;
using Chara050;


namespace ScriptEditor
{
	public partial class FormMain : Form
	{
		//==================================================================================
		//	メンバ変数
		//==================================================================================
		private Chara chara = new Chara ();


		//==================================================================================
		//	コンストラクタ
		//==================================================================================
		public FormMain ()
		{
			//フォーム開始位置をマウス位置にする
			FormUtility.InitPosition ( this );

			//コンポーネントの初期化
			InitializeComponent ();

			//環境初期化
			LoadEnvironment ();

			//開始設定
			Init ();

#if false
			//キャラ初期化環境の選択
			EstablishChara ();

			//表示
			Disp ();
#endif
		}
	}
}
