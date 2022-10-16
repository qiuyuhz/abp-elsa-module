using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Passingwind.Abp.ElsaModule.Common;

public interface IWorkflowInstanceRepository : IRepository<WorkflowInstance, Guid>
{
    Task<long> GetCountAsync(string name = null, Guid? definitionId = null, Guid? definitionVersionId = null, int? version = null, WorkflowInstanceStatus? status = null, string correlationId = null, CancellationToken cancellationToken = default);

    Task<List<WorkflowInstance>> GetListAsync(string name = null, Guid? definitionId = null, Guid? definitionVersionId = null, int? version = null, WorkflowInstanceStatus? status = null, string correlationId = null, bool includeDetails = false, CancellationToken cancellationToken = default);

    Task<List<WorkflowInstance>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting, string name = null, Guid? definitionId = null, Guid? definitionVersionId = null, int? version = null, WorkflowInstanceStatus? status = null, string correlationId = null, bool includeDetails = false, CancellationToken cancellationToken = default);

    Task<Dictionary<DateTime, int>> GetStatusDateCountStatisticsAsync(WorkflowInstanceStatus WorkflowInstanceStatus, DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default);

}

