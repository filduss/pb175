using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MedicalRecordBasicInfo
    {
        public int Id { get; }
        public string Summary { get; }
        public string FullText { get; }

        public MedicalRecordBasicInfo(int id, string summary, string fullText)
        {
            Id = id;
            Summary = summary;
            FullText = fullText;
        }

        public override string ToString()
        {
            return Summary;
        }
    }
}
