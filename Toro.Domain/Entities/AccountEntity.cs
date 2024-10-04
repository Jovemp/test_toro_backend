using System;
namespace Toro.Domain.Entities
{
	public class AccountEntity : BaseEntity
    {
		public string ClientId { get; set; }
		public double Balance { get; set; }

        public ICollection<OrderEntity> Orders { get; set; }
    }
}

