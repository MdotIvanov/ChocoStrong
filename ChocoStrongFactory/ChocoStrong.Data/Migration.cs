using System;
using System.Linq;
using System.Collections.Generic;

using System.Data.Entity.Migrations;

namespace ChocoStrong.Data
{
    public sealed class MigrationsConfiguration : DbMigrationsConfiguration<EntityFrameworkContext>
    {
        public MigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ChocoStrong.Data.EntityFrameworkContext";
        }
    }
}
