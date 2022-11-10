using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.SqlServer;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class UserMessageRepository : SqlBaseRepository<UserMessage>, IUserMessageRepository
    {
        public List<UserMessage> ListByUser()
        {
            using (var context = new Context())
            {
                return context.UserMessages.Include(x => x.User).ToList();
            }
        }
    }
}
