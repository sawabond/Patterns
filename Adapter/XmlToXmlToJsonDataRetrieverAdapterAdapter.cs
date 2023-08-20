using System.Xml;

namespace Adapter;

public class XmlToXmlToJsonDataRetrieverAdapterAdapter : IXmlToJsonDataRetrieverAdapter
{
    private readonly IXmlDataRetriever _dataRetriever;

    public XmlToXmlToJsonDataRetrieverAdapterAdapter(IXmlDataRetriever dataRetriever)
    {
        _dataRetriever = dataRetriever;
    }
    
    public IEnumerable<string> GetJsonData()
    {
        var data = _dataRetriever.GetXmlDocuments();
        var json = data.Select(ConvertXmlToJson);

        return json;
    }

    private string ConvertXmlToJson(XmlDocument document) => document.ToString();
}