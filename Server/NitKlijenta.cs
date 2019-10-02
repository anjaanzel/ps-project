using Domen;
using Server.SistemskeOperacije.Korisnik;
using Server.SistemskeOperacije.Sala;
using Server.SistemskeOperacije.SOGovornik;
using Server.SistemskeOperacije.SOPredavanje;
using Server.SistemskeOperacije.SORaspored;
using Server.SistemskeOperacije.SOSala;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class NitKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitKlijenta(NetworkStream tok)
        {
            formater = new BinaryFormatter();
            this.tok = tok;

            ThreadStart ts = obradiKlijenta;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        void obradiKlijenta()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {

                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;

                    switch (transfer.Operacija)
                    {
                        case Operacije.PronadjiKorisnika:
                            PronadjiKorisnika korisnik = new PronadjiKorisnika();
                            transfer.Rezultat = korisnik.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajPredavaca:
                            KreirajNovogGovornika kng = new KreirajNovogGovornika();
                            transfer.Rezultat = kng.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveZemlje:
                            UcitajZemlje uz = new UcitajZemlje();
                            transfer.Rezultat = uz.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiPredavaca:
                            ZapamtiGovornika zg = new ZapamtiGovornika();
                            transfer.Rezultat = zg.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajSalu:
                            KreirajNovuSalu kns = new KreirajNovuSalu();
                            transfer.Rezultat = kns.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiSalu:
                            ZapamtiSalu zs = new ZapamtiSalu();
                            transfer.Rezultat = zs.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajRaspored:
                            KreirajNoviRaspored knr = new KreirajNoviRaspored();
                            transfer.Rezultat = knr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiRaspored:
                            ZapamtiRaspored zr = new ZapamtiRaspored();
                            transfer.Rezultat = zr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziGovornike:
                            PronadjiGovornike pg = new PronadjiGovornike();
                            transfer.Rezultat = pg.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PronadjiGovornika:
                            PronadjiGovornika pgo = new PronadjiGovornika();
                            transfer.Rezultat = pgo.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiPredavanje:
                            ZapamtiPredavanje zpr = new ZapamtiPredavanje();
                            transfer.Rezultat = zpr.IzvrsiSO(transfer.TransferObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSvePredavace:
                            UcitajGovornike ug = new UcitajGovornike();
                            transfer.Rezultat = ug.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveSale:
                            UcitajSale us = new UcitajSale();
                            transfer.Rezultat = us.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveRasporede:
                            UcitajRasporede ur = new UcitajRasporede();
                            transfer.Rezultat = ur.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziPredavanja:
                            PronadjiPredavanja pp = new PronadjiPredavanja();
                            transfer.Rezultat = pp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PronadjiPredavanje:
                            PronadjiPredavanje prp = new PronadjiPredavanje();
                            transfer.Rezultat = prp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.AzurirajPredavanje:
                            AzurirajPredavanje ap = new AzurirajPredavanje();
                            transfer.Rezultat = ap.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiGovornika:
                            ObrisiGovornika og = new ObrisiGovornika();
                            transfer.Rezultat = og.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiPredavanje:
                            ObrisiPredavanje op = new ObrisiPredavanje();
                            transfer.Rezultat = op.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokovaKlijenata.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }

            catch (Exception)
            {
                try
                {
                    Server.listaTokovaKlijenata.Remove(tok);
                }
                catch (Exception)
                {

                }
            }
        }
        
    
    }
}
