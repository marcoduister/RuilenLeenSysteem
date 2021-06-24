using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
        enum Type
        {
            borrow,
            Trade
        }
        enum Status
        {
            waiting,
            OnderReview,
            GivingBack
        }
        enum Roll
        {
            Volunteer,
            IT_Employee,
            Admin
        }
    
}
