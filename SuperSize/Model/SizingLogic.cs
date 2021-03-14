using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Model
{
    public abstract class SizingLogic
    {

        public Rectangle Calculate() => Calculate(Screen.GetAllScreens());

        public abstract Rectangle Calculate(Screen[] screens);
    }
}
