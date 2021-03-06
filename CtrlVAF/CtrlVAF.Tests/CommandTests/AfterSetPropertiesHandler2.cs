﻿using CtrlVAF.Commands.Commands;
using CtrlVAF.Commands.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlVAF.Tests.CommandTests
{
    public class AfterSetPropertiesHandler2 : ICommandHandler<AfterSetPropertiesCommand<Configuration>>
    {
        public void Handle(AfterSetPropertiesCommand<Configuration> command)
        {
            command.Env.Input = command.Configuration.Name;
        }
    }
}
