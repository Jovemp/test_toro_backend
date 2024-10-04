using System;
using Toro.Domain.Enums;

namespace Toro.Domain.Entities
{
	public class OrderEntity: BaseEntity
	{
		public DateTime Date { get; set; }
		public double Quantity { get; set; }
		public TypeOrder Type { get; set; }
		public StatusOrder Status { get; set; }
        public int BondId { get; set; }
        public virtual BondEntity Bond { get; set; }
        public int? AccountId { get; set; }
        public virtual AccountEntity Account { get; set; }
    }
}

