using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.TemplateEngine.Abstractions.Mount;

namespace Microsoft.TemplateEngine.Abstractions
{
    public interface IGenerator : IIdentifiedComponent
    {
        Task Create(ITemplateEngineHost host, ITemplate template, IParameterSet parameters, IComponentManager componentManager);

        IParameterSet GetParametersForTemplate(ITemplate template);

        IEnumerable<ITemplate> GetTemplatesFromSource(IMountPoint source);

        bool TryGetTemplateFromConfig(IFileSystemInfo config, out ITemplate template);

        bool TryGetTemplateFromSource(IMountPoint target, string name, out ITemplate template);

        object ConvertParameterValueToType(ITemplateParameter parameter, string untypedValue);
    }
}