namespace HttpRequestBuilder;

public class RequestBuilder : IRequestBuilder
{
    private HttpRequest _request = new HttpRequest();

    public IRequestBuilder Reset()
    {
        _request = new HttpRequest();
        return this;
    }

    public IRequestBuilder SetUrl(string url)
    {
        _request.Url = url;
        return this;
    }

    public IRequestBuilder SetMethod(string method)
    {
        _request.Method = method;
        return this;
    }

    public IRequestBuilder SetHeader(string key, string value)
    {
        _request.Headers[key] = value;
        return this;
    }

    public IRequestBuilder SetBody(object data)
    {
        _request.Headers["Content-Type"] = "application/json";
        _request.Body = data;
        return this;
    }

    public HttpRequest Build()
    {
        if (string.IsNullOrWhiteSpace(_request.Url))
        {
            throw new InvalidOperationException("URL bo'sh bo'lishi mumkin emas!");
        }

        HttpRequest result = _request;
        Reset();
        return result;
    }
}
