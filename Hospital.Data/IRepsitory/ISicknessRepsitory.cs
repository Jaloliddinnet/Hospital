﻿using Hospital.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface ISicknessRepsitory
    {
        public Task Add(Sickness autosalon);
        public Task<IEnumerable<Sickness>> GetAll();
        public Task Update(int id, Sickness sickness);
        public Task Delete(int id);
    }
}
