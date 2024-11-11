using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Application.Services
{
    public class BuysService
    {
        private readonly IBuysRepository _buysRepository;

        public BuysService(IBuysRepository buysRepository)
        {
            _buysRepository = buysRepository;
        }

        public List<BuysDto> GetAllBuys()
        {
            var buys = _buysRepository.GetAllBuys();

            return buys.Select(b => new BuysDto
            {
                BuysId = b.BuysId,
                UserBuysId = b.UserBuysId,
                PurchaseDate = b.PurchaseDate,
                Details = b.Details.Select(d => new DetailBuysDto
                {
                    DetailId = d.DetailId,
                    ProductDetailId = d.ProductDetailId,
                    Amount = d.Amount,
                    UnitPrice = d.UnitPrice
                }).ToList(),
                TotalBuy = b.Details.Sum(d => d.Amount * d.UnitPrice)
            }).ToList();
        }

        public BuysDto GetBuyById(int id)
        {
            var buy = _buysRepository.GetBuyById(id);

            if (buy == null)
            {
                return null;
            }

            decimal totalBuy = buy.Details.Sum(d => d.Amount * d.UnitPrice);

            return new BuysDto
            {
                BuysId = buy.BuysId,
                UserBuysId = buy.UserBuysId,
                PurchaseDate = buy.PurchaseDate,
                Details = buy.Details.Select(d => new DetailBuysDto
                {
                    DetailId = d.DetailId,
                    ProductDetailId = d.ProductDetailId,
                    Amount = d.Amount,
                    UnitPrice = d.UnitPrice
                }).ToList(),
                TotalBuy = totalBuy
            };
        }

        public List<BuysDto> GetBuysByUserId(int userId)
        {
            var buys = _buysRepository.GetBuysByUserId(userId);

            return buys.Select(b => new BuysDto
            {
                BuysId = b.BuysId,
                UserBuysId = b.UserBuysId,
                PurchaseDate = b.PurchaseDate,
                Details = b.Details.Select(d => new DetailBuysDto
                {
                    DetailId = d.DetailId,
                    ProductDetailId = d.ProductDetailId,
                    Amount = d.Amount,
                    UnitPrice = d.UnitPrice
                }).ToList(),
                TotalBuy = b.Details.Sum(d => d.Amount * d.UnitPrice)
            }).ToList();
        }

        public int AddBuy(BuysDto buysDto)
        {
            var buy = new Buys
            {
                UserBuysId = buysDto.UserBuysId,
                PurchaseDate = buysDto.PurchaseDate,
                Details = buysDto.Details.Select(d => new DetailBuys
                {
                    ProductDetailId = d.ProductDetailId,
                    Amount = d.Amount,
                    UnitPrice = d.UnitPrice
                }).ToList()
            };

            return _buysRepository.AddBuy(buy);
        }

        public BuysDto UpdateBuy(int buysId, BuysDto buysDto)
        {
            var buy = new Buys
            {
                BuysId = buysId,
                UserBuysId = buysDto.UserBuysId,
                PurchaseDate = buysDto.PurchaseDate,
                Details = buysDto.Details.Select(d => new DetailBuys
                {
                    DetailId = d.DetailId,
                    ProductDetailId = d.ProductDetailId,
                    Amount = d.Amount,
                    UnitPrice = d.UnitPrice
                }).ToList()
            };

            _buysRepository.UpdateBuy(buysId, buy);

            return buysDto;
        }

        public void DeleteBuy(int id)
        {
            _buysRepository.DeleteBuy(id);
        }
    }
}
