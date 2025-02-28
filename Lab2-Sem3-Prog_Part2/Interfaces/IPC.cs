using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface IPC
    {
        public double memory { get; set; }
        public double CPU_performance {  get; set; }
        public OS os { get; set; }
    }
}
