﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;

        public PasswordCheckerService(IRepository repository)
        {
            this.repository = repository;
        }


    }
}
