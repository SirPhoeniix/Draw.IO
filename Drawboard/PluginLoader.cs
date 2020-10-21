using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Drawboard
{
    public static class PluginLoader
    {
        public static ICollection<IPluginTool> LoadPlugins(string szPath)
        {
            string[] dllFileNames = null;
            if (Directory.Exists(szPath))
            {
                dllFileNames = Directory.GetFiles(szPath, "*.dll");
            }

            ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Length);
            foreach (string dllFile in dllFileNames)
            {
                AssemblyName an = AssemblyName.GetAssemblyName(dllFile);
                Assembly assembly = Assembly.Load(an);
                assemblies.Add(assembly);
            }

            Type pluginType = typeof(IPluginTool);
            ICollection<Type> pluginTypes = new List<Type>();
            foreach (Assembly assembly in assemblies)
            {
                if (assembly != null)
                {
                    Type[] types = assembly.GetTypes();
                    foreach (Type type in types)
                    {
                        if (type.IsInterface || type.IsAbstract)
                        {
                            continue;
                        }
                        else
                        {
                            if (type.GetInterface(pluginType.FullName) != null)
                            {
                                pluginTypes.Add(type);
                            }
                        }
                    }
                }
            }

            ICollection<IPluginTool> plugins = new List<IPluginTool>(pluginTypes.Count);
            foreach (Type type in pluginTypes)
            {
                IPluginTool plugin = (IPluginTool)Activator.CreateInstance(type);
                plugins.Add(plugin);
            }

            return plugins;
        }
    }
}
