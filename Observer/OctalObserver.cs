using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return "Octal string: " + Convert.ToDecimal(this.subject.GetState());
        }
    }
}
