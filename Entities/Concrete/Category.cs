﻿using Entities.Abstract; 
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{ 
    // çıplak class  kalmasın 
    public class Category:IEntity 
    {
        public int CotegoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
