using ScriptEditorUtility;


namespace ScriptEditor
{
	public partial class FormMain : Form
	{
		//-------------------------------------------------------
		//各コントロール 実体
		private Ctrl_CmdList ctrl_Cmd = new Ctrl_CmdList ();



		//コントロール登録
		public void LoadCtrl ()
		{
#if false
			//コントロールの全体監理に渡す
			All_Ctrl.Inst.SqcList_Act = ctrl_SqcList_Act;
			All_Ctrl.Inst.Compend_Bhv = ctrl_cmpd_bhv;
			All_Ctrl.Inst.SqcList_Efc = ctrl_SqcList_Efc;
			All_Ctrl.Inst.Compend_Gns = ctrl_cmpd_gns;
			All_Ctrl.Inst.Cmd = ctrl_Cmd;
			All_Ctrl.Inst.Brc = ctrl_Brc;
			All_Ctrl.Inst.Rut = ctrl_Rut;

			All_Ctrl.Inst.Scp = ctrl_Scp;
			All_Ctrl.Inst.Rct = ctrl_Rct;
			All_Ctrl.Inst.ScpRut = ctrl_scpRut;
			All_Ctrl.Inst.EfGnrt = ctrl_efgnrt;

#endif
		}
	}
}
