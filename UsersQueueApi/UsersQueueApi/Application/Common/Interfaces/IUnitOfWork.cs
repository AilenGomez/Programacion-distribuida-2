﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace UsersQueueApi.Application.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IApplicationDbContext Context { get; }
        public void Commit();
        public Task<int> CommitAsync(CancellationToken cancellationToken);
       
    }
}
