using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public abstract class BasePage
    {
        protected Driver InstDriver { get; private set; }

        protected BasePage()
        {
            InstDriver = Driver.GetDriverInstance();
        }
    }
}
