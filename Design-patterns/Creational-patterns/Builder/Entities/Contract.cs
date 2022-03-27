using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Entities
{
    public class Contract
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Person ContractHolder { get; set; }
        public IList<Person> Beneficiaries { get; set; }
        public IList<Benefits> Benefits { get; set; }

        public Contract()
        {
            StartDate = DateTime.Today;
            EndDate = DateTime.Today.AddDays(365);
            ContractHolder = null;
            Benefits = null;
            Beneficiaries = null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Reporte del contrato:\n\n");
            sb.Append("Este contrato está activo desde " + StartDate.ToLongDateString() + " hasta " + EndDate.ToLongDateString() + "\n");
            sb.Append("Titular del contrato: " + ContractHolder.ToString() + "\n");
            if (Beneficiaries != null)
            {
                sb.Append("Beneficiarios del contrato:\n");
                foreach (Person p in Beneficiaries)
                {
                    sb.Append(" - " + p.ToString() + "\n");
                }
            }
            if (Benefits != null)
            {
                sb.Append("\nBeneficios del contrato:\n");
                foreach (Benefits b in Benefits)
                {
                    sb.Append(" - " + b.ToString() + "\n");
                }
            }

            return sb.ToString();
        }
    }
}
