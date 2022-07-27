using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class CustomerQuestionnaires
    {

        public int Id { get; set; }
        public static int StaticID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string CustomerComment { get; set; }
        public string FriendQuest { get; set; }
        public string WorryQuest { get; set; }
        public string SatisfiedQuest { get; set; }
        public string AffraidQuest { get; set; }
        public string AttentionQues { get; set; }
        public string RightWrongQuest { get; set; }
        public string ComfortabilityQuest { get; set; }

        public CustomerQuestionnaires()
        {
            Id = ++StaticID;
        }

    }
}
