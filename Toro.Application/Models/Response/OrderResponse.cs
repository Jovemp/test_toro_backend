using System;
using Toro.Domain.Entities;
using Toro.Domain.Enums;

namespace Toro.Application.Models.Response
{
	public class OrderResponse
	{
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Quantity { get; set; }
        public TypeOrder Type { get; set; }
        public StatusOrder Status { get; set; }
        public int BondId { get; set; }
        public virtual BondResponse Bond { get; set; }
        public int? AccountId { get; set; }
        public virtual AccountResponse Account { get; set; }
    }
}

