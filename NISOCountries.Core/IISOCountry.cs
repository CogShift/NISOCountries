﻿
namespace NISOCountries.Core
{
    public interface IISOCountry
    {
        string Alpha2 { get; set; }
        string Alpha3 { get; set; }
        string Numeric { get; set; }
        string CountryName { get; set; }
    }
}
