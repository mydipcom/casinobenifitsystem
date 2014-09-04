
using DIPSky.Core.Configuration;

namespace DIPSky.Core.Domain.Common
{
    public class AdminAreaSettings : ISettings
    {
        public int GridPageSize { get; set; }

        public bool DisplayProductPictures { get; set; }
    }
}