using System.Drawing;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace SilverRAT.Helper;

internal class ThemesControl
{
	public void UpdateColorControls(Control myControl)
	{
		myControl.BackColor = Color.Black;
		myControl.ForeColor = Color.White;
		foreach (Control control in myControl.Controls)
		{
			UpdateColorControls(control);
		}
	}

	public void UpdateColorShadowPanel(BunifuShadowPanel myControl)
	{
		myControl.BackColor = Color.Black;
		myControl.ForeColor = Color.White;
	}
}
