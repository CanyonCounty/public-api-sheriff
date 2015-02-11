using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SheriffExampleDAL;

namespace SheriffExampleWin
{
  public partial class frmMain : Form
  {
    List<Inmate> _list;

    public frmMain()
    {
      InitializeComponent();
    }

    private void frmMain_Shown(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      _list = Sheriff.GetCurrentArrests();
      foreach (Inmate inmate in _list)
      {
        lbInmate.Items.Add(inmate);
      }
      Cursor.Current = Cursors.Default;
    }

    private void lbInmate_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lbInmate.SelectedIndex >= 0)
      {
        Inmate inmate = (Inmate)lbInmate.SelectedItem;
        txtLastName.Text = inmate.LastName;
        txtFirstName.Text = inmate.FirstName;
        txtMiddleName.Text = inmate.MiddleName;
        txtIDNumber.Text = inmate.IDNumber;
        txtVineURL.Text = inmate.VineURL;

        lbArrests.Items.Clear();
        foreach (Arrest arrest in inmate.Arrests)
        {
          lbArrests.Items.Add(String.Format("Arrest: {0}", arrest.ArrestDate));
        }

        lbCharges.Items.Clear();
        foreach (Charge charge in inmate.Charges)
        {
          lbCharges.Items.Add(String.Format("Charge: {0}: {1}", charge.StatuteCode, charge.StatuteDesc));
        }

        picture.LoadAsync(inmate.ImageThumb);
      }
    }
  }
}
