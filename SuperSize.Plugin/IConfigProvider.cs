using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Plugin
{
    public interface IConfigProvider
    {

        Config.Object GetConfig();

        void SaveConfig(Config.Object config);
    }
}
