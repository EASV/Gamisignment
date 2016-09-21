using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamisignmentDll.Context;
using GamisignmentDll.Entities;

namespace GamisignmentDll.Managers
{
    class PrizeManager : IManager<Prize>
    {
        public List<Prize> Read()
        {
            using (var db = new GamiSignmentContext())
            {
                return db.Prizes.ToList();
            }
        }

        public Prize Read(int id)
        {
            using (var db = new GamiSignmentContext())
            {
                return db.Prizes.FirstOrDefault(x => x.Id == id);
            }
        }

        public Prize Create(Prize t)
        {
            using (var db = new GamiSignmentContext())
            {
                db.Prizes.Add(t);
                db.SaveChanges();
                return t;
            }
        }

        public Prize Update(Prize t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

