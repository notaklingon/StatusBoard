using StatusBoard.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;


namespace StatusBoard
{
    public partial class MainPage : ContentPage
    {
        //private readonly InOutService _service;

        public ObservableCollection<IInOut> Data { get; private set; }
        public ObservableCollection<IDepartment> DataDepartment { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            //_service = new InOutService();
            DataDepartment = new ObservableCollection<IDepartment>();
            Data = new ObservableCollection<IInOut>();

            LoadData("Information Technology");
        }

        private async void LoadData(string department)
        {
            #region "Departments"
            //DepartmentDataPicker
            var dataListDepartments = Models.GenerateMockData.ReturnMockDepartmentRecords();

            foreach (var item in dataListDepartments)
            {
                DataDepartment.Add(item);
            }

            DepartmentDataPicker.ItemsSource = dataListDepartments;
            DepartmentDataPicker.ItemDisplayBinding = new Binding("Department");


            #endregion
            #region "In Out Records"
            //var dataList = await _service.GetInOutAsync(department);
            //var dataListInOut = Models.GenerateMockData.ReturnMockInOutRecords();
            var dataListInOut = Models.GenerateMockData.ReturnMockInOutRecordsStatic();

            foreach (var item in dataListInOut)
            {
                Data.Add(item);
            }

            DataCollectionView.ItemsSource = Data;
            #endregion
        }

        private void ButtonStatus_Clicked(object sender, EventArgs e)
        {

        }

        private void Details_Tapped(object sender, TappedEventArgs e)
        {
            Button btn = (Button)sender;
            int id = (int)btn.CommandParameter;
            IInOut inOut = Data.ElementAt(id - 1);
            //IInOut inOut = Data.ElementAt(id);
            Navigation.PushAsync(new Detail(inOut));
        }
        


        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var department = ((StatusBoard.Models.MockVwDept)((Microsoft.Maui.Controls.Picker)sender).SelectedItem).Department;
            List<MockVwInOutRzr> dataListInOut;

            if (department == "All")
            {
                dataListInOut = Models.GenerateMockData.ReturnMockInOutRecords();
            }
            else
            {
                dataListInOut = Models.GenerateMockData.ReturnMockInOutRecordsForDepartment(department);
            }
            
            Data.Clear();
            foreach (var item in dataListInOut)
            {
                Data.Add(item);
            }

        }
    }
}
