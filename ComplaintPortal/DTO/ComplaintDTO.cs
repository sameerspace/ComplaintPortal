using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintPortal.DTO
{
    internal class ComplaintDTO
    {
        private string?  _type;
        private string? _description;
        private string? _response;
        private string? _status;
        private int? _employeeId;
        private int? _customerID;

        public string? Type { get => _type; set => _type = value; }
        public string? Description { get => _description; set => _description = value; }
        public string? Response { get => _response; set => _response = value; }
        public string? Status { get => _status; set => _status = value; }
        public int? EmployeeId { get => _employeeId; set => _employeeId = value; }
        public int? CustomerID { get => _customerID; set => _customerID = value; }
    }
}
