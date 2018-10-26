using System;
using Grpc.Core;
using Gnmi;
using GnmiExt;
using System.Collections.Generic;


namespace terminattr
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("192.168.56.12:6042", ChannelCredentials.Insecure);
            gNMI.gNMIClient client = new gNMI.gNMIClient(channel);

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
            path.Elem.Add(new PathElem { Name = "sys" });
            path.Elem.Add(new PathElem { Name = "net" });
            path.Elem.Add(new PathElem { Name = "config" });

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
    }
}
