﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LutrijaWpfEF.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LutrijaEntities1 : DbContext
    {
        public LutrijaEntities1()
            : base("name=LutrijaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AUTOMATI> AUTOMATI { get; set; }
        public virtual DbSet<AUTOMATI_KOMITENTI> AUTOMATI_KOMITENTI { get; set; }
        public virtual DbSet<AUTOMATI_RADNJE> AUTOMATI_RADNJE { get; set; }
        public virtual DbSet<AUTOMATI_SABINA> AUTOMATI_SABINA { get; set; }
        public virtual DbSet<BAZNE_IGRE> BAZNE_IGRE { get; set; }
        public virtual DbSet<ENTITETI> ENTITETI { get; set; }
        public virtual DbSet<EOP_ANA> EOP_ANA { get; set; }
        public virtual DbSet<EOP_SIN> EOP_SIN { get; set; }
        public virtual DbSet<EopAnas> EopAnas { get; set; }
        public virtual DbSet<ESRECKE_IGRE> ESRECKE_IGRE { get; set; }
        public virtual DbSet<IGRE> IGRE { get; set; }
        public virtual DbSet<IMP_EOP_ANA> IMP_EOP_ANA { get; set; }
        public virtual DbSet<IMP_ISPLATA> IMP_ISPLATA { get; set; }
        public virtual DbSet<ISPLATA> ISPLATA { get; set; }
        public virtual DbSet<ISPLATA_SINTETIKA> ISPLATA_SINTETIKA { get; set; }
        public virtual DbSet<KANTONI> KANTONI { get; set; }
        public virtual DbSet<KLADIONICA> KLADIONICA { get; set; }
        public virtual DbSet<KLADIONICA_IGRE> KLADIONICA_IGRE { get; set; }
        public virtual DbSet<OPCINE> OPCINE { get; set; }
        public virtual DbSet<POC_STANJA> POC_STANJA { get; set; }
        public virtual DbSet<POLOG_PAZAR> POLOG_PAZAR { get; set; }
        public virtual DbSet<PRIJAVA_ORG> PRIJAVA_ORG { get; set; }
        public virtual DbSet<PROVJERA_KLADIONICA> PROVJERA_KLADIONICA { get; set; }
        public virtual DbSet<REGIONI> REGIONI { get; set; }
        public virtual DbSet<RUCNE_OPERACIJE> RUCNE_OPERACIJE { get; set; }
        public virtual DbSet<SRECKE> SRECKE { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UPLATA> UPLATA { get; set; }
        public virtual DbSet<ZADUZENJE_GOTOVINE> ZADUZENJE_GOTOVINE { get; set; }
        public virtual DbSet<IMP_AUTOMATI> IMP_AUTOMATI { get; set; }
        public virtual DbSet<IMP_AUTOMATI_SABINA> IMP_AUTOMATI_SABINA { get; set; }
        public virtual DbSet<IMPORT_AUTOMATI_SABINA> IMPORT_AUTOMATI_SABINA { get; set; }
        public virtual DbSet<GR_ORGANIZACIJE_VIEW> GR_ORGANIZACIJE_VIEW { get; set; }
        public virtual DbSet<komitenti_ime_matbr_zracun> komitenti_ime_matbr_zracun { get; set; }
        public virtual DbSet<v_GR_Komitenti> v_GR_Komitenti { get; set; }
    
        public virtual int analitika_copy(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("analitika_copy", pathParameter);
        }
    
        public virtual int automati_copy(Nullable<System.DateTime> datumImporta)
        {
            var datumImportaParameter = datumImporta.HasValue ?
                new ObjectParameter("datumImporta", datumImporta) :
                new ObjectParameter("datumImporta", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("automati_copy", datumImportaParameter);
        }
    
        public virtual int automati_import(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("automati_import", pathParameter);
        }
    
        public virtual int automati_import2(string jib, Nullable<decimal> uplata, Nullable<decimal> isplata, Nullable<System.DateTime> datum, string opbroj)
        {
            var jibParameter = jib != null ?
                new ObjectParameter("jib", jib) :
                new ObjectParameter("jib", typeof(string));
    
            var uplataParameter = uplata.HasValue ?
                new ObjectParameter("uplata", uplata) :
                new ObjectParameter("uplata", typeof(decimal));
    
            var isplataParameter = isplata.HasValue ?
                new ObjectParameter("isplata", isplata) :
                new ObjectParameter("isplata", typeof(decimal));
    
            var datumParameter = datum.HasValue ?
                new ObjectParameter("datum", datum) :
                new ObjectParameter("datum", typeof(System.DateTime));
    
            var opbrojParameter = opbroj != null ?
                new ObjectParameter("opbroj", opbroj) :
                new ObjectParameter("opbroj", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("automati_import2", jibParameter, uplataParameter, isplataParameter, datumParameter, opbrojParameter);
        }
    
        public virtual int Brisanje_Duplikata()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Brisanje_Duplikata");
        }
    
        public virtual int dynamic_import(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dynamic_import", pathParameter);
        }
    
        public virtual int isplata_copy(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("isplata_copy", pathParameter);
        }
    
        public virtual int isplata_import(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("isplata_import", pathParameter);
        }
    
        public virtual int izmijeni_poc_stanja(Nullable<int> opBroj, Nullable<int> god, Nullable<int> mjes)
        {
            var opBrojParameter = opBroj.HasValue ?
                new ObjectParameter("opBroj", opBroj) :
                new ObjectParameter("opBroj", typeof(int));
    
            var godParameter = god.HasValue ?
                new ObjectParameter("god", god) :
                new ObjectParameter("god", typeof(int));
    
            var mjesParameter = mjes.HasValue ?
                new ObjectParameter("mjes", mjes) :
                new ObjectParameter("mjes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("izmijeni_poc_stanja", opBrojParameter, godParameter, mjesParameter);
        }
    
        public virtual int kladionica_copy(Nullable<int> igraID, Nullable<System.DateTime> datumImporta)
        {
            var igraIDParameter = igraID.HasValue ?
                new ObjectParameter("igraID", igraID) :
                new ObjectParameter("igraID", typeof(int));
    
            var datumImportaParameter = datumImporta.HasValue ?
                new ObjectParameter("datumImporta", datumImporta) :
                new ObjectParameter("datumImporta", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("kladionica_copy", igraIDParameter, datumImportaParameter);
        }
    
        public virtual int kladionica_import(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("kladionica_import", pathParameter);
        }
    
        public virtual int kladionica_import2(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("kladionica_import2", pathParameter);
        }
    
        public virtual int opcine_import(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("opcine_import", pathParameter);
        }
    
        public virtual int pazar_copy(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pazar_copy", pathParameter);
        }
    
        public virtual int pazar_import(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pazar_import", pathParameter);
        }
    
        public virtual int ponisti_isplatu()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ponisti_isplatu");
        }
    
        public virtual int ponisti_kladionicu()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ponisti_kladionicu");
        }
    
        public virtual int ponisti_pazar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ponisti_pazar");
        }
    
        public virtual int ponisti_sin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ponisti_sin");
        }
    
        public virtual ObjectResult<Nullable<int>> provjera_broj_list(string broj)
        {
            var brojParameter = broj != null ?
                new ObjectParameter("broj", broj) :
                new ObjectParameter("broj", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("provjera_broj_list", brojParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> provjera_datum_ana(Nullable<System.DateTime> datum)
        {
            var datumParameter = datum.HasValue ?
                new ObjectParameter("datum", datum) :
                new ObjectParameter("datum", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("provjera_datum_ana", datumParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> provjera_datum_automati(Nullable<System.DateTime> datum)
        {
            var datumParameter = datum.HasValue ?
                new ObjectParameter("datum", datum) :
                new ObjectParameter("datum", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("provjera_datum_automati", datumParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> provjera_datum_isplata(Nullable<System.DateTime> datum)
        {
            var datumParameter = datum.HasValue ?
                new ObjectParameter("datum", datum) :
                new ObjectParameter("datum", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("provjera_datum_isplata", datumParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> provjera_datum_klad(Nullable<int> igra, Nullable<System.DateTime> datumImporta)
        {
            var igraParameter = igra.HasValue ?
                new ObjectParameter("igra", igra) :
                new ObjectParameter("igra", typeof(int));
    
            var datumImportaParameter = datumImporta.HasValue ?
                new ObjectParameter("datumImporta", datumImporta) :
                new ObjectParameter("datumImporta", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("provjera_datum_klad", igraParameter, datumImportaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> provjera_datum_sin(Nullable<System.DateTime> datum)
        {
            var datumParameter = datum.HasValue ?
                new ObjectParameter("datum", datum) :
                new ObjectParameter("datum", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("provjera_datum_sin", datumParameter);
        }
    
        public virtual int sintetika_copy(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sintetika_copy", pathParameter);
        }
    
        public virtual int sintetika_import(string path)
        {
            var pathParameter = path != null ?
                new ObjectParameter("path", path) :
                new ObjectParameter("path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sintetika_import", pathParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_provjera_prodavaca(string prodavac)
        {
            var prodavacParameter = prodavac != null ?
                new ObjectParameter("prodavac", prodavac) :
                new ObjectParameter("prodavac", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_provjera_prodavaca", prodavacParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int ubaci_poc_stanja()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ubaci_poc_stanja");
        }
    }
}