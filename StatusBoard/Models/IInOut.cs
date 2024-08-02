using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusBoard.Models
{
    public interface IInOut
    {
        public int UserId { get; set; }

        public int UserStatusId { get; set; }

        public string FullName { get; set; }

        public string Activity { get; set; }

        public string SecureActivity { get; set; }

        public int? RoleId { get; set; }

        public string Department { get; set; }

        public string SubDepartment { get; set; }

        public string RoleName { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Cell { get; set; }

        public bool DisplayPhone { get; set; }

        public bool? DisplayCellPhone { get; set; }

        public bool CanChangeOtherStatus { get; set; }

        public string Status { get; }
    }
}
