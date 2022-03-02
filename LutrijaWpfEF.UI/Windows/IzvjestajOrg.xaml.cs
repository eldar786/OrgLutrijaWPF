﻿using LutrijaWpfEF.Model;
using LutrijaWpfEF.UI.Helpers;
using LutrijaWpfEF.UI.Izvjestaji;
using LutrijaWpfEF.ViewModel;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static LutrijaWpfEF.ViewModel.OrgViewModel;

namespace LutrijaWpfEF.UI.Windows
{
    /// <summary>
    /// Interaction logic for IzvjestajOrg.xaml
    /// </summary>
    public partial class IzvjestajOrg : Window
    {
        private bool _isReportViewerLoaded;
        private DataTable reportDt;
        private OrgViewModel _stavkeOrgViewModel = new OrgViewModel();
        private ObservableCollection<OrgViewModel> _stavkeOrg = new ObservableCollection<OrgViewModel>();
        private ApplicationViewModel _avm;
        private string _putanja = @"\\192.168.1.213\Users\Share Import\ORGAutoPDF\";
        private Poruke _p;
        private object myObject;

        // public IzvjestajOrg(OrgViewModel orgViewModel)
        // {
        //     Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
        //    {
        //         new Microsoft.Reporting.WinForms.ReportParameter("KomitentParameter", orgViewModel.OdabraniKomitent.ToString())
        //    };
        //}
        public IzvjestajOrg()
        {
            _p = new Poruke();
            string[] files = Directory.GetFiles(@"\\192.168.1.213\Users\Share Import\ORGTxtPdf");
            try
            {
                foreach (var f in files)
            {
                string[] ucitano = File.ReadAllLines(f);
                string[] razdvojeno = ucitano[1].Split('$');
                string Od = razdvojeno[0];
                string Do = razdvojeno[1];
                string _pocStanje = razdvojeno[2];
                string _KomImePrez = razdvojeno[3] + "_" + razdvojeno[4];
                string _Online = razdvojeno[5];
                string _KladionicaUpl = razdvojeno[6];
                string _Srecke = razdvojeno[7];
                string _Porez = razdvojeno[8];
                string _PologPazara = razdvojeno[9];
                string _automati = razdvojeno[10];
                string _KladionicaIspl = razdvojeno[11];
                string _WebIspl = razdvojeno[12];
                string _UkupanPrometUplata = razdvojeno[13];
                string _UkupanIsplata = razdvojeno[14];
                string _Saldo = razdvojeno[15];
                string _OstalaZaduzenja = razdvojeno[16];
                string _RealTimeKlIgre = razdvojeno[17];

                string imefajla = _KomImePrez + "_" + Od + "_" + Do;

                InitializeComponent();
                NapuniPodatke();
                PripremiPrint();

                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
          {
                new Microsoft.Reporting.WinForms.ReportParameter("PocetnoStanje", _pocStanje),
                new Microsoft.Reporting.WinForms.ReportParameter("KomitentParameter", _KomImePrez),
                //new Microsoft.Reporting.WinForms.ReportParameter("OperativniBroj", _OpBroj)
                new Microsoft.Reporting.WinForms.ReportParameter("Od", Od),
                new Microsoft.Reporting.WinForms.ReportParameter("Do", Do),
                new Microsoft.Reporting.WinForms.ReportParameter("Online", _Online),
                new Microsoft.Reporting.WinForms.ReportParameter("KladionicaUplata", _KladionicaUpl),
                new Microsoft.Reporting.WinForms.ReportParameter("PologPazara", _PologPazara),
                new Microsoft.Reporting.WinForms.ReportParameter("Automati", _automati),
                new Microsoft.Reporting.WinForms.ReportParameter("Srecke", _Srecke),
                new Microsoft.Reporting.WinForms.ReportParameter("Porez", _Porez),
                new Microsoft.Reporting.WinForms.ReportParameter("OstalaZaduzenja", _OstalaZaduzenja),
                new Microsoft.Reporting.WinForms.ReportParameter("RealTimeKlasicneIgre", _RealTimeKlIgre),
                new Microsoft.Reporting.WinForms.ReportParameter("KladionicaIsplata", _KladionicaIspl),
                new Microsoft.Reporting.WinForms.ReportParameter("WebIsplata", _WebIspl),
                new Microsoft.Reporting.WinForms.ReportParameter("UkupanPrometUplata", _UkupanPrometUplata),
                new Microsoft.Reporting.WinForms.ReportParameter("UkupanPrometIsplata", _UkupanIsplata),
                new Microsoft.Reporting.WinForms.ReportParameter("Saldo", _Saldo),
          };
                this._reportViewer.LocalReport.SetParameters(p);
                this._reportViewer.RefreshReport();
               
                SavePDF(_reportViewer, _putanja, imefajla);
                File.Delete(f);
               
            }
            }
            catch (Exception e)
            {
                _p.Greska(e);
            }

            _p.Uspjeh();
            
        }

