using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality
{
    internal class Client : Prospect
    {
		public Client(string aRaisonSocial, List<Contact> aContacts, DateTime aDateDeContact, List<Facture> aFactures) : base(aRaisonSocial, aContacts, aDateDeContact)
		{
			factures = aFactures;
			//
			// TODO: Add constructor logic here
			//
		}
		public bool estRecurant()
		{
			bool estRecurant = false;
			if (factures.Count == 1)
			{
				estRecurant = true;
			}
			return estRecurant;

		}
		public bool aucuneDettes()
		{
			bool estUnBonPayeur = true;
			foreach (Facture facture in factures)
			{
				if (!facture.estPayer)
				{
					estUnBonPayeur = false;
				}
			}
			return estUnBonPayeur;
		}
		public List<Facture> factures { get; set; }
	}
}
