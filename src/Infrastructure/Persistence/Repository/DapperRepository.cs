using System.Collections.Generic;
using System.Data;
using System.Linq.Dynamic.Core;
using Dapper;
using Finbuckle.MultiTenant.EntityFrameworkCore;
using FSH.WebApi.Application.Common.Persistence;
using FSH.WebApi.Domain.Common.Contracts;
using FSH.WebApi.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Http;

namespace FSH.WebApi.Infrastructure.Persistence.Repository;

public class DapperRepository : IDapperRepository
{
    private readonly ApplicationDbContext _dbContext;

    public DapperRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

    public async Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
    where T : class, IEntity
    {
        if (_dbContext.Model.GetMultiTenantEntityTypes().Any(t => t.ClrType == typeof(T)))
        {
            sql = sql.Replace("@tenant", _dbContext.TenantInfo.Id);
        }

        return (await _dbContext.Connection.QueryAsync<T>(sql, param, transaction))
            .AsList();
    }

    public async Task<T?> QueryFirstOrDefaultAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
    where T : class, IEntity
    {
        if (_dbContext.Model.GetMultiTenantEntityTypes().Any(t => t.ClrType == typeof(T)))
        {
            sql = sql.Replace("@tenant", _dbContext.TenantInfo.Id);
        }

        return await _dbContext.Connection.QueryFirstOrDefaultAsync<T>(sql, param, transaction);
    }

    public Task<T> QuerySingleAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
    where T : class, IEntity
    {
        if (_dbContext.Model.GetMultiTenantEntityTypes().Any(t => t.ClrType == typeof(T)))
        {
            sql = sql.Replace("@tenant", _dbContext.TenantInfo.Id);
        }

        return _dbContext.Connection.QuerySingleAsync<T>(sql, param, transaction);
    }

    public async Task<List<dynamic>> ExecSpQueryDynamicAsync(string spname, Dictionary<string, object>? param = null, bool isTenantRequired = true, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
    {
        if (isTenantRequired)
        {
            string tenantIdValue = _dbContext.TenantInfo.Id!;
            param.Add("@TenantId", tenantIdValue);
        }

        // if (param is not null)
        // {
        //    foreach (KeyValuePair<string, object> kvp in param)
        //        dictionary.Add(kvp.Key, kvp.Value);
        // }

        var parameters = new DynamicParameters(param);
        return await _dbContext.Connection.QueryAsync(spname, parameters, commandType: CommandType.StoredProcedure).Result.ToDynamicListAsync(cancellationToken: cancellationToken);
    }

    public Task<int> ExecSpNonQueryAsync(string spname, Dictionary<string, object>? param = null, bool isTenantRequired = true, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
    {
        if (isTenantRequired)
        {
            string tenantIdValue = _dbContext.TenantInfo.Id!;
            param.Add("@TenantId", tenantIdValue);
        }

        var parameters = new DynamicParameters(param);
        var result = _dbContext.Connection.ExecuteAsync(spname, parameters, transaction, null, commandType: CommandType.StoredProcedure);
        return result;
    }

    public async Task<IReadOnlyList<T>> ExecSpQueryAsync<T>(string spname, Dictionary<string, object>? param, bool isTenantRequired, IDbTransaction? transaction, CancellationToken cancellationToken)
    where T : class, IEntity
    {
        if (isTenantRequired)
        {
            string tenantIdValue = _dbContext.TenantInfo.Id!;
            param.Add("@TenantId", tenantIdValue);
        }

        var parameters = new DynamicParameters(param);
        return await _dbContext.Connection.QueryAsync<T>(spname, parameters, commandType: CommandType.StoredProcedure).Result.ToDynamicListAsync<T>(cancellationToken: cancellationToken);
    }
}