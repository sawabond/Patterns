using System.Xml;

namespace Adapter;

/// <summary>
/// Sealed class from consumed DLL. Cannot modify it
/// </summary>
internal sealed class XmlDataRetriever : IXmlDataRetriever
{
    public IEnumerable<XmlDocument> GetXmlDocuments()
        =>Enumerable.Empty<XmlDocument>();
}