using System;
using ems.Models;
using System.Collections.Generic;


namespace ems.Models
{
    public interface IStaffRepository
    {
       Staffs GetStaffs(int Id);
       IEnumerable<Staffs> GetAllStaffs();
       Staffs Add(Staffs staff);
       Staffs Update(Staffs staffChanges);
       Staffs Delete(int id);

    }
}