            public IzvjestajOrg(ApplicationViewModel avm)
        {
            _avm = avm;

          


        }
        

        
        public IzvjestajOrg(string Od, string Do, string _pocStanje, string _KomImePrez, string _Online, string _KladionicaUpl, string _Srecke, string _Porez, string _PologPazara, string _automati, string _RealTimeKlIgre, 
            string _KladionicaIspl, string _WebIspl, string _UkupanPrometUplata, string _UkupanIsplata, string _Saldo, string _OstalaZaduzenja, string _Igre, string _OpBroj)
        {

            InitializeComponent();
            NapuniPodatke();
            PripremiPrint();



            //_reportViewer.Load += ReportViewer_Load;
            //string ime = vm.OdabraniKomitent.IME;
  
                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("PocetnoStanje", _pocStanje),
                new Microsoft.Reporting.WinForms.ReportParameter("KomitentParameter", _KomImePrez),
                new Microsoft.Reporting.WinForms.ReportParameter("Od", Od),
                new Microsoft.Reporting.WinForms.ReportParameter("Do", Do),
                new Microsoft.Reporting.WinForms.ReportParameter("Online", _Online),
                new Microsoft.Reporting.WinForms.ReportParameter("KladionicaUplata", _KladionicaUpl),
                new Microsoft.Reporting.WinForms.ReportParameter("PologPazara", _PologPazara),
                new Microsoft.Reporting.WinForms.ReportParameter("Automati", _automati),
                new Microsoft.Reporting.WinForms.ReportParameter("Srecke", _Srecke),
                new Microsoft.Reporting.WinForms.ReportParameter("Porez", _Porez),
                new Microsoft.Reporting.WinForms.ReportParameter("OstalaZaduzenja", _OstalaZaduzenja),
                new Microsoft.Reporting.WinForms.ReportParameter("OperativniBroj", _OpBroj),
               

                new Microsoft.Reporting.WinForms.ReportParameter("RealTimeKlasicneIgre", _RealTimeKlIgre),
                new Microsoft.Reporting.WinForms.ReportParameter("KladionicaIsplata", _KladionicaIspl),
                new Microsoft.Reporting.WinForms.ReportParameter("WebIsplata", _WebIspl),
                new Microsoft.Reporting.WinForms.ReportParameter("UkupanPrometUplata", _UkupanPrometUplata),
                new Microsoft.Reporting.WinForms.ReportParameter("UkupanPrometIsplata", _UkupanIsplata),
                new Microsoft.Reporting.WinForms.ReportParameter("Saldo", _Saldo),

                new Microsoft.Reporting.WinForms.ReportParameter("KladIgra", _Igre),
                //new Microsoft.Reporting.WinForms.ReportParameter("IznosUplate", _IznosUplate),
                //new Microsoft.Reporting.WinForms.ReportParameter("Saldo", _Saldo),
                //new Microsoft.Reporting.WinForms.ReportParameter("Saldo", _Saldo),
                //new Microsoft.Reporting.WinForms.ReportParameter("Saldo", _Saldo),



            };
                this._reportViewer.LocalReport.SetParameters(p);
                this._reportViewer.RefreshReport();


            
            //this.Loaded += new RoutedEventHandler(IzvjestajOrg_Loaded);

        }

