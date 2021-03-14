using SuperSize.Model;
using SuperSize.OS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Scripts
{
    public class FillOutCompletely : SizingLogic
    {
        public override Rectangle Calculate(Screen[] screens)
        {
            return Utilities.GetAllScreenBounds();
        }
    }
}
