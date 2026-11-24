using System;
using System.Collections.Generic;

namespace GestioneAzienda
{
    public class Azienda
    {
        private string nome;
        private List<Dipendente> dipendenti = new List<Dipendente>();

        public Azienda(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public List<Dipendente> GetDipendenti()
        {
            return dipendenti;
        }

      

        public void AddDipendente(Dipendente dipendente)
        {
            dipendenti.Add(dipendente);
        }

        public int CalcolaCostoTotaleGiornaliero()
        {
            int totale = 0;
            for (int i = 0; i < dipendenti.Count; i++)
            {
                if (dipendenti[i] is Operaio operaio)
                {
                    totale = totale + operaio.GetOreGiornaliere() * operaio.GetPagaOraria();
                }
                if (dipendenti[i] is CapoTurno capoTurno)
                {
                    totale = totale + capoTurno.GetOreGiornaliere() * capoTurno.GetPagaOraria();
                }
                if (dipendenti[i] is CapoArea capoArea)
                {
                    totale = totale + capoArea.GetOreGiornaliere() * capoArea.GetPagaOraria();
                }
            }
            return totale;
        }

        public void StampaDettaglioDipendenti()
        {
            for (int i = 0; i < dipendenti.Count; i++)
            {
                if (dipendenti[i] is Operaio operaio)
                {
                    int pagaGiorno = operaio.GetOreGiornaliere() * operaio.GetPagaOraria();
                    Console.WriteLine(operaio.GetNome() + " " + operaio.GetCognome() + " (Operaio) - Ore: " + operaio.GetOreGiornaliere() + " - Prende: " + pagaGiorno + " euro");
                }
                if (dipendenti[i] is CapoTurno capoTurno)
                {
                    int pagaGiorno = capoTurno.GetOreGiornaliere() * capoTurno.GetPagaOraria();
                    Console.WriteLine(capoTurno.GetNome() + " " + capoTurno.GetCognome() + " (CapoTurno) - Ore: " + capoTurno.GetOreGiornaliere() + " - Prende: " + pagaGiorno + " euro");
                }
                if (dipendenti[i] is CapoArea capoArea)
                {
                    int pagaGiorno = capoArea.GetOreGiornaliere() * capoArea.GetPagaOraria();
                    Console.WriteLine(capoArea.GetNome() + " " + capoArea.GetCognome() + " (CapoArea) - Ore: " + capoArea.GetOreGiornaliere() + " - Prende: " + pagaGiorno + " euro");
                }
            }
        }
    }

    public class Dipendente
    {
        private int idDipendente;
        private string nome;
        private string cognome;

        public Dipendente(int idDipendente, string nome, string cognome)
        {
            this.idDipendente = idDipendente;
            this.nome = nome;
            this.cognome = cognome;
        }

        public int GetIdDipendente()
        {
            return idDipendente;
        }

        public void SetIdDipendente(int idDipendente)
        {
            this.idDipendente = idDipendente;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetCognome()
        {
            return cognome;
        }

        public void SetCognome(string cognome)
        {
            this.cognome = cognome;
        }
    }

    public class Operaio : Dipendente
    {
        private int oreGiornaliere;
        private int pagaOraria;

     
        public Operaio(int idDipendente, string nome, string cognome) : base(idDipendente, nome, cognome)
        {
            pagaOraria = 12;
            oreGiornaliere = 8;
        }

        public int GetOreGiornaliere()
        {
            return oreGiornaliere;
        }

        public void SetOreGiornaliere(int oreGiornaliere)
        {
            this.oreGiornaliere = oreGiornaliere;
        }

        public int GetPagaOraria()
        {
            return pagaOraria;
        }

        public void SetPagaOraria(int pagaOraria)
        {
            this.pagaOraria = pagaOraria;
        }

        public void RegistraOre(int ore)
        {
            oreGiornaliere = oreGiornaliere + ore;
        }
    }

    public class CapoTurno : Dipendente
    {
        private int oreGiornaliere;
        private int pagaOraria;

       
        public CapoTurno(int idDipendente, string nome, string cognome) : base(idDipendente, nome, cognome)
        {
            pagaOraria = 16;
            oreGiornaliere = 8;
        }

        public int GetOreGiornaliere()
        {
            return oreGiornaliere;
        }

        public void SetOreGiornaliere(int oreGiornaliere)
        {
            this.oreGiornaliere = oreGiornaliere;
        }

        public int GetPagaOraria()
        {
            return pagaOraria;
        }

        public void SetPagaOraria(int pagaOraria)
        {
            this.pagaOraria = pagaOraria;
        }

        public void RegistraOre(int ore)
        {
            oreGiornaliere = oreGiornaliere + ore;
        }
    }

    public class CapoArea : Dipendente
    {
        private int oreGiornaliere;
        private int pagaOraria;


        public CapoArea(int idDipendente, string nome, string cognome) : base(idDipendente, nome, cognome)
        {
            pagaOraria = 22;
            oreGiornaliere = 6;
        }

        public int GetOreGiornaliere()
        {
            return oreGiornaliere;
        }

        public void SetOreGiornaliere(int oreGiornaliere)
        {
            this.oreGiornaliere = oreGiornaliere;
        }

        public int GetPagaOraria()
        {
            return pagaOraria;
        }

        public void SetPagaOraria(int pagaOraria)
        {
            this.pagaOraria = pagaOraria;
        }

        public void RegistraOre(int ore)
        {
            oreGiornaliere = oreGiornaliere + ore;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Operaio operaio1 = new Operaio(1, "Alberto", "Belardinelli");
            CapoTurno capoTurno1 = new CapoTurno(2, "Francesco", "Adriani");
            CapoArea capoArea1 = new CapoArea(3, "Gianluigi", "buffon");

            Azienda azienda = new Azienda("Belardinelli SPA(Societa Per Armette)");
            azienda.AddDipendente(operaio1);
            azienda.AddDipendente(capoTurno1);
            azienda.AddDipendente(capoArea1);

            Console.WriteLine("Aziendaa: " + azienda.GetNome());
            azienda.StampaDettaglioDipendenti();

            int costoGiornaliero = azienda.CalcolaCostoTotaleGiornaliero();
            Console.WriteLine("Costo totale giornalierro dipendenti: " + costoGiornaliero + " euro");
            

        }
    }
}