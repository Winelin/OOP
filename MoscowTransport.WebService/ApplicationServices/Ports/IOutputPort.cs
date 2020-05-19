using System;
using System.Collections.Generic;
using System.Text;

namespace DOGobj.ApplicationServices.Ports
{
    public interface IOutputPort<in TUseCaseResponse>
    {
        void Handle(TUseCaseResponse response);
    }
}
