using System.Net;

IPAddress local1 = new(new byte[] { 127, 0, 0, 1 });
IPAddress local2 = new(0x0100007F);
IPAddress local3;
IPAddress.TryParse("3FFE:FFFF:7654:FEDA:1245:BA98:3210:4562", out local3!);

//Console.WriteLine(local1);
//Console.WriteLine(local2);
//Console.WriteLine(local3);

//Console.WriteLine(IPAddress.Loopback);
//Console.WriteLine(IPAddress.Any);
//Console.WriteLine(IPAddress.Broadcast);

//Console.WriteLine(local3.AddressFamily);

//IPEndPoint endPoint1 = new(local1, 5000);
//Console.WriteLine(endPoint1);

/*

string uriString = "https://user:password@www.mycite.ru:345/home/about?name=Bob&age=34#fragmentTitle";
Uri uri = new Uri(uriString);

Console.WriteLine(uriString + "\n");

Console.WriteLine($"AbsolutePath: {uri.AbsolutePath}");
Console.WriteLine($"AbsoluteUri: {uri.AbsoluteUri}");
Console.WriteLine($"DnsSafeHost: {uri.DnsSafeHost}");
Console.WriteLine($"Fragment: {uri.Fragment}");
Console.WriteLine($"Host: {uri.Host}");
Console.WriteLine($"HostNameType: {uri.HostNameType}");
Console.WriteLine($"IdnHost: {uri.IdnHost}");
Console.WriteLine($"IsAbsoluteUri: {uri.IsAbsoluteUri}");
Console.WriteLine($"IsDefaultPort: {uri.IsDefaultPort}");
Console.WriteLine($"IsFile: {uri.IsFile}");
Console.WriteLine($"IsLoopback: {uri.IsLoopback}");
Console.WriteLine($"IsUnc: {uri.IsUnc}");
Console.WriteLine($"LocalPath: {uri.LocalPath}");
Console.WriteLine($"OriginalString: {uri.OriginalString}");
Console.WriteLine($"PathAndQuery: {uri.PathAndQuery}");
Console.WriteLine($"Port: {uri.Port}");
Console.WriteLine($"Query: {uri.Query}");
Console.WriteLine($"Scheme: {uri.Scheme}");
Console.WriteLine($"Segments: {string.Join(", ", uri.Segments)}");
Console.WriteLine($"UserEscaped: {uri.UserEscaped}");
Console.WriteLine($"UserInfo: {uri.UserInfo}");


UriBuilder uriBuilder = new UriBuilder();
uriBuilder.Host = "localhost";
uriBuilder.Port = 4000;
uriBuilder.Path = "about/director";
uriBuilder.Query = "name=Tom&age=23";
uriBuilder.Scheme = "https";
uriBuilder.Fragment = "fragment1";
Console.WriteLine(uriBuilder.ToString());
*/


var yandexEntry = await Dns.GetHostEntryAsync("yandex.ru");
Console.WriteLine(yandexEntry.HostName);
foreach(var ip in yandexEntry.AddressList)
    Console.WriteLine(ip);
Console.WriteLine();


var yandexAddrs = await Dns.GetHostAddressesAsync(yandexEntry.HostName);
foreach (var ip in yandexAddrs)
    Console.WriteLine(ip);