// <copyright file="CardButtonElement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    using HenE_BlazorComponent.Enumeration;

    public class CardButtonElement : CardElement
    {
        /// <summary>
        /// Gets or sets waar de spin van de butten staat.
        /// </summary>
        public ButtonSpinPosition ButtonSpinPosition { get; set; }

        /// <summary>
        /// Gets or sets de animation effect van een button.
        /// </summary>
        public ButtonAnimationEffect ButtonAnimationEffect { get; set; }
    }
}
