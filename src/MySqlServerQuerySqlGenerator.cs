using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class MySqlServerQuerySqlGenerator : SqlServerQuerySqlGenerator
    {
        public MySqlServerQuerySqlGenerator(QuerySqlGeneratorDependencies dependencies) : base(dependencies)
        {

        }

        protected override Expression VisitTable(TableExpression tableExpression)
        {
            var table = base.VisitTable(tableExpression);
            Sql.Append(" WITH (NOLOCK)");

            return table;
        }
    }
}
