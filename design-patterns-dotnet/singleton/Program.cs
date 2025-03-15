using Singleton.Model;

HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("");

var log = LogSingleton.GetInstance();

log.Write("My log message");
