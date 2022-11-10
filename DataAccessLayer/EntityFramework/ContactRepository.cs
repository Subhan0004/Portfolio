﻿using DataAccessLayer.Abstract;
using DataAccessLayer.SqlServer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class ContactRepository : SqlBaseRepository<Contact>, IContactRepository
    {
    }
}
