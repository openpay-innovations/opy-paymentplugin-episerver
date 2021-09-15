﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Openpay.EpiCommerce.AddOns.PaymentGateway.Models.Widget
{
    public class ProductListingWidgetViewModel : WidgetViewModelBase
    {
        public decimal ProductPrice { get; set; }
        public string ListingPageWidgetLogo { get; set; }
        public bool HideLogo { get; set; }
        public bool ShowWidget { get; set; }
    }
}