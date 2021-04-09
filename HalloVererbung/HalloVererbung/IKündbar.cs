using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloVererbung
{
    public interface IKündbar
    {
        bool IsGekündigt { get; set; }

        void Kündigen();

    }
}
