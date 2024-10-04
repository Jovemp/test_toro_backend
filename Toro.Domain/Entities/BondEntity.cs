using System;
namespace Toro.Domain.Entities
{
	public class BondEntity : BaseEntity
	{
        public string BondAsset { get; set; } // Tipo do Produto de Renda Fixa
        public string Index { get; set; } // Indexador (ex: IPCA, Selic, etc)
        public double Tax { get; set; } // Taxa atrelada ao Indexador
        public string IssuerName { get; set; } // Emissor do Produto
        public double UnitPrice { get; set; } // Preço unitário do Produto
        public double Stock { get; set; } // Estoque do produto

        public ICollection<OrderEntity> Orders { get; set; }

        public BondEntity(string bondAsset, string index, double tax, string issuerName, double unitPrice, double stock)
        {
            BondAsset = bondAsset;
            Index = index;
            Tax = tax;
            IssuerName = issuerName;
            UnitPrice = unitPrice;
            Stock = stock;
        }

        public BondEntity(int id, string bondAsset, string index, double tax, string issuerName, double unitPrice, double stock)
        {
            Id = id;
            BondAsset = bondAsset;
            Index = index;
            Tax = tax;
            IssuerName = issuerName;
            UnitPrice = unitPrice;
            Stock = stock;
        }

        // Sobrescreve o método ToString para exibir informações de forma amigável
        public override string ToString()
        {
            return $"Produto: {BondAsset}, Indexador: {Index}, Taxa: {Tax}%, Emissor: {IssuerName}, Preço Unitário: R$ {UnitPrice}, Estoque: {Stock}";
        }
    }
}

