﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeeHive;

namespace ConveyorBelt.Tooling.Scheduling
{
    public interface ISourceScheduler
    {
        Task<Tuple<IEnumerable<Event>, bool>> TryScheduleAsync(DiagnosticsSource source);
    }
}
