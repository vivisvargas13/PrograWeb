using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public ICategoryDAL CategoryDAL { get; set; }

        public ISupplierDAL SupplierDAL { get; set; }

        private NorthwndContext _northWindContext;

        public UnidadDeTrabajo(NorthwndContext northWindContext,
                        ICategoryDAL categoryDAL, ISupplierDAL SupplierDAL


            ) 
        {
                this._northWindContext = northWindContext;
                this.CategoryDAL = categoryDAL; 
                this.SupplierDAL = SupplierDAL;
                
        }
       

        public bool Complete()
        {
            try
            {
                _northWindContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Dispose()
        {
            this._northWindContext.Dispose();
        }
    }
}
