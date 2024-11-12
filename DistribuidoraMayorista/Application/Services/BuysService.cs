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
                    DetailBuysId = d.DetailBuysId,
                    ProductId = d.ProductId,
                    ProductName = d.ProductName,
                    UnitPrice = d.UnitPrice,
                    Quantity = d.Quantity
                }).ToList(),
                TotalBuy = b.TotalBuy
            }).ToList();
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
                    DetailBuysId = d.DetailBuysId,
                    ProductId = d.ProductId,
                    ProductName = d.ProductName,
                    UnitPrice = d.UnitPrice,
                    Quantity = d.Quantity
                }).ToList(),
                TotalBuy = b.TotalBuy
            }).ToList();
        }

        public BuysDto AddBuy(BuysDto buysDto)
        {
            var buy = new Buys
            {
                UserBuysId = buysDto.UserBuysId,
                PurchaseDate = buysDto.PurchaseDate,
                Details = buysDto.Details.Select(d => new DetailBuys
                {
                    ProductId = d.ProductId,
                    ProductName = d.ProductName,
                    UnitPrice = d.UnitPrice,
                    Quantity = d.Quantity
                }).ToList()
            };

            var createdBuy = _buysRepository.AddBuy(buy);

            return new BuysDto
            {
                BuysId = createdBuy.BuysId,
                UserBuysId = createdBuy.UserBuysId,
                PurchaseDate = createdBuy.PurchaseDate,
                Details = createdBuy.Details.Select(d => new DetailBuysDto
                {
                    DetailBuysId = d.DetailBuysId,
                    ProductId = d.ProductId,
                    ProductName = d.ProductName,
                    UnitPrice = d.UnitPrice,
                    Quantity = d.Quantity
                }).ToList(),
                TotalBuy = createdBuy.TotalBuy
            };
        }
    }
}
