﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kooboo.Data.Models;

namespace Kooboo.Web.ViewModel
{
    public class AppViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string ThumbNail { get; set; }

        public string Category { get; set; }

        public int Size { get; set; }

        public string Description { get; set; }

        public int Score { get; set; } = 100;

        public DateTime LastModified { get; set; }

        public long DownloadCount { get; set; }

        public int PageCount { get; set; }

        public int ContentCount { get; set; }

        public int ImageCount { get; set; }

        public int LayoutCount { get; set; }

        public int MenuCount { get; set; }

        public int ViewCount { get; set; }

        public decimal Price { get; set; }

        public CurrencyViewModel Currency { get; set; }

        public bool CanTrial { get; set; }
    }
}
