using Builder.Entities;
using System;
using System.Collections.Generic;

namespace Builder.Contracts
{
    public class ZafiroContract : ContractBuilder
    {
        public override ContractBuilder AddBenefits()
        {
            _contract.Benefits = new List<Benefits>()
            {
                new Benefits(){ Id = 5, Name = "Beneficio 5", Category = "Categoria ZAFIRO"}
            };

            return this;
        }

        public override ContractBuilder AddContractBeneficiaries(IList<Person> beneficiaries)
        {
            if (beneficiaries != null && beneficiaries.Count != 1)
                throw new Exception("Los planes ZAFIRO están pensados para únicamente 1 beneficiario");

            _contract.Beneficiaries = beneficiaries;

            return this;
        }

        public override ContractBuilder SetContractHolder(Person contractHolder)
        {
            _contract.ContractHolder = contractHolder;

            return this;
        }
    }
}
