namespace YMYP5_Resume.WinForm;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
	}

	private void btnAbout_Click(object sender, EventArgs e)
	{
		FrmAbout frm = new FrmAbout();
		frm.Show();
	}
}
