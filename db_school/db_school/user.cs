using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace db_school
{
        public class person
        {
            public string id { get; set; }
            public string fname { get; set; }
            public string sname { get; set; }
            public string otch { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string area { get; set; }
            public string town { get; set; }
            public string street { get; set; }
            public string home_index { get; set; }
            public string phone { get; set; }
            public string education { get; set; }
            public string email { get; set; }
            public string work { get; set; }
            public IList<qualification> qualifications { get; set; }
            public IList<_event> _events { get; set; }
        }

        public class qualification
        {
            public string category { get; set; }
            public DateTime category_date { get; set; }
            public string judge_category { get; set; }
            public DateTime judge_category_date { get; set; }
            public string trainer_category { get; set; }
            public DateTime trainer_category_date { get; set; }
        }

        public class _event
        {
            public string title { get; set; }
            public string place { get; set; }
            public DateTime date { get; set; }
            public string judge_post { get; set; }
        }
}
