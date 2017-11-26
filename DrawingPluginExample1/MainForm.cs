using System;
using Tekla.Structures.Dialog;

namespace DrawingPluginExample1
{
	public partial class MainForm : PluginFormBase
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void okApplyModifyGetOnOffCancel1_OkClicked(object sender, EventArgs e)
		{
			this.Apply();
			this.Close();
		}

		private void okApplyModifyGetOnOffCancel1_ApplyClicked(object sender, EventArgs e)
		{
			this.Apply();
		}

		private void okApplyModifyGetOnOffCancel1_ModifyClicked(object sender, EventArgs e)
		{
			this.Modify();
		}

		private void okApplyModifyGetOnOffCancel1_GetClicked(object sender, EventArgs e)
		{
			this.Get();
		}

		private void okApplyModifyGetOnOffCancel1_OnOffClicked(object sender, EventArgs e)
		{
			this.Close();
		}

		private void okApplyModifyGetOnOffCancel1_CancelClicked(object sender, EventArgs e)
		{
			this.ToggleSelection();
		}
	}
}
