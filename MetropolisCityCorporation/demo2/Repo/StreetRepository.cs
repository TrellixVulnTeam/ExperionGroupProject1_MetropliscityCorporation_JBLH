﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Models;

namespace demo2.Repo
{
    public class StreetRepository : IStreetRepository
    {
        private readonly ActivityContext _dbContext;
        public StreetRepository(ActivityContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Streets> GetAllOrders()
        {
            return _dbContext.Streets.ToList();
        }

        public List<Streets> GetAllStreets()
        {
            throw new NotImplementedException();
        }
    }
}