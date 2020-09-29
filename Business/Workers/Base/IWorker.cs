using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Workers.Base 
{
    public interface IWorker
    {
        bool HasChanges();

        void DetectChanges();

        bool Commit();
    }
}
