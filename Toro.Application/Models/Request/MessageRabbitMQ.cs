using System;
namespace Toro.Application.Models.Request
{
	public class MessageRabbitMQ
	{
		public string Content { get; set; }
		public DateTime Timestamp { get; set; }
	}
}

