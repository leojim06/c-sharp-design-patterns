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
            Contract newContract = _contract;
            return newContract;
        }

        public abstract ContractBuilder SetContractHolder(Person contractHolder);
        public abstract ContractBuilder AddContractBeneficiaries(IList<Person> beneficiaries);
        public abstract ContractBuilder AddBenefits();
    }
}
