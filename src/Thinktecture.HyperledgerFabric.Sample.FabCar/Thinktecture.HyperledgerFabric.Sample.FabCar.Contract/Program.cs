using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Thinktecture.HyperledgerFabric.Chaincode;
using Thinktecture.HyperledgerFabric.Chaincode.Handler;

namespace Thinktecture.HyperledgerFabric.Sample.FabCar.Contract
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var provider = ChaincodeProviderConfiguration.ConfigureWithContracts<global::Thinktecture.HyperledgerFabric.Sample.FabCar.Contract.FabCar>(args))
            {
                var shim = provider.GetRequiredService<Shim>();
                await shim.Start();
            }
        }
    }
}
