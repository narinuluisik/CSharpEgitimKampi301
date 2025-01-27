using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

            public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int id)
        {
           return _customerDal.GetById(id);
        }

        public void TDelete(Customer entity)
        {
          _customerDal.Delete(entity);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerName!="" && entity.CustomerName.Length>=3 && entity.CustomerCity!=null && entity.CustomerSurName!="" && entity.CustomerSurName.Length<=30)
            {
                //EKLEME İŞLEMİ YAP

                _customerDal.Insert(entity);

            }
            else
            {
                //HATA MESAJI VER
            }
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
