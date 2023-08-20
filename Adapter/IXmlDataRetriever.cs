using System.Xml;

namespace Adapter;

public interface IXmlDataRetriever
{
    IEnumerable<XmlDocument> GetXmlDocuments();
}