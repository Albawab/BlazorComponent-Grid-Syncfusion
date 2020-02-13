// <copyright file="VoegItemIn.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Processes
{
    using HenE_BlazorComponent.Data;

    /// <summary>
    /// Zorg dat een nieuwe persoon wordt ingevoegd.
    /// </summary>
    public static class VoegItemIn
    {
        /// <summary>
        /// Voeg een nieuwe persoon aan de lijst van de personen in.
        /// </summary>
        /// <param name="id">De id van de een nieuwe persoon.</param>
        /// <param name="naam">De naam van de nieuwe persoon.</param>
        /// <returns>De nieuwe peroon.</returns>
        public static Persoon AddPersoon(int id, string naam)
        {
            return new Persoon()
            {
                Id = id,
                Naam = naam,
            };
        }
    }
}
