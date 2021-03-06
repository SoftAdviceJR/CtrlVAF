﻿using MFiles.VAF.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlVAF.Commands.Commands
{
    public class AfterDeleteViewCommand<T> : IEventHandlerCommand<T>
    {
        public EventHandlerEnvironment Env { get; set; }
        public T Configuration { get; set; }
    }
}
