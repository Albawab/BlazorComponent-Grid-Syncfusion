// <copyright file="Persoon.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace HenE_BlazorComponent.Data
{
    /// <summary>
    /// De klas waar de gegevens van een persoon staat.
    /// </summary>
    public class Persoon
    {
        /// <summary>
        /// Gets or sets de id van een persoon.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets de naam van een persoon.
        /// </summary>
        [Required]
        public string Naam { get; set; }
    }
}
