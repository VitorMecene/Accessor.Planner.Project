using Accessor.Planner.Domain.Model.Commom;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accessor.Planner.Domain.Model
{
    public class Provider: DefaultValues<Guid>
    {
        private Provider() { }
        
        public string Name { get; private set; }
        public string FantasyName { get; private set; }
        public string Cnpj { get; private set; }
        public string Phone { get; private set; }
        public Address Address { get; private set; }
    }
}
