using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace A_DRP
{
	public class Territories
	{
		public XDocument _territories = XDocument.Load("datas/Territories.xml");

		public Territories ()
		{
			
		}

		public IEnumerable<XElement> getTerritory()
		{
			return _territories.Root.Elements().ToList();
		}
	}
}

