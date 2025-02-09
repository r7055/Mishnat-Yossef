using Mishnat_Yossef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Core.InterfaceRepository
{
    public interface IStationRepository: IRepository<Station>
    {
        List<Station> GetAll();
    }
}
