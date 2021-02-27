using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFul.Domain.Interfaces
{
    public interface IUnityOfWork
    {
        void Commit();
        void RollBack();
    }
}
