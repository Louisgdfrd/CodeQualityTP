using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality
{
    internal class Offre
    {
		public Offre()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public Facture enFacture(DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer)
		{

			Facture aRetourner = new Facture();
			if (estValider)
			{
				aRetourner.dateEmission = aDateEmission;
				aRetourner.datePaiment = aDatePaiment;
				aRetourner.estPayer = aEstPayer;
				aRetourner.montant = montant;
				aRetourner.offre = this;
			}
			return aRetourner;

		}
		public int montant { get; set; }
		public string nom { get; set; }
		public DateTime dateValidite { get; set; }
		public List<Offre> offresProposer { get; set; }
		public bool estValider { get; set; }
	}
}
