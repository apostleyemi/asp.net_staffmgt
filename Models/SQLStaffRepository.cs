using System;
using System.Collections.Generic;

namespace ems.Models
{
    public class SQLStaffRepository : IStaffRepository
    {
        private readonly AppDbContext context;
        public SQLStaffRepository(AppDbContext context)
        {
            this.context=context;
        }
        public Staffs Add(Staffs staff)
        {
            //throw new System.NotImplementedException();
            context.Staffss.Add(staff);
            context.SaveChanges();
            return staff;

        }

        public Staffs Delete(int id)
        {
            Staffs staff =context.Staffss.Find(id);
            if(staff !=null)
            {
                context.Staffss.Remove(staff);
                context.SaveChanges();

            }
            return staff;
        }

        public IEnumerable<Staffs> GetAllStaffs()
        {
           
           return context.Staffss;

        }

        public Staffs GetStaffs(int Id)
        {
            return context.Staffss.Find(Id);
        }

        public Staffs Update(Staffs staffChanges)
        {
           var staff= context.Staffss.Attach(staffChanges);
           staff.State =Microsoft.EntityFrameworkCore.EntityState.Modified;
           context.SaveChanges();
           return staffChanges;
        }
    }
}