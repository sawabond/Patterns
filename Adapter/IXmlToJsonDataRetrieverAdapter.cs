namespace Adapter;

public interface IXmlToJsonDataRetrieverAdapter
{
    IEnumerable<string> GetJsonData();
}