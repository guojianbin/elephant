﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Takenet.Elephant.Tests.Sql.PostgreSql
{
    [Collection(nameof(PostgreSql)), Trait("Category", nameof(PostgreSql))]
    public class PostgreSqlIntegerStringMapFacts : SqlIntegerStringMapFacts
    {
        public PostgreSqlIntegerStringMapFacts(PostgreSqlFixture fixture) : base(fixture)
        {
        }
    }
}
