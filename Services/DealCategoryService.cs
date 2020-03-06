using DealsMo.Data;
using DealsMo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealsMo.Services
{
    public class DealCategoryService
    {
        private readonly DMDbContext _db;
        public DealCategoryService(DMDbContext db)
        {
            _db = db;
        }

        public DealCategory GetDealCategory(int DealCategoryId)
        {
            DealCategory obj = new DealCategory();
            return _db.DealCategories.FirstOrDefault(u => u.Id == DealCategoryId);
        }

        public List<DealCategory> GetDealCategories()
        {

            return _db.DealCategories.ToList();
        }

        public bool CreateDealCategory(DealCategory objDealCategory)
        {
            objDealCategory.CreatedTS = DateTime.Now;
            objDealCategory.CreatedBy = "usernamexxx";
            objDealCategory.UpdatedTS = DateTime.Now;
            objDealCategory.UpdatedBy = "usernamexxx";

            _db.DealCategories.Add(objDealCategory);
            _db.SaveChanges();
            return true;
        }
        public bool UpdateDealCategory(DealCategory objDealCategory)
        {
            var ExistingDealCategory = _db.DealCategories.FirstOrDefault(u => u.Id == objDealCategory.Id);
            if (ExistingDealCategory != null)
            {
                objDealCategory.UpdatedTS = DateTime.Now;
                objDealCategory.UpdatedBy = "usernamexxx";
                ExistingDealCategory.Name = objDealCategory.Name;
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool DeleteDealCategory(DealCategory objDealCategory)
        {
            var ExistingDealCategory = _db.DealCategories.FirstOrDefault(u => u.Id == objDealCategory.Id);
            if (ExistingDealCategory != null)
            {
                _db.DealCategories.Remove(ExistingDealCategory);
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
