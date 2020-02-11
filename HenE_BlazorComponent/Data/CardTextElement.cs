﻿// <copyright file="CardTextElement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;
using HenE_BlazorComponent.Pages;

namespace HenE_BlazorComponent.Data
{
    /// <summary>
    /// De text card.
    /// </summary>
    public class CardTextElement : CardElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardTextElement"/> class.
        /// </summary>
        public CardTextElement() => this.Soort = SoortCardElementen.Text;

        /// <summary>
        /// Gets or sets de type van de text box.
        /// </summary>
        public TextBoxTypes Type { get; set; } = TextBoxTypes.Text;

        /// <summary>
        /// Gets or sets de placeholder van de text box.
        /// </summary>
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or sets de maxlenght van de textbox.
        /// </summary>
        [Range(1, 20, ErrorMessage = "De maximaal lengte mag niet meer dan 20 letter zijn.")]
        public int MaxLength { get; set; }
    }
}
