// <copyright file="SectionBelastingFormulier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data.Formulier
{
    using HenE_BlazorComponent.Data.Formulier.Enum;
    /// <summary>
    /// De eigenschappen van de antwoord.
    /// </summary>
    public class FormulierAntwoord : FormulierElement
    {
        /// <summary>
        /// Gets or sets de soort van een antwoord.
        /// </summary>
        public SoortAntwoord SoortAntwoord { get; set; }
    }
}