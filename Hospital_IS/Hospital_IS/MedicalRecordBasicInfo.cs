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
        public string RecType { get; }

        public MedicalRecordBasicInfo(int id, string summary, string fullText, string rec_type)
        {
            Id = id;
            Summary = summary;
            FullText = fullText;
            RecType = rec_type;

        }

        public override string ToString()
        {
            return Summary;
        }
    }
}
