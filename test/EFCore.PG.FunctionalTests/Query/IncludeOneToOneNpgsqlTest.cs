﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class IncludeOneToOneNpgsqlTest : IncludeOneToOneTestBase, IClassFixture<OneToOneQueryNpgsqlFixture>
    {
        readonly OneToOneQueryNpgsqlFixture _fixture;

        public IncludeOneToOneNpgsqlTest(OneToOneQueryNpgsqlFixture fixture)
        {
            _fixture = fixture;
        }

        protected override DbContext CreateContext()
        {
            return _fixture.CreateContext();
        }
    }
}
