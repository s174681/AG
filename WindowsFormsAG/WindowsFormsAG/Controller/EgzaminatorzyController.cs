using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsAG.Model;
using System.Xml;

namespace WindowsFormsAG.Controller
{
    class EgzaminatorzyController
    {
        private XmlDocument _examinerData;

        private List<Egzaminatorzy> _ListEgzaminatorzy { get; set; }

        public int RecordCount { get; set; }

        private string _fileName { get; set; }

        public EgzaminatorzyController()
        {
            _ListEgzaminatorzy = new List<Egzaminatorzy>();
            RecordCount = 0;        //numer rekordów in dataGridView
        }

        public EgzaminatorzyController(string fileName)
            :this()
        {
            _fileName = fileName;
        }

        public void LoadFile()
        {
            //cztanie z pliku Examiners.xml
            _examinerData = new XmlDocument();
            _examinerData.Load(_fileName);
        }

        /// <summary>
        /// Transformacja danych do listy _ListExaminers
        /// Parsowanie Examiners.xml używając XMLDocument class.
        /// </summary>
        /// <returns></returns>
        public void LoadFileExaminers()
        {

            XmlNode ExaminerNode = _examinerData.SelectSingleNode("EgzaminatorzyList");
            XmlNodeList ExaminerList = ExaminerNode.SelectNodes("Egzaminator");

            foreach (XmlNode examiner in ExaminerList)
            {
                Egzaminatorzy examiners = new Egzaminatorzy();
                examiners.EgzaminatorId = Convert.ToInt32(examiner["egzaminatorId"].InnerText);
                examiners.EgzaminatorImie = examiner["egzaminatorImie"].InnerText;
                examiners.EgzaminatorNazwisko = examiner["egzaminatorNazwisko"].InnerText;
                examiners.EgzaminatorCKE = examiner["egzaminatorNumer"].InnerText;
                examiners.EgzaminatorOsrodek = examiner["egzaminatorKodOsrodka"].InnerText;
                examiners.EgzaminatorMiasto = examiner["egzaminatorMiejscowosc"].InnerText;


                XmlNode QualificationListNode = examiner.SelectSingleNode("UprawnieniaList");

                XmlNodeList QualificationList = QualificationListNode.SelectNodes("Uprawnienia");

                foreach (XmlNode node in QualificationList)
                {
                    Uprawnienia qualification = new Uprawnienia();

                    qualification.KwalifikacjaId = Convert.ToInt32(node["kwalifikacjaId"].InnerText);
                    qualification.KwalifikacjaKod = node["kwalifikacjaKod"].InnerText;
                    qualification.KwalifikacjaNazwa = node["kwalifikacjaNazwa"].InnerText;

                    examiners.KwalifikacjeList.Add(qualification);
                }
                _ListEgzaminatorzy.Add(examiners);
            }

            RecordCount = _ListEgzaminatorzy.Count;

        }


        public List<Egzaminatorzy> GetListEgzaminatorzy()
        {
            return _ListEgzaminatorzy;
        }

        /// <summary>
        /// GetExaminerByQualification metoda zwraca liste Examiners dla parametru qualificationCode.  
        /// </summary>
        /// <param name="qualiCode"></param>
        /// <returns></returns>
        public List<Egzaminatorzy> GetEgzaminatorByKwalifikacji(string qualiCode) // String 
        {
            List<Egzaminatorzy> list = new List<Egzaminatorzy>();
            list = _ListEgzaminatorzy.Where(x => x.KwalifikacjeList.Any(o => o.KwalifikacjaKod == qualiCode)).Select(x => x).Distinct().ToList();
            RecordCount = list.Count;
            return list;
        }

        /// <summary>
        /// GetExaminerById metoda zwraca liste Examiners dla parametru ExaminerId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Egzaminatorzy> GetEgzaminatorById(int id)
        {
            List<Egzaminatorzy> list = new List<Egzaminatorzy>();
            list = _ListEgzaminatorzy.Where(x => x.EgzaminatorId == id).Select(x => x).ToList();
            RecordCount = list.Count;
            return list;
        }
    }
}
