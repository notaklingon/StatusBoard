using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace StatusBoard.Models
{
    internal class GenerateMockData
    {
        static Random random = new Random();

        static Color[] favoriteColor = {Colors.AliceBlue, Colors.AntiqueWhite,Colors.Aqua};

        static string[] firstNames = { "John", "Jane", "Michael", "Emily", "Chris", "Katie", "David", "Laura" };
        static string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis" };
        static string[] departments = { "Information Technology", "Health", "Human Services", "Human Resources", "Facilities" };
        static string[] subDepartments = { "Admin", "General"};
        static string[] activities = { "Logged in", "Logged out", "In a meeting", "On a call", "Working remotely" };
        static string[] roles = { "Manager", "Engineer", "Director", "Analyst", "Consultant" };

        static string GenerateRandomFullName()
        {
            string firstName = firstNames[random.Next(firstNames.Length)];
            string lastName = lastNames[random.Next(lastNames.Length)];
            return $"{firstName} {lastName}";
        }

        static Color GenerateRandomColor()
        {
            Color color = favoriteColor[random.Next(favoriteColor.Length)];
            return color;
        }

        static string GenerateRandomPhoneNumber()
        {
            return $"{random.Next(100, 1000)}-{random.Next(100, 1000)}-{random.Next(1000, 10000)}";
        }

        public static List<MockVwDept> ReturnMockDepartmentRecords()
        {
            List<MockVwDept> testRecords = new List<MockVwDept>();

            testRecords.Add(new MockVwDept(0, "All"));
            testRecords.Add(new MockVwDept(1, "Information Technology"));
            testRecords.Add(new MockVwDept(2, "Health"));
            testRecords.Add(new MockVwDept(3, "Human Services"));
            testRecords.Add(new MockVwDept(4, "Human Resources"));
            testRecords.Add(new MockVwDept(5, "Facilities"));

            return testRecords;
        }

        public static List<MockVwInOutRzr> ReturnMockInOutRecords()
        {
            List<MockVwInOutRzr> testRecords = new List<MockVwInOutRzr>();

            for (int i = 0; i < 100; i++)
            {
                var record = new MockVwInOutRzr(
                    userId: i + 1,
                    favoriteColor: GenerateRandomColor(),
                    userStatusId: random.Next(0, 2),
                    fullName: GenerateRandomFullName(),
                    activity: activities[random.Next(activities.Length)],
                    secureActivity: activities[random.Next(activities.Length)],
                    roleId: random.Next(1, 5),
                    department: departments[random.Next(departments.Length)],
                    subDepartment: subDepartments[random.Next(subDepartments.Length)],
                    roleName: roles[random.Next(roles.Length)],
                    phone: GenerateRandomPhoneNumber(),
                    fax: GenerateRandomPhoneNumber(),
                    cell: GenerateRandomPhoneNumber(),
                    displayPhone: random.Next(2) == 1,
                    displayCellPhone: random.Next(2) == 1,
                    canChangeOtherStatus: random.Next(2) == 1
                );

                testRecords.Add(record);
            }
            return testRecords;
        }

        public static List<MockVwInOutRzr> ReturnMockInOutRecordsStatic()
        {
            List<MockVwInOutRzr> testRecords = new List<MockVwInOutRzr>();

            testRecords.Add(new MockVwInOutRzr(userId: 1, favoriteColor: Colors.Green, userStatusId: 2, fullName: "Tami Booth", activity: "On a call", secureActivity: "Working remotely", roleId: 1, department: "Human Resources", subDepartment: "Admin", roleName: "Analyst", phone: "(122) 617-6801", fax: "(787) 501-1703", cell: "(815) 239-2715", displayPhone: true, displayCellPhone: true, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 2, favoriteColor: Colors.Black, userStatusId: 0, fullName: "Douglas Fleming", activity: "On a call", secureActivity: "Logged out", roleId: 1, department: "Human Services", subDepartment: "General", roleName: "Consultant", phone: "(282) 188-8192", fax: "(268) 316-5405", cell: "(931) 013-4027", displayPhone: true, displayCellPhone: true, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 3, favoriteColor: Colors.Red, userStatusId: 0, fullName: "Vickie Harris", activity: "On a call", secureActivity: "In a meeting", roleId: 1, department: "Human Resources", subDepartment: "Admin", roleName: "Engineer", phone: "(802) 558-6783", fax: "(423) 992-3225", cell: "(021) 005-6221", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 4, favoriteColor: Colors.White, userStatusId: 2, fullName: "William Brown", activity: "Working remotely", secureActivity: "Logged out", roleId: 6, department: "Human Resources", subDepartment: "Admin", roleName: "Engineer", phone: "(058) 958-4061", fax: "(996) 215-2553", cell: "(634) 913-4559", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 5, favoriteColor: Colors.Black, userStatusId: 1, fullName: "Gregory Brooks", activity: "Logged in", secureActivity: "Working remotely", roleId: 0, department: "Health", subDepartment: "Admin", roleName: "Consultant", phone: "(015) 394-8963", fax: "(090) 320-1785", cell: "(486) 476-3546", displayPhone: false, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 6, favoriteColor: Colors.Yellow, userStatusId: 2, fullName: "Alice Johnson", activity: "Logged in", secureActivity: "In a meeting", roleId: 3, department: "Facilities", subDepartment: "General", roleName: "Manager", phone: "(382) 012-7824", fax: "(592) 720-3549", cell: "(932) 129-9271", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 7, favoriteColor: Colors.Blue, userStatusId: 1, fullName: "Frank Wright", activity: "Logged out", secureActivity: "Logged in", roleId: 5, department: "Information Technology", subDepartment: "Admin", roleName: "Director", phone: "(851) 934-2917", fax: "(752) 918-1234", cell: "(745) 839-1234", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 8, favoriteColor: Colors.White, userStatusId: 0, fullName: "Linda Taylor", activity: "On a call", secureActivity: "Working remotely", roleId: 2, department: "Health", subDepartment: "Admin", roleName: "Analyst", phone: "(527) 910-2345", fax: "(243) 619-1824", cell: "(349) 234-9123", displayPhone: false, displayCellPhone: false, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 9, favoriteColor: Colors.Black, userStatusId: 2, fullName: "Paul Adams", activity: "In a meeting", secureActivity: "On a call", roleId: 4, department: "Human Services", subDepartment: "General", roleName: "Consultant", phone: "(193) 401-2384", fax: "(732) 019-4823", cell: "(385) 432-9123", displayPhone: true, displayCellPhone: true, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 10, favoriteColor: Colors.Green, userStatusId: 2, fullName: "Kevin Elliott", activity: "On a call", secureActivity: "In a meeting", roleId: 4, department: "Health", subDepartment: "Admin", roleName: "Engineer", phone: "(062) 031-1020", fax: "(391) 410-6290", cell: "(357) 339-9083", displayPhone: true, displayCellPhone: true, canChangeOtherStatus: false));           
            testRecords.Add(new MockVwInOutRzr(userId: 11, favoriteColor: Colors.Blue, userStatusId: 1, fullName: "John Smith", activity: "Logged in", secureActivity: "Logged out", roleId: 3, department: "Information Technology", subDepartment: "General", roleName: "Manager", phone: "(123) 456-7890", fax: "(987) 654-3210", cell: "(555) 555-5555", displayPhone: true, displayCellPhone: true, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 12, favoriteColor: Colors.Red, userStatusId: 0, fullName: "Alice Brown", activity: "In a meeting", secureActivity: "On a call", roleId: 2, department: "Health", subDepartment: "Admin", roleName: "Engineer", phone: "(234) 567-8901", fax: "(876) 543-2109", cell: "(444) 444-4444", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 13, favoriteColor: Colors.Green, userStatusId: 2, fullName: "Bob Johnson", activity: "Working remotely", secureActivity: "Logged in", roleId: 5, department: "Human Services", subDepartment: "General", roleName: "Director", phone: "(345) 678-9012", fax: "(765) 432-1098", cell: "(333) 333-3333", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 14, favoriteColor: Colors.Yellow, userStatusId: 0, fullName: "Carol White", activity: "Logged out", secureActivity: "In a meeting", roleId: 4, department: "Human Resources", subDepartment: "Admin", roleName: "Analyst", phone: "(456) 789-0123", fax: "(654) 321-0987", cell: "(222) 222-2222", displayPhone: false, displayCellPhone: false, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 15, favoriteColor: Colors.Black, userStatusId: 1, fullName: "Dave Green", activity: "On a call", secureActivity: "Logged out", roleId: 6, department: "Facilities", subDepartment: "General", roleName: "Consultant", phone: "(567) 890-1234", fax: "(543) 210-9876", cell: "(111) 111-1111", displayPhone: true, displayCellPhone: true, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 16, favoriteColor: Colors.White, userStatusId: 2, fullName: "Eve Black", activity: "Logged in", secureActivity: "On a call", roleId: 1, department: "Information Technology", subDepartment: "Admin", roleName: "Manager", phone: "(678) 901-2345", fax: "(432) 109-8765", cell: "(999) 999-9999", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 17, favoriteColor: Colors.Blue, userStatusId: 0, fullName: "Frank Brown", activity: "In a meeting", secureActivity: "Logged in", roleId: 2, department: "Health", subDepartment: "General", roleName: "Engineer", phone: "(789) 012-3456", fax: "(321) 098-7654", cell: "(888) 888-8888", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 18, favoriteColor: Colors.Red, userStatusId: 1, fullName: "Grace White", activity: "On a call", secureActivity: "Logged out", roleId: 3, department: "Human Services", subDepartment: "Admin", roleName: "Director", phone: "(890) 123-4567", fax: "(210) 987-6543", cell: "(777) 777-7777", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 19, favoriteColor: Colors.Green, userStatusId: 2, fullName: "Hank Green", activity: "Working remotely", secureActivity: "In a meeting", roleId: 4, department: "Human Resources", subDepartment: "General", roleName: "Analyst", phone: "(901) 234-5678", fax: "(109) 876-5432", cell: "(666) 666-6666", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 20, favoriteColor: Colors.Yellow, userStatusId: 0, fullName: "Ivy Black", activity: "Logged in", secureActivity: "On a call", roleId: 5, department: "Facilities", subDepartment: "Admin", roleName: "Consultant", phone: "(012) 345-6789", fax: "(098) 765-4321", cell: "(555) 555-5555", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 21, favoriteColor: Colors.Black, userStatusId: 1, fullName: "Jack White", activity: "In a meeting", secureActivity: "Logged out", roleId: 6, department: "Information Technology", subDepartment: "General", roleName: "Manager", phone: "(123) 456-7890", fax: "(987) 654-3210", cell: "(444) 444-4444", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 22, favoriteColor: Colors.White, userStatusId: 2, fullName: "Kate Brown", activity: "Logged in", secureActivity: "On a call", roleId: 1, department: "Health", subDepartment: "Admin", roleName: "Engineer", phone: "(234) 567-8901", fax: "(876) 543-2109", cell: "(333) 333-3333", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 23, favoriteColor: Colors.Blue, userStatusId: 0, fullName: "Leo Green", activity: "Working remotely", secureActivity: "In a meeting", roleId: 2, department: "Human Services", subDepartment: "General", roleName: "Director", phone: "(345) 678-9012", fax: "(765) 432-1098", cell: "(222) 222-2222", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 24, favoriteColor: Colors.Red, userStatusId: 1, fullName: "Mia Black", activity: "On a call", secureActivity: "Logged out", roleId: 3, department: "Human Resources", subDepartment: "Admin", roleName: "Analyst", phone: "(456) 789-0123", fax: "(654) 321-0987", cell: "(111) 111-1111", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 25, favoriteColor: Colors.Green, userStatusId: 2, fullName: "Nate White", activity: "In a meeting", secureActivity: "Logged in", roleId: 4, department: "Facilities", subDepartment: "General", roleName: "Consultant", phone: "(567) 890-1234", fax: "(543) 210-9876", cell: "(999) 999-9999", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 26, favoriteColor: Colors.Yellow, userStatusId: 0, fullName: "Olive Brown", activity: "Logged out", secureActivity: "On a call", roleId: 5, department: "Information Technology", subDepartment: "Admin", roleName: "Manager", phone: "(678) 901-2345", fax: "(432) 109-8765", cell: "(888) 888-8888", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 27, favoriteColor: Colors.Black, userStatusId: 1, fullName: "Paul Green", activity: "On a call", secureActivity: "In a meeting", roleId: 6, department: "Health", subDepartment: "General", roleName: "Engineer", phone: "(789) 012-3456", fax: "(321) 098-7654", cell: "(777) 777-7777", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 28, favoriteColor: Colors.White, userStatusId: 2, fullName: "Quinn Black", activity: "Working remotely", secureActivity: "Logged out", roleId: 1, department: "Human Services", subDepartment: "Admin", roleName: "Director", phone: "(890) 123-4567", fax: "(210) 987-6543", cell: "(666) 666-6666", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 29, favoriteColor: Colors.Blue, userStatusId: 0, fullName: "Ruth White", activity: "Logged in", secureActivity: "On a call", roleId: 2, department: "Human Resources", subDepartment: "General", roleName: "Analyst", phone: "(901) 234-5678", fax: "(109) 876-5432", cell: "(555) 555-5555", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 30, favoriteColor: Colors.Red, userStatusId: 1, fullName: "Steve Brown", activity: "In a meeting", secureActivity: "Logged in", roleId: 3, department: "Facilities", subDepartment: "Admin", roleName: "Consultant", phone: "(012) 345-6789", fax: "(098) 765-4321", cell: "(444) 444-4444", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 31, favoriteColor: Colors.Green, userStatusId: 2, fullName: "Tina Green", activity: "Logged out", secureActivity: "In a meeting", roleId: 4, department: "Information Technology", subDepartment: "General", roleName: "Manager", phone: "(123) 456-7890", fax: "(987) 654-3210", cell: "(333) 333-3333", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 32, favoriteColor: Colors.Yellow, userStatusId: 0, fullName: "Uma Black", activity: "Working remotely", secureActivity: "Logged out", roleId: 5, department: "Health", subDepartment: "Admin", roleName: "Engineer", phone: "(234) 567-8901", fax: "(876) 543-2109", cell: "(222) 222-2222", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 33, favoriteColor: Colors.Black, userStatusId: 1, fullName: "Victor White", activity: "Logged in", secureActivity: "On a call", roleId: 6, department: "Human Services", subDepartment: "General", roleName: "Director", phone: "(345) 678-9012", fax: "(765) 432-1098", cell: "(111) 111-1111", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 34, favoriteColor: Colors.White, userStatusId: 2, fullName: "Wendy Brown", activity: "In a meeting", secureActivity: "Logged in", roleId: 1, department: "Human Resources", subDepartment: "Admin", roleName: "Analyst", phone: "(456) 789-0123", fax: "(654) 321-0987", cell: "(999) 999-9999", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 35, favoriteColor: Colors.Blue, userStatusId: 0, fullName: "Xander Green", activity: "Logged out", secureActivity: "On a call", roleId: 2, department: "Facilities", subDepartment: "General", roleName: "Consultant", phone: "(567) 890-1234", fax: "(543) 210-9876", cell: "(888) 888-8888", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 36, favoriteColor: Colors.Red, userStatusId: 1, fullName: "Yara Black", activity: "Working remotely", secureActivity: "In a meeting", roleId: 3, department: "Information Technology", subDepartment: "Admin", roleName: "Manager", phone: "(678) 901-2345", fax: "(432) 109-8765", cell: "(777) 777-7777", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 37, favoriteColor: Colors.Green, userStatusId: 2, fullName: "Zach White", activity: "Logged in", secureActivity: "On a call", roleId: 4, department: "Health", subDepartment: "General", roleName: "Engineer", phone: "(789) 012-3456", fax: "(321) 098-7654", cell: "(666) 666-6666", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 38, favoriteColor: Colors.Yellow, userStatusId: 0, fullName: "Amy Black", activity: "In a meeting", secureActivity: "Logged out", roleId: 5, department: "Human Services", subDepartment: "Admin", roleName: "Director", phone: "(890) 123-4567", fax: "(210) 987-6543", cell: "(555) 555-5555", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 39, favoriteColor: Colors.Black, userStatusId: 1, fullName: "Ben White", activity: "Logged in", secureActivity: "On a call", roleId: 6, department: "Human Resources", subDepartment: "General", roleName: "Analyst", phone: "(901) 234-5678", fax: "(109) 876-5432", cell: "(444) 444-4444", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 40, favoriteColor: Colors.White, userStatusId: 2, fullName: "Cody Brown", activity: "In a meeting", secureActivity: "Logged in", roleId: 1, department: "Facilities", subDepartment: "Admin", roleName: "Consultant", phone: "(012) 345-6789", fax: "(098) 765-4321", cell: "(333) 333-3333", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 41, favoriteColor: Colors.Blue, userStatusId: 0, fullName: "Dana Green", activity: "Logged out", secureActivity: "On a call", roleId: 2, department: "Information Technology", subDepartment: "General", roleName: "Manager", phone: "(123) 456-7890", fax: "(987) 654-3210", cell: "(888) 888-8888", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 42, favoriteColor: Colors.Red, userStatusId: 1, fullName: "Eli Black", activity: "Working remotely", secureActivity: "In a meeting", roleId: 3, department: "Health", subDepartment: "Admin", roleName: "Engineer", phone: "(234) 567-8901", fax: "(876) 543-2109", cell: "(777) 777-7777", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 43, favoriteColor: Colors.Green, userStatusId: 2, fullName: "Finn White", activity: "Logged in", secureActivity: "On a call", roleId: 4, department: "Human Services", subDepartment: "General", roleName: "Director", phone: "(345) 678-9012", fax: "(765) 432-1098", cell: "(666) 666-6666", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 44, favoriteColor: Colors.Yellow, userStatusId: 0, fullName: "Gina Brown", activity: "In a meeting", secureActivity: "Logged out", roleId: 5, department: "Human Resources", subDepartment: "Admin", roleName: "Analyst", phone: "(456) 789-0123", fax: "(654) 321-0987", cell: "(555) 555-5555", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 45, favoriteColor: Colors.Black, userStatusId: 1, fullName: "Holly Green", activity: "Logged in", secureActivity: "On a call", roleId: 6, department: "Facilities", subDepartment: "General", roleName: "Consultant", phone: "(567) 890-1234", fax: "(543) 210-9876", cell: "(444) 444-4444", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 46, favoriteColor: Colors.White, userStatusId: 2, fullName: "Ian Black", activity: "In a meeting", secureActivity: "Logged in", roleId: 1, department: "Information Technology", subDepartment: "Admin", roleName: "Manager", phone: "(678) 901-2345", fax: "(432) 109-8765", cell: "(333) 333-3333", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 47, favoriteColor: Colors.Blue, userStatusId: 0, fullName: "Jill Brown", activity: "Logged out", secureActivity: "In a meeting", roleId: 2, department: "Health", subDepartment: "General", roleName: "Engineer", phone: "(789) 012-3456", fax: "(321) 098-7654", cell: "(222) 222-2222", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 48, favoriteColor: Colors.Red, userStatusId: 1, fullName: "Kyle Green", activity: "On a call", secureActivity: "Logged out", roleId: 3, department: "Human Services", subDepartment: "Admin", roleName: "Director", phone: "(890) 123-4567", fax: "(210) 987-6543", cell: "(111) 111-1111", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 49, favoriteColor: Colors.Green, userStatusId: 2, fullName: "Liam White", activity: "Logged in", secureActivity: "On a call", roleId: 4, department: "Human Resources", subDepartment: "General", roleName: "Analyst", phone: "(901) 234-5678", fax: "(109) 876-5432", cell: "(999) 999-9999", displayPhone: true, displayCellPhone: false, canChangeOtherStatus: false));
            testRecords.Add(new MockVwInOutRzr(userId: 50, favoriteColor: Colors.Yellow, userStatusId: 0, fullName: "Mona Black", activity: "In a meeting", secureActivity: "Logged in", roleId: 5, department: "Facilities", subDepartment: "Admin", roleName: "Consultant", phone: "(012) 345-6789", fax: "(098) 765-4321", cell: "(888) 888-8888", displayPhone: false, displayCellPhone: true, canChangeOtherStatus: true));
            testRecords.Add(new MockVwInOutRzr(userId: 51, favoriteColor: Colors.Green, userStatusId: 2, fullName: "Kevin Elliott", activity: "On a call", secureActivity: "In a meeting", roleId: 4, department: "Health", subDepartment: "Admin", roleName: "Engineer", phone: "(062) 031-1020", fax: "(391) 410-6290", cell: "(357) 339-9083", displayPhone: true, displayCellPhone: true, canChangeOtherStatus: false));

            return testRecords;
        }

        public static List<MockVwInOutRzr> ReturnMockInOutRecordsForDepartment(string department)
        {
            List<MockVwInOutRzr> testRecords = new List<MockVwInOutRzr>();

            for (int i = 0; i < 100; i++)
            {
                var record = new MockVwInOutRzr(
                    userId: i + 1,
                    favoriteColor:GenerateRandomColor(),
                    userStatusId: random.Next(0, 2),
                    fullName: GenerateRandomFullName(),
                    activity: activities[random.Next(activities.Length)],
                    secureActivity: activities[random.Next(activities.Length)],
                    roleId: random.Next(1, 5),
                    department: departments[random.Next(departments.Length)],
                    subDepartment: subDepartments[random.Next(subDepartments.Length)],
                    roleName: roles[random.Next(roles.Length)],
                    phone: GenerateRandomPhoneNumber(),
                    fax: GenerateRandomPhoneNumber(),
                    cell: GenerateRandomPhoneNumber(),
                    displayPhone: random.Next(2) == 1,
                    displayCellPhone: random.Next(2) == 1,
                    canChangeOtherStatus: random.Next(2) == 1
                );

                if (record.Department == department)
                {
                    testRecords.Add(record);
                }
                
            }
            return testRecords;
        }
    }
}