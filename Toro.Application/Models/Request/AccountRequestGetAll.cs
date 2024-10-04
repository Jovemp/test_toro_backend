using System;
namespace Toro.Application.Models.Request
{
	public class AccountRequestGetAll
	{
        public string? FilterField { get; set; }
        public string? FilterValue { get; set; }
        public string? SortField { get; set; }
        public bool SortDescending { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}

