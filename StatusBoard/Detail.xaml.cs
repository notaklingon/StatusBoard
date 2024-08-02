using StatusBoard.Models;

namespace StatusBoard;

public partial class Detail : ContentPage
{

	public Detail(IInOut inOut)
	{
		InitializeComponent();

		labelFullName.Text = inOut.FullName;
		labelActivity.Text = inOut.Activity;
		labelSecureActivity.Text = inOut.SecureActivity;
		labelDepartment.Text = inOut.Department;
		labelSubDepartment.Text = inOut.SubDepartment;
		labelPhone.Text = inOut.Phone;
		labelFax.Text = inOut.Fax;
		labelCell.Text = inOut.Cell;
	}
}