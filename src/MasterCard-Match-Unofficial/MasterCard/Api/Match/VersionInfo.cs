using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MasterCard.Api.Match
{
    public static class VersionInfo
    {
    internal static string AssemblyVersion {
      get {
        return typeof(VersionInfo)
          .GetTypeInfo()
          .Assembly
          .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
          .InformationalVersion;
      }
    }
    }
}
