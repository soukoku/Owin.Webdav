﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Soukoku.Owin.Webdav.Models
{
    public class NumberProperty : Property<long>
    {
        public NumberProperty(string name) : base(name, Consts.XmlNamespace) { }
        public NumberProperty(string name, string @namespace) : base(name, @namespace) { }

        public override XmlElement Serialize(XmlDocument doc)
        {
            var node = doc.CreateElement(Name, Namespace);
            node.InnerText = Value.ToString();
            return node;
        }
    }

    public class ReadOnlyNumberProperty : DerivedProperty<long>
    {
        public ReadOnlyNumberProperty(string name) : base(name, Consts.XmlNamespace) { }
        public ReadOnlyNumberProperty(string name, string @namespace) : base(name, @namespace) { }


    }
}