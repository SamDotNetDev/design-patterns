namespace HttpRequestBuilder;

public interface IRequestBuilder
{
    IRequestBuilder Reset();
    IRequestBuilder SetUrl(string url);
    IRequestBuilder SetMethod(string method);
    IRequestBuilder SetHeader(string key, string value);
    IRequestBuilder SetBody(object data);
    HttpRequest Build();
}
