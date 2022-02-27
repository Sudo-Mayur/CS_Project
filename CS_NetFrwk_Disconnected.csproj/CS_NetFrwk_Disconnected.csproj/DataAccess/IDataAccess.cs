using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_NetFrwk_Disconnected.DataAccess
{
    internal interface IDataAccess<TEntity> where TEntity : class
    {     
        void GetData();
        void Create();
        void Update();
        void Delete();
    }
}