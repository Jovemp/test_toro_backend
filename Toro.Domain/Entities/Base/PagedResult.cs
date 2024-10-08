﻿using System;
namespace Toro.Domain.Entities.Base
{
	public class PagedResult<T>
	{
        public IEnumerable<T> Items { get; set; } = new List<T>();
        public int TotalCount { get; set; }
    }
}

