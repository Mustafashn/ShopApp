using System;
using System.Collections.Generic;
using shopapp.entity;


namespace shopapp.webui.Models
{
    public class PageInfo
        {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentCategory { get; set; }
        public int totalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }

    }
    public class ProductListViewModels
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}