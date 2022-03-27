using Builder.Contracts;
using Builder.Entities;
using System.Collections.Generic;


namespace Builder
{
    public class ContractDirector
    {
        private readonly ContractBuilder _contractBuilder;


        public ContractDirector(ContractBuilder contractBuilder)
        {
            _contractBuilder = contractBuilder;
        }

        public Contract GenerateContract(Person contractHolder, IList<Person> beneficiaries)
        {
            _contractBuilder.SetContractHolder(contractHolder);
            _contractBuilder.AddContractBeneficiaries(beneficiaries);
            _contractBuilder.AddBenefits();

            return _contractBuilder.GetContract();
        }

        public Contract GenerateLightContract(Person contractHolder)
        {
            _contractBuilder.SetContractHolder(contractHolder);

            return _contractBuilder.GetContract();
        }
    }
}
