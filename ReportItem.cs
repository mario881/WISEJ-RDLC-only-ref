using System;
using System.Collections.Generic;
using System.Text;

namespace  WisejWebDesktopApplication1

{
    public class ReportItem
	{
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int Qty { get; set; }
		public decimal Total => Price * Qty;
	}
}
