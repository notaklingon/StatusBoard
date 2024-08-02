using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusBoard.Models
{
    internal class MockVwInOutRzr:IInOut
    {
        #region "Constructors"
        public MockVwInOutRzr() { }

        public MockVwInOutRzr(int userId,
                        Color favoriteColor,
                        int userStatusId,
                        string fullName,
                        string activity,
                        string secureActivity,
                        int? roleId,
                        string department,
                        string subDepartment,
                        string roleName,
                        string phone,
                        string fax,
                        string cell,
                        bool displayPhone,
                        bool? displayCellPhone,
                        bool canChangeOtherStatus)
        {
            UserId = userId;
            FavoriteColor=favoriteColor;
            UserStatusId = userStatusId;
            FullName = fullName;
            Activity = activity;
            SecureActivity = secureActivity;
            RoleId = roleId;
            Department = department;
            SubDepartment = subDepartment;
            RoleName = roleName;
            Phone = phone;
            Fax = fax;
            Cell = cell;
            DisplayPhone = displayPhone;
            DisplayCellPhone = displayCellPhone;
            CanChangeOtherStatus = canChangeOtherStatus;
        }
        #endregion
        #region "Properties"
        public int UserId { get; set; }
        public Color FavoriteColor { get; set; }

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

        public string Status {
            get
            {
                if (UserStatusId == 0)
                {
                    return "Out";
                }
                else
                {
                    return "In";
                }
            }
        }

        #endregion
    }
}
