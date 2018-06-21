using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace BlogEngine
{
    public class PostgresContext : DbContext
    {
        public PostgresContext(DbContextOptions<PostgresContext> options)
        {

        }
    }
}
