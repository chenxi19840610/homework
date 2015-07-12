using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIH.RT.TPS.ApiModel.Dtos;

namespace UIH.RT.TPS.Client.Clients
{
    public interface IWindowsClient
    {
        void CreateWindow(WindowUnit windowUnit);
    }
}
