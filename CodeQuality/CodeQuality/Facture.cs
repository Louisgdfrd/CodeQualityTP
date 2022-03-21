using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality
{
    internal class Facture 
    {
		public Facture()
		{
		}
		public Facture(int aMontant, DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer, Offre aOffre)
		{
			montant = aMontant;
			dateEmission = aDateEmission;
			datePaiment = aDatePaiment;
			estPayer = aEstPayer;
			offre = aOffre;
		}
		public Facture(int aMontant, DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer)
		{
			montant = aMontant;
			dateEmission = aDateEmission;
			datePaiment = aDatePaiment;
			estPayer = aEstPayer;
			offre = null;
		}
		public Facture(DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer, Offre aOffre)
		{
			montant = aOffre.montant;
			dateEmission = aDateEmission;
			datePaiment = aDatePaiment;
			estPayer = aEstPayer;
			offre = aOffre;
		}
		public int montant { get; set; }
		public DateTime dateEmission { get; set; }
		public DateTime datePaiment { get; set; }

		public bool estPayer { get; set; }

		public Offre? offre { get; set; }
	}
}
