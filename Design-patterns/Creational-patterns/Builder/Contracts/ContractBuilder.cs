using Builder.Entities;
using System.Collections.Generic;

namespace Builder.Contracts
{
    public abstract class ContractBuilder
    {
        protected Contract _contract;

        public ContractBuilder()
        {
            _contract = new Contract();
        }

        public Contract GetContract()
        {
            return _contract;
        }

        public abstract void SetContractHolder(Person contractHolder);
        public abstract void AddContractBeneficiaries(IList<Person> beneficiaries);
        public abstract void AddBenefits();
    }
}
