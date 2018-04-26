using Plugin.Connectivity;

namespace CloudGamingApplication
{
    class InternetConnection
    {

        public bool ConnectivityCheck()
        {
            var isConnected = CrossConnectivity.Current.IsConnected;

            return isConnected;
        }
    }
}
