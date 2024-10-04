using System;
namespace Toro.Application.Models.Response
{
	public class BondResponse
	{
        public int Id { get; set; }
        public string BondAsset { get; set; } 
        public string Index { get; set; } 
        public double Tax { get; set; }
        public string IssuerName { get; set; } 
        public double UnitPrice { get; set; } 
        public double Stock { get; set; } 
    }
}

