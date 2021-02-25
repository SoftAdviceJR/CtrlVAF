﻿using CtrlVAF.Events.Handlers;
using CtrlVAF.Core.Attributes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlVAF.Tests.LicensingTests
{
    [LicenseRequired]
    class LicensedCommandHandler_AllModules : EventHandler<Configuration, TestLicenseCommand>
    {
        public override void Handle(TestLicenseCommand command)
        {
            command.Result *= 3;
        }
    }
}
