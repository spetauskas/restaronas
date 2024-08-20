using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaronas.services
{
    public interface IScreen
    {
        string Name { get; set; }
        void Show();

    }
}
