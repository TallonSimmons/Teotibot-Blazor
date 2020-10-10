﻿using System;
using System.Collections.Generic;
using Teotibot.Core.DataModels;

namespace Teotibot.Core.Repositories
{
    public interface IReadRepository
    {
        public IAsyncEnumerable<T> StreamAllAsync<T>(Func<T, bool> predicate)
            where T : class, IDataModel;
    }
}