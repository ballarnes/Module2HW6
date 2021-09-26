using System;
using System.Collections.Generic;
using Module2HW6.Models;

namespace Module2HW6.Providers.Abstractions
{
    public interface ICarProvider
    {
        public Car[] Cars { get; }
    }
}
