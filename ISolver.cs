using System;
using System.Collections.Generic;
using System.Text;

namespace SATInterface
{
    public interface ISolver:IDisposable
    {
        public void AddVars(int _number);
        public bool AddClause(Span<int> _clause);

        public bool[]? Solve(int[]? _assumptions = null);

        internal void ApplyConfiguration(Configuration _config);
    }
}
