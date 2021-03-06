using Builder.Entities;
using System;
using System.Collections.Generic;

namespace Builder.Contracts
{
    public class GoldContract : ContractBuilder
    {
        public override ContractBuilder AddBenefits()
        {
            _contract.Benefits = new List<Benefits>()
            {
                new Benefits(){ Id = 1, Name = "Beneficio 1", Category = "Categoria GOLD"},
                new Benefits(){ Id = 2, Name = "Beneficio 2", Category = "Categoria GOLD"},
                new Benefits(){ Id = 3, Name = "Beneficio 3", Category = "Categoria PLATINO"},
                new Benefits(){ Id = 4, Name = "Beneficio 4", Category = "Categoria PLATINO"},
                new Benefits(){ Id = 5, Name = "Beneficio 5", Category = "Categoria ZAFIRO"}
            };

            return this;
        }

        public override ContractBuilder AddContractBeneficiaries(IList<Person> beneficiaries)
        {
            if (beneficiaries != null && beneficiaries.Count < 4)
                throw new Exception("Los planes GOLD están pensados para grupos familiares de más de 4 integrantes");

            _contract.Beneficiaries = beneficiaries;

            return this;
        }

        public override ContractBuilder SetContractHolder(Person contractHolder)
        {
            if (!contractHolder.IsOfLegalAge())
                throw new Exception("Titular de la cuenta no puede ser menor de edad");

            _contract.ContractHolder = contractHolder;

            return this;
        }
    }
}
