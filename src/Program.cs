using System;
using Grpc.Core;
using Gnmi;
using GnmiExt;


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

            Subscription subscription = new Subscription();
            Path subpath = new Path();
            subpath.Target = "/Sysdb";

            subscription.Path = subpath;

            SubscriptionList subls = new SubscriptionList();

            subls.Mode = SubscriptionList.Types.Mode.Stream;
            subls.Prefix = subpath;

            SubscribeRequest subreq = new SubscribeRequest();
            subreq.Subscribe = subls;

            //foreach (var resp in subreq.)
            //{
            //    resp.
            //}
            client.Subscribe();
        }
    }
}
