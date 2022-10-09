using AutoMapper;
using DesafioTM.Model;
using DesafioTM.Repository.Purchases;
using System;
using System.Collections.Generic;

namespace DesafioTM.Business.Purchases
{
    public class PurchaseBusinessImp : IPurchase
    {
        private readonly IPurchaseRepository _repository;
        private readonly IMapper _mapper;

        public PurchaseBusinessImp(IPurchaseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public PurchaseDTO Create(PurchaseDTO purchase)
        {
            var pur = _repository.Create(_mapper.Map<Purchase>(purchase));
            return _mapper.Map<PurchaseDTO>(pur);
        }

        public PurchaseDTO Update(PurchaseDTO purchase)
        {
            var pur = _repository.Update(_mapper.Map<Purchase>(purchase));
            return _mapper.Map<PurchaseDTO>(pur);
        }

        public List<PurchaseDTO> FindAll()
        {
            var purchase = _repository.FindAll();
            return _mapper.Map<List<PurchaseDTO>>(purchase);
        }

        public PurchaseDTO FindById(long id)
        {
            var purchase = _repository.FindById(id);
            return _mapper.Map<PurchaseDTO>(purchase);
        }

        public List<PurchaseDTO> FindByUserId(long id)
        {
            var purchase = _repository.FindByUserId(id);
            return _mapper.Map<List<PurchaseDTO>>(purchase);
        }

        public List<PurchaseDTO> FindByPurchaseDate(string purchase_date)
        {
            DateTime date = DateTime.Parse(purchase_date);
            var purchase = _repository.FindByPurchaseDate(date);
            return _mapper.Map<List<PurchaseDTO>>(purchase);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