        private void IzvjestajOrg_Loaded(object sender, RoutedEventArgs e)
        {
            //this.ReportViewer.ReportPath = System.IO.Path.Combine(Environment.CurrentDirectory, @"C:\Users\eldar.bajrovic\Desktop\Eldar\LutrijaWpfEF(04.06.2021.)\LutrijaWpfEF.UI\Izvjestaji\PrintReport.rdlc");
            //this.ReportViewer.RefreshReport();
            //_reportViewer.LocalReport.ReportPath = pathHelper.MExecutableRootDirectory + "\\Izvjestaji\\PrintReport.rdlc";
            //_reportViewer.RefreshReport();

        }

        //public IzvjestajOrg()
        //{
        //   // _stavkeOrgViewModel.Od = orgViewModel.Od;
        //}



        private void NapuniPodatke()
        {
            DateTime datumOd = _stavkeOrgViewModel.Od;



            reportDt = new DataTable("DataSetOrgViewModel");
            reportDt.Columns.Add("Od");
            reportDt.Columns.Add("Do");
            reportDt.Columns.Add("OdabraniKomitent");
            List<ReportOrg> lista = new List<ReportOrg>();
            int rbr = 1;

            foreach (OrgViewModel stavka in _stavkeOrg)
            {
                ReportOrg report = new ReportOrg();
                report.Od = datumOd.Date;
                report.Do = stavka.Do.Date;
                report.OdabraniKomitent = stavka.OdabraniKomitent;
                lista.Add(report);
            }

            foreach (ReportOrg report in lista)
            {
                DataRow dr = reportDt.NewRow();
                dr[0] = report.Od;
                dr[1] = report.Do;
                dr[2] = report.OdabraniKomitent;

                reportDt.Rows.Add(dr);
            }
        }

        private void PripremiPrint()
        {
            ReportDataSource ds = new ReportDataSource("DataSetOrgViewModel", reportDt);
            PathHelper pathHelper = new PathHelper();
            _reportViewer.LocalReport.ReportPath = pathHelper.MExecutableRootDirectory + "\\Izvjestaji\\PrintReport.rdlc";
            _reportViewer.LocalReport.DataSources.Add(ds);

            this._reportViewer.LocalReport.ReportEmbeddedResource = "PrintReport.rdlc";

           
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {

            if (!_isReportViewerLoaded)
            {
                try
                {
                    PripremiPrint();

                    _reportViewer.RefreshReport();
                    _isReportViewerLoaded = true;

                    var reportOrg = new ReportOrg();
                    var orgViewModel = new OrgViewModel();

                    //var report = orgViewModel.GetAllOrgViewModel();
                    var report = orgViewModel.Do;

                    this.DataContext = report;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void SavePDF(ReportViewer viewer, string savePath, string komitent)
        {
            string reg = Regex.Replace(komitent, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
            string ime = savePath + reg + ".pdf";
            byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");

            using (FileStream stream = new FileStream(ime, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
            
           // SendMail("dino.kantardzic@lutrijabih.ba", "Test", "Ovo je test", ime);
        }


        public static void SendMail(string recipient, string subject, string body, string attachments)
        {
            SmtpClient smtpClient = new SmtpClient();
            NetworkCredential basicCredential = new NetworkCredential(MailConst.Username, MailConst.Password, MailConst.Domain);
            MailMessage message = new MailMessage();
            MailAddress fromAddress = new MailAddress(MailConst.From);

            // setup up the host, increase the timeout to 5 minutes
            smtpClient.Host = MailConst.Domain;
         
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = basicCredential;
            smtpClient.Timeout = (60 * 5 * 1000);

            message.From = fromAddress;
            message.Subject = subject + " - " + DateTime.Now.Date.ToString().Split(' ')[0];
            message.IsBodyHtml = true;
            message.Body = body.Replace("\r\n", "<br>");
            message.To.Add(recipient);

            if (attachments != null)
            {
            
                    message.Attachments.Add(new Attachment(attachments));
                
            }

            smtpClient.Send(message);
        }


        private void Zatvori(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
