namespace Adapter;

public class CallingCode
{
    public static void Main()
    {
        var xmlRetriever = new XmlDataRetriever();
        
        // Error: incompatible interfaces
        // ClientCodeWhichExpectesJsonEnumerable(xmlRetriever.GetXmlDocuments());
        
        var xmlToJsonAdapter = new XmlToXmlToJsonDataRetrieverAdapter(xmlRetriever);
        ClientCodeWhichExpectesJsonEnumerable(xmlToJsonAdapter.GetJsonData());
    }

    private static void ClientCodeWhichExpectesJsonEnumerable(IEnumerable<string> jsonArray)
    {
        
    }
}