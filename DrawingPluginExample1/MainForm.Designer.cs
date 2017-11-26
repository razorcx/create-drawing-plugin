namespace DrawingPluginExample1
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
			this.lblSampleText = new System.Windows.Forms.Label();
			this.txtBoxSampleText = new System.Windows.Forms.TextBox();
			this.picBoxLogo = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBoxImageFilename = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// okApplyModifyGetOnOffCancel1
			// 
			this.structuresExtender.SetAttributeName(this.okApplyModifyGetOnOffCancel1, null);
			this.structuresExtender.SetAttributeTypeName(this.okApplyModifyGetOnOffCancel1, null);
			this.structuresExtender.SetBindPropertyName(this.okApplyModifyGetOnOffCancel1, null);
			this.okApplyModifyGetOnOffCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.okApplyModifyGetOnOffCancel1.Location = new System.Drawing.Point(0, 215);
			this.okApplyModifyGetOnOffCancel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.okApplyModifyGetOnOffCancel1.Name = "okApplyModifyGetOnOffCancel1";
			this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(733, 36);
			this.okApplyModifyGetOnOffCancel1.TabIndex = 0;
			this.okApplyModifyGetOnOffCancel1.OkClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_OkClicked);
			this.okApplyModifyGetOnOffCancel1.ApplyClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_ApplyClicked);
			this.okApplyModifyGetOnOffCancel1.ModifyClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_ModifyClicked);
			this.okApplyModifyGetOnOffCancel1.GetClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_GetClicked);
			this.okApplyModifyGetOnOffCancel1.OnOffClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_OnOffClicked);
			this.okApplyModifyGetOnOffCancel1.CancelClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_CancelClicked);
			// 
			// lblSampleText
			// 
			this.structuresExtender.SetAttributeName(this.lblSampleText, null);
			this.structuresExtender.SetAttributeTypeName(this.lblSampleText, null);
			this.lblSampleText.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.lblSampleText, null);
			this.lblSampleText.Location = new System.Drawing.Point(9, 97);
			this.lblSampleText.Name = "lblSampleText";
			this.lblSampleText.Size = new System.Drawing.Size(90, 17);
			this.lblSampleText.TabIndex = 1;
			this.lblSampleText.Text = "Drawing Text";
			// 
			// txtBoxSampleText
			// 
			this.structuresExtender.SetAttributeName(this.txtBoxSampleText, "sampletext");
			this.structuresExtender.SetAttributeTypeName(this.txtBoxSampleText, "String");
			this.structuresExtender.SetBindPropertyName(this.txtBoxSampleText, "Text");
			this.txtBoxSampleText.Location = new System.Drawing.Point(12, 117);
			this.txtBoxSampleText.Multiline = true;
			this.txtBoxSampleText.Name = "txtBoxSampleText";
			this.txtBoxSampleText.Size = new System.Drawing.Size(375, 79);
			this.txtBoxSampleText.TabIndex = 2;
			// 
			// picBoxLogo
			// 
			this.structuresExtender.SetAttributeName(this.picBoxLogo, null);
			this.structuresExtender.SetAttributeTypeName(this.picBoxLogo, null);
			this.structuresExtender.SetBindPropertyName(this.picBoxLogo, null);
			this.picBoxLogo.Location = new System.Drawing.Point(12, 26);
			this.picBoxLogo.Name = "picBoxLogo";
			this.picBoxLogo.Size = new System.Drawing.Size(243, 51);
			this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBoxLogo.TabIndex = 3;
			this.picBoxLogo.TabStop = false;
			// 
			// label1
			// 
			this.structuresExtender.SetAttributeName(this.label1, null);
			this.structuresExtender.SetAttributeTypeName(this.label1, null);
			this.label1.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label1, null);
			this.label1.Location = new System.Drawing.Point(413, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Image Filename";
			// 
			// txtBoxImageFilename
			// 
			this.structuresExtender.SetAttributeName(this.txtBoxImageFilename, "imagefilename");
			this.structuresExtender.SetAttributeTypeName(this.txtBoxImageFilename, "String");
			this.structuresExtender.SetBindPropertyName(this.txtBoxImageFilename, "Text");
			this.txtBoxImageFilename.Location = new System.Drawing.Point(416, 117);
			this.txtBoxImageFilename.Multiline = true;
			this.txtBoxImageFilename.Name = "txtBoxImageFilename";
			this.txtBoxImageFilename.Size = new System.Drawing.Size(305, 79);
			this.txtBoxImageFilename.TabIndex = 5;
			this.txtBoxImageFilename.Text = "D:\\RazorCX\\Logos\\RazorCX-Logo-50x50.jpg";
			// 
			// MainForm
			// 
			this.structuresExtender.SetAttributeName(this, null);
			this.structuresExtender.SetAttributeTypeName(this, null);
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.structuresExtender.SetBindPropertyName(this, null);
			this.ClientSize = new System.Drawing.Size(733, 251);
			this.Controls.Add(this.txtBoxImageFilename);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picBoxLogo);
			this.Controls.Add(this.txtBoxSampleText);
			this.Controls.Add(this.lblSampleText);
			this.Controls.Add(this.okApplyModifyGetOnOffCancel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Drawing Plugin Example";
			((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel okApplyModifyGetOnOffCancel1;
		private System.Windows.Forms.Label lblSampleText;
		private System.Windows.Forms.TextBox txtBoxSampleText;
		private System.Windows.Forms.PictureBox picBoxLogo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBoxImageFilename;
	}
}