using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusBoard.Models
{
    public interface IDepartment
    {
        public int DepartmentId { get; set; }

        public string Department { get; set; }
    }
}
