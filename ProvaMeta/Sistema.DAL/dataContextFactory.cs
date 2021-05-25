using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAL
{
   public class dataContextFactory
    {
        private  static metaBancoDataContext dataContext;
           public static metaBancoDataContext DataContext { 
        
            get
            {
                if (dataContext == null)
                    dataContext = new metaBancoDataContext();
                return dataContext;

            }
        }
    }
}
