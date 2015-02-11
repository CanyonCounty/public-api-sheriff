namespace SheriffExampleWin
{
  partial class frmMain
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
      this.lbInmate = new System.Windows.Forms.ListBox();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.txtMiddleName = new System.Windows.Forms.TextBox();
      this.txtIDNumber = new System.Windows.Forms.TextBox();
      this.picture = new System.Windows.Forms.PictureBox();
      this.txtVineURL = new System.Windows.Forms.TextBox();
      this.lbArrests = new System.Windows.Forms.ListBox();
      this.lbCharges = new System.Windows.Forms.ListBox();
      ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
      this.SuspendLayout();
      //
      // lbInmate
      //
      this.lbInmate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInmate.FormattingEnabled = true;
      this.lbInmate.Location = new System.Drawing.Point(12, 12);
      this.lbInmate.Name = "lbInmate";
      this.lbInmate.Size = new System.Drawing.Size(115, 238);
      this.lbInmate.TabIndex = 0;
      this.lbInmate.SelectedIndexChanged += new System.EventHandler(this.lbInmate_SelectedIndexChanged);
      //
      // txtLastName
      //
      this.txtLastName.Location = new System.Drawing.Point(133, 18);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(100, 20);
      this.txtLastName.TabIndex = 1;
      //
      // txtFirstName
      //
      this.txtFirstName.Location = new System.Drawing.Point(239, 18);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(100, 20);
      this.txtFirstName.TabIndex = 2;
      //
      // txtMiddleName
      //
      this.txtMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtMiddleName.Location = new System.Drawing.Point(345, 18);
      this.txtMiddleName.Name = "txtMiddleName";
      this.txtMiddleName.Size = new System.Drawing.Size(100, 20);
      this.txtMiddleName.TabIndex = 3;
      //
      // txtIDNumber
      //
      this.txtIDNumber.Location = new System.Drawing.Point(133, 44);
      this.txtIDNumber.Name = "txtIDNumber";
      this.txtIDNumber.Size = new System.Drawing.Size(100, 20);
      this.txtIDNumber.TabIndex = 4;
      //
      // picture
      //
      this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.picture.Location = new System.Drawing.Point(365, 145);
      this.picture.Name = "picture";
      this.picture.Size = new System.Drawing.Size(80, 105);
      this.picture.TabIndex = 5;
      this.picture.TabStop = false;
      //
      // txtVineURL
      //
      this.txtVineURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtVineURL.Location = new System.Drawing.Point(239, 44);
      this.txtVineURL.Name = "txtVineURL";
      this.txtVineURL.Size = new System.Drawing.Size(206, 20);
      this.txtVineURL.TabIndex = 5;
      //
      // lbArrests
      //
      this.lbArrests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbArrests.FormattingEnabled = true;
      this.lbArrests.Location = new System.Drawing.Point(133, 70);
      this.lbArrests.Name = "lbArrests";
      this.lbArrests.Size = new System.Drawing.Size(312, 69);
      this.lbArrests.TabIndex = 6;
      //
      // lbCharges
      //
      this.lbCharges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbCharges.FormattingEnabled = true;
      this.lbCharges.IntegralHeight = false;
      this.lbCharges.Location = new System.Drawing.Point(133, 145);
      this.lbCharges.Name = "lbCharges";
      this.lbCharges.Size = new System.Drawing.Size(226, 105);
      this.lbCharges.TabIndex = 7;
      //
      // frmMain
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(472, 262);
      this.Controls.Add(this.lbCharges);
      this.Controls.Add(this.lbArrests);
      this.Controls.Add(this.txtVineURL);
      this.Controls.Add(this.picture);
      this.Controls.Add(this.txtIDNumber);
      this.Controls.Add(this.txtMiddleName);
      this.Controls.Add(this.txtFirstName);
      this.Controls.Add(this.txtLastName);
      this.Controls.Add(this.lbInmate);
      this.MinimumSize = new System.Drawing.Size(488, 300);
      this.Name = "frmMain";
      this.Text = "Canyon County Current Arrests";
      this.Shown += new System.EventHandler(this.frmMain_Shown);
      ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lbInmate;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.TextBox txtMiddleName;
    private System.Windows.Forms.TextBox txtIDNumber;
    private System.Windows.Forms.PictureBox picture;
    private System.Windows.Forms.TextBox txtVineURL;
    private System.Windows.Forms.ListBox lbArrests;
    private System.Windows.Forms.ListBox lbCharges;
  }
}

