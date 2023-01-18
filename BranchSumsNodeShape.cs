using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeansAlgoExpertConsoleApp
{
    public class BranchSumsNodeShape
    {
        
        public string Id { get; set; }
        public string? Left { get; set; }
        public string? Right { get; set; }
        public int Value { get; set; }

        public BranchSumsNodeShape(string id, string? left, string? right, int value)
        {
            Id = id;
            Left = left;
            Right = right;
            Value = value;
        }

        
    }
}
