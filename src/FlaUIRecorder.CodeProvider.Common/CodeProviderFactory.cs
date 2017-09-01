using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.CodeProvider.Common
{
    public class CodeProviderFactory
    {
        private List<ICodeProvider> _provider;

        /// <summary>
        /// Gets the names of the available provider
        /// </summary>
        /// <returns></returns>
        public string[] GetAvailableProviderNames()
        {
            return GetAvailableProvider().Select(p => p.Name).ToArray();
        }

        /// <summary>
        /// Gets all available PRovider
        /// </summary>
        /// <returns></returns>
        public List<ICodeProvider> GetAvailableProvider()
        {
            return _provider ?? (_provider = FindProviders(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
        }

        /// <summary>
        /// Gets a provider by its name
        /// </summary>
        /// <param name="providerName">The name of the provider to find.</param>
        /// <returns></returns>
        public ICodeProvider GetProvider(string providerName)
        {
            return GetAvailableProvider().Single(p => p.Name == providerName);
        }

        private List<ICodeProvider> FindProviders(string location)
        {
            var result = new List<ICodeProvider>();
            var commonAssemblyFileName = Assembly.GetExecutingAssembly().Location;

            foreach (var fileName in Directory.GetFiles(location, "FlaUIRecorder.CodeProvider.*.dll"))
            {
                if (fileName == commonAssemblyFileName)
                    continue;

                try
                {
                    var assembly = Assembly.LoadFile(fileName);
                    var providerTypes = assembly.ExportedTypes.Where(t => typeof(ICodeProvider).IsAssignableFrom(t));

                    foreach (var providerType in providerTypes)
                        result.Add((ICodeProvider)Activator.CreateInstance(providerType));

                } catch (FileLoadException )
                {}
            }

            return result;
        }        
    }
}
