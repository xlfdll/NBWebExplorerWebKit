using Xlfdll.Configuration;
using Xlfdll.Windows.Configuration;

namespace NBWebExplorerWebKit
{
    internal static class ApplicationHelper
    {
        static ApplicationHelper()
        {
            ApplicationHelper.Settings = new AppSettings(new ApplicationConfiguration
                (new RegistryConfigurationProcessor(@"Xlfdll\NB\NBWebExplorer", RegistryConfigurationScope.User)));
        }

        internal static AppSettings Settings { get; }
    }
}