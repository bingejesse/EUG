﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DareneExpressCabinetClient.Service
{
    interface ELocksManagerService
    {
        ELock GetLock(int boxCode);
    }
}
