﻿using Microsoft.EntityFrameworkCore;

namespace vOpenUYCQRS.Persistence
{
    public class NorthwindDbContextFactory : DesignTimeDbContextFactoryBase<NorthwindDbContext>
    {
        protected override NorthwindDbContext CreateNewInstance(DbContextOptions<NorthwindDbContext> options)
        {
            return new NorthwindDbContext(options);
        }
    }
}
