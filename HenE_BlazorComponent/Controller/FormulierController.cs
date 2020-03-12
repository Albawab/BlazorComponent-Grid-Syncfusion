// <copyright file="FormulierController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Controllers
{
    using HenE_BlazorComponent.Data;

    /// <summary>
    /// De controller van de formulier date.
    /// Geeft een formulier terug.
    /// </summary>
    public class FormulierController
    {
        private readonly AangifteDividendBelasting aangifteDividendBelasting = new AangifteDividendBelasting();
        private readonly AangifteSchenkbelasting aangifteSchenkbelasting = new AangifteSchenkbelasting();

        /// <summary>
        /// Geeft de juist formulier terug.
        /// </summary>
        /// <param name="idFormulier">Het formulier die aan wordt gevraagd.</param>
        /// <returns>Het juist formulier.</returns>
        public Formulier GetData(int idFormulier)
        {
            return idFormulier switch
            {
                1 => this.aangifteDividendBelasting,
                2 => this.aangifteSchenkbelasting,
                _ => null,
            };
        }
    }
}
