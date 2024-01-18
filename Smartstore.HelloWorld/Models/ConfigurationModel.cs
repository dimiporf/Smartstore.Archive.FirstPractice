using Smartstore.Web.Modelling;

namespace Smartstore.HelloWorld.Models
{
    [LocalizedDisplay("Plugins.Smartstore.HelloWorld.")]
    public class ConfigurationModel : ModelBase
    {
        [LocalizedDisplay("*Name")]
        public string Name { get; set; }
    }
}