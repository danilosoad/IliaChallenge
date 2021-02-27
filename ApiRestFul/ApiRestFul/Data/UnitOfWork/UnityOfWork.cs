using ApiRestFul.Data.DataContext;
using ApiRestFul.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFul.Data.UnitOfWork
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly DataConext _context;

        public UnityOfWork(DataConext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void RollBack()
        {

        }
    }
}
