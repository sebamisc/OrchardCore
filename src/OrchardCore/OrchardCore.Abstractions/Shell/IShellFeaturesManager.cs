using System.Collections.Generic;
using System.Threading.Tasks;
using OrchardCore.Environment.Extensions;
using OrchardCore.Environment.Extensions.Features;

namespace OrchardCore.Environment.Shell
{
    public interface IShellFeaturesManager
    {
        Task<IEnumerable<IFeatureInfo>> GetEnabledFeaturesAsync();
        Task<IEnumerable<IFeatureInfo>> EnableFeaturesAsync(IEnumerable<IFeatureInfo> features);
        Task<IEnumerable<IFeatureInfo>> EnableFeaturesAsync(IEnumerable<IFeatureInfo> features, bool force);
        Task<IEnumerable<IFeatureInfo>> GetDisabledFeaturesAsync();
        Task<IEnumerable<IFeatureInfo>> DisableFeaturesAsync(IEnumerable<IFeatureInfo> features);
        Task<IEnumerable<IFeatureInfo>> DisableFeaturesAsync(IEnumerable<IFeatureInfo> features, bool force);
        Task DisableEnableFeaturesAsync(IEnumerable<IFeatureInfo> disabled, IEnumerable<IFeatureInfo> enabled, bool force = true);
        Task<IEnumerable<IExtensionInfo>> GetEnabledExtensionsAsync();
    }
}
