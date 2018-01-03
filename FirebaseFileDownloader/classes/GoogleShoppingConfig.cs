using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.classes
{
    class GoogleShoppingConfig
    {
        string category;
        string ageGroup;
        string gender;
        string condition;
        string adwordLabel;

        public GoogleShoppingConfig(string _category,string _ageGroup,string _gender,string _condition,string _adwordLabel)
        {
            this.Category = _category;
            this.AgeGroup = _ageGroup;
            this.Gender = _gender;
            this.Condition = _condition;
            this.AdwordLabel = _adwordLabel;
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string AgeGroup
        {
            get
            {
                return ageGroup;
            }

            set
            {
                ageGroup = value;
            }
        }

        public string Condition
        {
            get
            {
                return condition;
            }

            set
            {
                condition = value;
            }
        }

        public string AdwordLabel
        {
            get
            {
                return adwordLabel;
            }

            set
            {
                adwordLabel = value;
            }
        }
    }
}
