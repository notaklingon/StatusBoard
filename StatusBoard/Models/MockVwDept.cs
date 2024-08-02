using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusBoard.Models
{
    class MockVwDept : IDepartment
    {
        #region "Constructors"
        public MockVwDept() { }

        public MockVwDept(int departmentId, string department) { 
            DepartmentId = departmentId;
            Department = department;
        }
        #endregion
        #region "Properties"
        public int DepartmentId { get; set; }

        public string Department { get; set; }
        #endregion

    }
}

