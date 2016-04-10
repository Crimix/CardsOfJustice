using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ICard
    {
        string ValueString { get; }
        string ColorString { get; }
        Card.value Value { get; }
        Card.color Color { get; }
    }
}
