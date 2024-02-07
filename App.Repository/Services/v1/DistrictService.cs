using App.Database;
using App.Database.Models;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;

namespace App.Repository.Services.v1
{
    public interface IDistrictService
    {
        ValueTask<spDistrict[]> GetAllAsync(ODataQueryOptions<spDistrict> options);
    }

    public class DistrictService : IDistrictService
    {
        private readonly MyDbContext db;

        public DistrictService(MyDbContext db)
        {
            this.db = db;
        }

        public async ValueTask<spDistrict[]> GetAllAsync(ODataQueryOptions<spDistrict> options)
        {

            var storage = db.Set<spDistrict>();
            var query = options.ApplyTo(storage.AsNoTracking().AsQueryable(), AllowedQueryOptions.Supported);
            var cnt = await query.Cast<spDistrict>().ToArrayAsync();
            return cnt;
        }
    }
}
