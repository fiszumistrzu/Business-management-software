//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2022
{
    using System;
    using System.Collections.Generic;
    
    public partial class v_Wyplata_suma
    {
        public int ID_pracownik { get; set; }
        public string Nazwisko { get; set; }
        public string Imię { get; set; }
        public int Podstawa_wynagrodzenia { get; set; }
        public Nullable<int> Miesiac_wyplata { get; set; }
        public int Wynagrodzenie_nadgodziny { get; set; }
        public int Ilość_dni_CH { get; set; }
        public int Ilość_dni_NB { get; set; }
        public Nullable<decimal> Wypłata { get; set; }
    }
}
