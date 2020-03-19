// <copyright file="Extensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using Microsoft.JSInterop;

    /// <summary>
    /// Klas waar de Extensions functies staan.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// zorg dat de scroller gaat naar een nieuwe deel van de pagina.
        /// </summary>
        /// <param name="navigationManager">De navigationManager.</param>
        /// <param name="jSRuntime">De runtime van javascript.</param>
        /// <returns>Een nieuwe runtime.</returns>
        public static ValueTask NavigateToFragmentAsync(this NavigationManager navigationManager, IJSRuntime jSRuntime)
        {
            var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);

            if (uri.Fragment.Length == 0)
            {
                return default;
            }

            return jSRuntime.InvokeVoidAsync("blazorHelpers.scrollToFragment", uri.Fragment.Substring(1));
        }
    }
}
