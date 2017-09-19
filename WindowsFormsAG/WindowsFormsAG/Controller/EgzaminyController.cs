using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsAG.Model;
using System.Xml;

namespace WindowsFormsAG.Controller
{
    public class EgzaminyController
    {
        private XmlDocument _examData;

        private List<Egzaminy> _ListEgzaminy { get; set; }

        public int RecordCount { get; set; }

        private string _fileName { get; set; }

        public EgzaminyController()
        {
            _ListEgzaminy = new List<Egzaminy>();
            RecordCount = 0;
        }

        public EgzaminyController(string fileName)
            :this()
        {
            _fileName = fileName;
        }

        public void LoadFile()
        {
            //czytanie z pliku Exams.xml
            _examData = new XmlDocument();
            _examData.Load(_fileName);
        }
        /// <summary>
        /// Transformacja danych do listy _ListExams
        /// Parsowanie Exams.xml przy użyciu XmlDocument()
        /// </summary>
        /// <returns></returns>
        public void LoadFileExams()
        {

            XmlNode ExamsNode = _examData.SelectSingleNode("Egzaminy");
            XmlNodeList ExamsList = ExamsNode.SelectNodes("Egzamin");

            foreach (XmlNode exam in ExamsList)
            {
                Egzaminy exams = new Egzaminy();
                exams.EgzaminId = Convert.ToInt32(exam["egzaminId"].InnerText);
                exams.OsrodekKod = exam["osrodekKod"].InnerText;
                exams.OsrodekNazwa = exam["osrodekNazwa"].InnerText;
                exams.OsrodekMiejscowosc = exam["osrodekMiejscowosc"].InnerText;
                exams.KwalifikacjaKod = exam["kwalifikacjeKod"].InnerText;
                exams.KwalifikacjaNazwa = exam["kwalifikacjeNazwa"].InnerText;
                exams.CzasTrwania = Convert.ToInt32(exam.SelectSingleNode("czasTrwania").InnerText);
                exams.LiczbaEgzaminatorow = Convert.ToInt32(exam.SelectSingleNode("liczbaEgzamintorow").InnerText);
                exams.IsPracujeWeekend = Convert.ToInt32(exam.SelectSingleNode("pracujeWeekend").InnerText) == 1 ? true : false;
                _ListEgzaminy.Add(exams);
            }
            RecordCount = _ListEgzaminy.Count;

        }

        public List<Egzaminy> GetListExams()
        {
            return _ListEgzaminy.OrderBy(x => x.OsrodekKod).Distinct().ToList();
        }

        /// <summary>
        /// GetExamByQualification metoda zwraca liste Exams dla parametru qualificationCode. 
        /// </summary>
        /// <param name="qualiCode"></param>
        /// <returns></returns>
        public List<Egzaminy> GetEgzaminByKwalifikacji(string qualiCode) // String 
        {
            List<Egzaminy> list = new List<Egzaminy>();
            list = _ListEgzaminy.Where(x => x.KwalifikacjaKod == qualiCode).Select(x => x).Distinct().ToList();
            RecordCount = list.Count;
            return list;
        }

        /// <summary>
        /// GetExamById metoda zwraca liste Exams dla parametru CenterId. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Egzaminy> GetEgzaminById(int id)
        {
            List<Egzaminy> list = new List<Egzaminy>();
            list = _ListEgzaminy.Where(x => x.EgzaminId == id).Select(x => x).Distinct().ToList();
            RecordCount = list.Count;
            return list;
        }
    }
}
