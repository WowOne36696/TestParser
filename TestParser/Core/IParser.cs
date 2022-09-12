using AngleSharp.Html.Dom;

namespace TestParser.Core
{
    internal interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
