﻿namespace sample_2_8 {
  partial class Placeholder {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.BackColor = System.Drawing.Color.Ivory;
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.labelControl1.Appearance.Options.UseBackColor = true;
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Appearance.Options.UseTextOptions = true;
      this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labelControl1.Location = new System.Drawing.Point(0, 0);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(580, 280);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "UI Placeholder";
      // 
      // Placeholder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelControl1);
      this.Name = "Placeholder";
      this.Size = new System.Drawing.Size(580, 280);
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
  }
}
