using System;
using Toro.Domain.Enums;

namespace Toro.Application.Models.Request
{
	public class OrderRequestCreate
	{
		public int BondId { get; set; }
        public double Quantity { get; set; }
        public TypeOrder Type { get; set; }
        public int AccountId { get; set; }
    }
}

