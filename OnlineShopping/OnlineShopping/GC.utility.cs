using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Dynamic.Script_8D9778F24A37674
{
	// Script generated by Pega Robot Studio 19.1.21.0
	// Please use caution when modifying class name, namespace or attributes
	[OpenSpan.TypeManagement.DynamicTypeAttribute()]
	[OpenSpan.Design.ComponentIdentityAttribute("Script-8D9778F24A37674")]
	public sealed class Script
	{
		public int PriceFormatConversion(string price)
		{
            price = price.Remove(0, 1);
            string[] priceList = price.Split(',');
            price = string.Join("", priceList);
            return Int32.Parse(price);
        }
	}
}