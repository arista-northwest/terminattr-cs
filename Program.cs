using System;
using Grpc.Core;
using Openconfig;

namespace terminattr
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("192.168.56.12:50051", ChannelCredentials.Insecure);
            OpenConfig.OpenConfigClient client = new OpenConfig.OpenConfigClient(channel);
            // Subscription subsc = new Subscription();
            // client.Subscribe();
        }
    }
}
