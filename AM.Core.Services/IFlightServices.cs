using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public interface IFlightServices
    {
        IList<DateTime> GetFlightDates(string destination);
            
    }
}
