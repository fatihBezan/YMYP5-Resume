
using YMYP5_Resume.Business.Abstract;
using YMYP5_Resume.Business.DependencyInjection.AutoFac;
using YMYP5_Resume.Entity.Concrete;

namespace YMYP5_Resume.WinForm;
public partial class FrmAbout : Form
{
    private readonly IAboutService _aboutService;
    private About _about;
    public FrmAbout()
    {
        _aboutService = InstanceFactory.GetInstance<IAboutService>();
        InitializeComponent();
    }

    private void FrmAbout_Load(object sender, EventArgs e)
    {
        DataGridFill();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        var about = new About();
        about.Description = rtbxDescription.Text;
        _aboutService.Insert(about);
        Clear();
    }

    private void DataGridFill()
    {
        var abouts = _aboutService.GetAll();
        dgvAbouts.DataSource = abouts;
    }

    private void Clear()
    {
        rtbxDescription.Clear();
        rtbUpdateAbout.Clear();
        cbxIsActive.Checked = true;
        cbxIsDelete.Checked = false;
        DataGridFill();
    }

    private void dgvAbouts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        _about = _aboutService.GetByID(Guid.Parse(dgvAbouts.CurrentRow.Cells["Id"].Value.ToString()));
        rtbUpdateAbout.Text = dgvAbouts.CurrentRow.Cells["Description"].Value.ToString();
        //cbxIsActive.Checked = Convert.ToBoolean(dgvAbouts.CurrentRow.Cells["IsActive"].Value);
       //cbxIsDelete.Checked = Convert.ToBoolean(dgvAbouts.CurrentRow.Cells["IsDeleted"].Value);
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (_about != null)
        {
            _about.Description = rtbUpdateAbout.Text;
            _about.IsDeleted = cbxIsDelete.Checked;
            _about.IsActive = cbxIsActive.Checked;
            _about.UpdateAt = DateTime.Now;
        }
        _aboutService.Modify(_about);
        Clear();
    }

    private void dgvAbouts_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void rtbxDescription_TextChanged(object sender, EventArgs e)
    {

    }
}
