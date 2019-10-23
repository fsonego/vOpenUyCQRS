using System;
using vOpenUYCQRS.Common;

namespace vOpenUYCQRS.Infrastructure
{
    public class MachineDateTime : IDateTime
    {
        public DateTime Now => DateTime.Now;

        public int CurrentYear => DateTime.Now.Year;
    }
}
