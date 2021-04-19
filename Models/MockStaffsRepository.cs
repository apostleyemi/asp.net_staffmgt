using System;
using System.Collections.Generic;
using System.Linq;

namespace ems.Models
{
    public class MockStaffsRepository :IStaffRepository
    {
        private List<Staffs>_staffsList;

        public MockStaffsRepository()
        {
            _staffsList = new  List<Staffs>()
            {
                new Staffs() {Id=1, Name="Mary", Department=Dept.HR, Email="admin@admin.com"},
                new Staffs() {Id=2, Name="Peter", Department=Dept.ICT, Email="peter@elizade.com"},
                new Staffs() {Id=3, Name="Paul", Department=Dept.PPW, Email="Paul@elizade.com"},
                new Staffs() {Id=4, Name="James", Department=Dept.ADMIN, Email="james@elizade.com"},
                new Staffs() {Id=5, Name="John", Department=Dept.ACADEMIC, Email="john@elizade.com"}
              
                };
            }
        
        public  Staffs Add(Staffs staff)
        {  staff.Id= _staffsList.Max(e => e.Id) +1;
            _staffsList.Add(staff);
            return staff;
        }

        public Staffs GetStaffs(int Id)
        {
           //  throw new NotImplementedException();
           return _staffsList.FirstOrDefault(e => e.Id ==Id);

        }

        public IEnumerable<Staffs> GetAllStaffs()
        {
            return  _staffsList;
        }
         
    }
}