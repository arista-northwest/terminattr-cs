using System;
using Grpc.Core;
using Gnmi;
using System.Collections.Generic;
using System.Linq;


namespace terminattr
{
    class Program
    {
        static void Main(string[] args)
        {
            string dut;
            Console.Write("Enter DUT IP address - ");
            dut = Console.ReadLine();
            if (dut.Length == 0)
            {
                dut = @"172.24.70.163";
            }

            string pathString;
            Console.Write("Enter Path to subscribe to - ");
            pathString = Console.ReadLine();
            if (pathString.Length == 0)
            {
                pathString = @"environment";
            }


            Channel channel = new Channel(dut, 6042, ChannelCredentials.Insecure);
            gNMI.gNMIClient client = new gNMI.gNMIClient(channel);

            string method;
            Console.Write("Subscribe or get - ");
            method = Console.ReadLine();
            if (method.Length == 0)
            {
                method = @"get";
            }

            //requests = []
            //for path in paths:
            //    path = self._to_ocpath(path)
            //    subscription = pb.Subscription(path = path)
            //    subls = pb.SubscriptionList(subscription = [subscription])
            //    requests.append(pb.SubscribeRequest(subscribe = subls))

            //for response in self._stub.Subscribe(requests, self._timeout):
            //    yield response
            Path path = new Path();

            path.Elem.Add(new PathElem { Name = "Sysdb" });
            //path.Elem.Add(new PathElem { Name = "sys" });
            //path.Elem.Add(new PathElem { Name = "net" });
            //path.Elem.Add(new PathElem { Name = "config" });

            if ( method == "get")
            {

                GetRequest getreq = new GetRequest();
                getreq.Path.Add(path);
                GetResponse resp = client.Get(getreq);
                Console.WriteLine("=============================");
                foreach (Notification item in resp.Notification)
                {

                    foreach (Update upd in item.Update)
                    {
                        Console.WriteLine("-------");
                        Console.WriteLine(upd.Path);
                        //Console.WriteLine(upd.Value.Type);
                        Console.WriteLine(upd.Value.Value_.ToStringUtf8());
                    }
                }
                Console.Read();
            }
            else if ( method == "subscribe")
            {

                SubscriptionList subscriptionList = new SubscriptionList
                {
                    Mode = SubscriptionList.Types.Mode.Stream,
                    UseAliases = false,
                    Prefix = path
                };

                Path subscriptionPath = new Path();

                foreach (var element in pathString.Split('/').ToList())
                {
                    string fixElement = element.Trim();
                    if (element.Contains('\\'))
                    {
                        fixElement = element.Replace('\\', '/');
                    }

                    PathElem pathElem = new PathElem { Name = fixElement };
                    subscriptionPath.Elem.Add(pathElem);
                }

                subscriptionList.Subscription.Add(new Subscription() { Mode = SubscriptionMode.OnChange, Path = subscriptionPath });

                SubscribeRequest subscribeRequest = new SubscribeRequest { Subscribe = subscriptionList };
                IAsyncStreamReader<SubscribeResponse> responseStream = null;

                try
                {
                    var call = client.Subscribe();
                    call.RequestStream.WriteAsync(subscribeRequest).Wait();
                    call.RequestStream.CompleteAsync().Wait();
                    responseStream = call.ResponseStream;
                }
                catch (RpcException exception)
                {
                    Console.WriteLine("{0}", exception);
                }

                while (channel.State == ChannelState.Ready)
                {
                    if (responseStream == null)
                    {
                        Environment.Exit(-1);
                    }

                    if (!responseStream.MoveNext().Result)
                    {
                        Environment.Exit(-1);
                    }
                 
                    SubscribeResponse currResponse = responseStream.Current;
                    if (currResponse.Update != null)
                    {
                        var elements = currResponse.Update.Prefix.Elem;
                        var elementsOldFormat = currResponse.Update.Prefix.Element;
                        var prefixPathString = elementsOldFormat.Aggregate(string.Empty, (current, element) => current + "/" + element);
 
                    foreach (var update in currResponse.Update.Update)
                    {
                        elementsOldFormat = update.Path.Element;
                        var updatePathString = elementsOldFormat.Aggregate(string.Empty, (current, element) => current + "/" + element);
                        Console.WriteLine("{0}:{1}", $"{prefixPathString},{updatePathString}", update.Value.Value_.ToStringUtf8());
                        }
                    }
                }
            }
            
        }
    }
}
