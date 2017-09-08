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
        private Dictionary<string, Type> _providers;

        /// <summary>
        /// Gets the names of the available provider
        /// </summary>
        /// <returns></returns>
        public string[] GetAvailableProviderNames()
        {
            return GetAvailableProvider().Select(p => p.Key).ToArray();
        }

        /// <summary>
        /// Gets all available PRovider
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Type> GetAvailableProvider()
        {
            return _providers ?? (_providers = FindProviders(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
        }

        /// <summary>
        /// Gets a provider by its name
        /// </summary>
        /// <param name="providerName">The name of the provider to find.</param>
        /// <returns></returns>
        public ICodeProvider CreateProvider(string providerName, CodeProviderArguments args)
        {
            Type providerType = null;

            if (_providers.TryGetValue(providerName, out providerType))
            {
                return (ICodeProvider)Activator.CreateInstance(providerType, args);
            }
            else
                throw new ArgumentException($"Provider '{providerName}' not found.");            
        }

        private Dictionary<string, Type> FindProviders(string location)
        {
            var result = new Dictionary<string, Type>();
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
                    {
                        var nameAttribute = providerType.GetCustomAttribute<CodeProviderNameAttribute>();
                        string name = nameAttribute?.Name ?? "Unknown";

                        result.Add(name, providerType);
                    }

                }
                catch (FileLoadException)
                { }
            }

            return result;
        }
    }
}
