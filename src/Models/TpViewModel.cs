using System;

namespace src.Models
{
    public class TpViewModel
    {
        #region  Properties

        public string Group { get; set; }
        public DateTime Date { get; set; }
        
        public int MembersQuantity { get; set; }

        #endregion

        #region 

        public TpViewModel(string group,
                           DateTime date,
                           int membersQuantity)
        {
            this.Group = group;
            this.Date = date;
            this.MembersQuantity = membersQuantity;
        }

        #endregion

    }
}