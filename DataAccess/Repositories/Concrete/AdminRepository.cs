using SchoolBus_DataAccess.Repositories.Abstract;
using SchoolBus_Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_DataAccess.Repositories.Concrete
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
    }
}
