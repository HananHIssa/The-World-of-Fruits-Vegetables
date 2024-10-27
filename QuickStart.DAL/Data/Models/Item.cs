﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.DAL.Data.Models
{
public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool isDelete { get; set; }
    public DateTime Data { get; set; }
    public string ImageName { get; set; }
    public int? PortfolioId { get; set; } 
    public Portfolio Portfolio { get; set; } 
}
}

