using Oqtane.Models;
using Oqtane.Modules;

namespace Trailblazor.Module.Ink
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Ink",
            Description = "plays ink",
            Version = "1.0.0",
            ServerManagerType = "Trailblazor.Module.Ink.Manager.InkManager, Trailblazor.Module.Ink.Server.Oqtane",
            ReleaseVersions = "1.0.0",
            Dependencies = "Trailblazor.Module.Ink.Shared.Oqtane",
            PackageName = "Trailblazor.Module.Ink" 
        };
    }
}
