using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable 8618

namespace DesignPatters.CreationalDesignPatterns.Builder
{
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }
        public void DisplayReport()
        {
            Console.WriteLine("Report Type :" + ReportType);
            Console.WriteLine("Header :" + ReportHeader);
            Console.WriteLine("Content :" + ReportContent);
            Console.WriteLine("Footer :" + ReportFooter);
        }
    }
    public abstract class ReportBuilder
    {
        protected Report ReportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            ReportObject = new Report();
        }
        public Report GetReport()
        {
            return ReportObject;
        }
    }
    class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            ReportObject.ReportContent = "Excel Content Section";
        }
        public override void SetReportFooter()
        {
            ReportObject.ReportFooter = "Excel Footer";
        }
        public override void SetReportHeader()
        {
            ReportObject.ReportHeader = "Excel Header";
        }
        public override void SetReportType()
        {
            ReportObject.ReportType = "Excel";
        }
    }
    public class PdfReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            ReportObject.ReportContent = "PDF Content Section";
        }
        public override void SetReportFooter()
        {
            ReportObject.ReportFooter = "PDF Footer";
        }
        public override void SetReportHeader()
        {
            ReportObject.ReportHeader = "PDF Header";
        }
        public override void SetReportType()
        {
            ReportObject.ReportType = "PDF";
        }
    }
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }

}
