// <copyright file="AangifteDividendBelasting.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data.Formulier.Belastingdienst
{
    using System.Collections.Generic;
    using HenE_BlazorComponent.Data.Formulier.Enum;

    /// <summary>
    /// De aangift dividen belasting.
    /// </summary>
    public class AangifteDividendBelasting : Formulier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AangifteDividendBelasting"/> class.
        /// </summary>
        public AangifteDividendBelasting()
            : base("Aangifte dividendbelasting")
        {
            List<FormulierElement> formulierElements = new List<FormulierElement>();
            formulierElements.Add(this.CreateGegevensSection());
            formulierElements.Add(this.CreateOndertekeningSection());
            this.Kinderen = formulierElements;
        }

        /// <summary>
        /// Create een niuwe section Element.
        /// </summary>
        /// <returns>Niuwe element.</returns>
        private FormulierElement CreateOndertekeningSection()
        {
            // voeg de elementen to
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 2, Column = 2, Columns = 2, Text = "Naam contactpersoon" },
                new FormulierVraag { Row = 3, Column = 2, Columns = 2, Text = "Functie" },
                new FormulierVraag { Row = 4, Column = 2, Columns = 2, Text = "Plaats" },
                new FormulierVraag { Row = 5, Column = 2, Columns = 2, Text = "Telefoon" },
                new FormulierAntwoord { Row = 2, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text },
                new FormulierAntwoord { Row = 3, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text },
                new FormulierAntwoord { Row = 4, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text },
                new FormulierAntwoord { Row = 5, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text },
            };

            // voeg de elementen to
            return new FormulierSectie()
            {
                Row = 1,
                Rows = 1,
                Column = 1,
                Columns = 12,
                Number = 10,
                Title = "Ondertekening",
                SectionKinderen = formulierVraagen,
            };
        }

        /// <summary>
        ///  Create een niuwe section Element.
        /// </summary>
        /// <returns>Niuwe element.</returns>
        private FormulierElement CreateGegevensSection()
        {
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 2, Column = 2, Columns = 2, Text = "Naam vennotschap" },
                new FormulierVraag { Row = 3, Column = 2, Columns = 2, Text = "Adres" },
                new FormulierVraag { Row = 4, Column = 2, Columns = 2, Text = "Postcode en plaats" },
                new FormulierVraag { Row = 5, Column = 2, Columns = 2, Text = "Uw aangiftenummer" },
                new FormulierAntwoord { Row = 2, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text },
                new FormulierAntwoord { Row = 3, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text },
                new FormulierAntwoord { Row = 4, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text },
                new FormulierAntwoord { Row = 4, Column = 0, Columns = 6, SoortAntwoord = SoortAntwoord.Text },
                new FormulierAntwoord { Row = 5, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text },
            };

            // voeg de elementen to
            return new FormulierSectie()
            {
                Row = 1,
                Rows = 1,
                Column = 1,
                Columns = 12,
                Number = 1,
                Title = "Gegevens vennootschap",
                SectionKinderen = formulierVraagen,
            };
        }
    }
}
