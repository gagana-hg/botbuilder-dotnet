﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Bot.Builder.Integration.AspNet.Core
{
    internal abstract class StreamRequestHandler<T>
    {
        public abstract Task<T> ProcessRequestAsync(T request);
    }
}