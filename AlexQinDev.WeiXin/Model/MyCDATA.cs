using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace AlexQinDev.WeiXin.Model
{
    public class MyCDATA : IXmlSerializable
    {
        private string _value;

        public MyCDATA() { }

        public MyCDATA(string value)
        {
            this._value = value;
        }

        public string Value
        {
            get { return _value; }
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            this._value = reader.ReadElementContentAsString();
        }

        void IXmlSerializable.WriteXml(XmlWriter writer)
        {
            writer.WriteCData(this._value);
        }

        public override string ToString()
        {
            return this._value;
        }

        public static implicit operator MyCDATA(string text)
        {
            return new MyCDATA(text);
        }
    }
}
