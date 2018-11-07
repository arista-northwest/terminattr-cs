//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace terminattr
//{
//    using Gnmi;
//    using Grpc.Core;

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string dut;
//            Console.Write("Enter DUT IP address - ");
//            dut = Console.ReadLine();
//            if ( dut.Length == 0)
//            {
//                dut = @"172.24.70.63";
//            }

//            string pathString;
//            Console.Write("Enter Path to subscribe to - ");
//            pathString = Console.ReadLine();
//            if ( pathString.Length == 0)
//            {
//                 pathString = @"environment/temperature/config";
//            }


//            Channel channel = new Channel(dut, 6042, ChannelCredentials.Insecure);

//            gNMI.gNMIClient client = new gNMI.gNMIClient(channel);

//            PathElem prefixElem = new PathElem { Name = "Sysdb" };
//            Path path = new Path();
//            path.Elem.Add(prefixElem);

//            SubscriptionList subscriptionList = new SubscriptionList
//            {
//                Mode = SubscriptionList.Types.Mode.Stream,
//                UseAliases = false,
//                Prefix = path
//            };

//            //var pathString = @"environment/temperature/config";
//            Path subscriptionPath = new Path();

//            foreach (var element in pathString.Split('/').ToList())
//            {
//                string fixElement = element.Trim();
//                if (element.Contains('\\'))
//                {
//                    fixElement = element.Replace('\\', '/');
//                }

//                PathElem pathElem = new PathElem { Name = fixElement };
//                subscriptionPath.Elem.Add(pathElem);
//            }

//            subscriptionList.Subscription.Add(new Subscription() { Mode = SubscriptionMode.Sample, Path = subscriptionPath });

//            SubscribeRequest subscribeRequest = new SubscribeRequest { Subscribe = subscriptionList };
//            IAsyncStreamReader<SubscribeResponse> responseStream = null;

//            try
//            {
//                var call = client.Subscribe();
//                call.RequestStream.WriteAsync(subscribeRequest).Wait();
//                call.RequestStream.CompleteAsync().Wait();
//                responseStream = call.ResponseStream;
//            }
//            catch (RpcException exception)
//            {
//                Console.WriteLine("{0}", exception);
//            }

//            while (channel.State == ChannelState.Ready)
//            {
//                if (responseStream == null)
//                {
//                    Environment.Exit(-1);
//                }

//                if (!responseStream.MoveNext().Result)
//                {
//                    Environment.Exit(-1);
//                }

//                SubscribeResponse currResponse = responseStream.Current;
//                if (currResponse.Update != null)
//                {
//                    var elements = currResponse.Update.Prefix.Elem;
//                    var elementsOldFormat = currResponse.Update.Prefix.Element;
//                    var prefixPathString = elementsOldFormat.Aggregate(string.Empty, (current, element) => current + "/" + element);

//                    foreach (var update in currResponse.Update.Update)
//                    {
//                        elementsOldFormat = update.Path.Element;
//                        var updatePathString = elementsOldFormat.Aggregate(string.Empty, (current, element) => current + "/" + element);
//                        Console.WriteLine("{0}:{1}", $"{prefixPathString},{updatePathString}", update.Value.Value_.ToStringUtf8());
//                    }
//                }
//            }
//        }
//    }
//}

