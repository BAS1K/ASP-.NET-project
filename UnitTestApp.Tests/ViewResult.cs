using System.Collections.Generic;

namespace UnitTestApp.Tests
{
    internal class ViewResult
    {
        public IEnumerable<char> ViewName { get; internal set; }
        public object Model { get; internal set; }
    }
}