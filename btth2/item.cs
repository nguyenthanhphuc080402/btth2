using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace btth2
{
    public class item
    {
        public XmlDocument doc = new XmlDocument();
        public XmlElement root;
        private string fileName = @"..//..//cart.xml";
        public item()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Them(orders order)
        {
            XmlNode item = doc.CreateElement("item");

            XmlElement Name_ = doc.CreateElement("name");
            Name_.InnerText = order.name;
            item.AppendChild(Name_);

            XmlElement Price_ = doc.CreateElement("price");
            Price_.InnerText = order.price.ToString();
            item.AppendChild(Price_);

            XmlElement Sl_ = doc.CreateElement("sl");
            Sl_.InnerText = order.sl.ToString();
            item.AppendChild(Sl_);

            root.AppendChild(item);
            doc.Save(fileName);
        }

        public void xoaAll()
        {
            root.RemoveAll();
            doc.Save(fileName);
        }

    }
}
