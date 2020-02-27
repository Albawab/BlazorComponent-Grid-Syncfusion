// <copyright file="Controller.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Controller
{
    using HenE_BlazorComponent.Data;

    /// <summary>
    /// De controller van de formulier date.
    /// Geeft een formulier terug.
    /// </summary>
    public class Controller
    {
        private readonly AangifteDividendBelasting aangifteDividendBelasting = new AangifteDividendBelasting();
        private readonly AangifteSchenkbelasting aangifteSchenkbelasting = new AangifteSchenkbelasting();

        /// <summary>
        /// Geeft de juist formulier terug.
        /// </summary>
        /// <param name="formulier">Het formulier die aan wordt gevraagd.</param>
        /// <returns>Het juist formulier.</returns>
        public Formulier GetData(string formulier)
        {
            switch (formulier)
            {
                case "aangifteDividendBelasting":
                    return this.aangifteDividendBelasting;
                case "aangifteSchenkbelasting":
                    return this.aangifteSchenkbelasting;
                default:
                    return null;
            }
        }
    }
}
