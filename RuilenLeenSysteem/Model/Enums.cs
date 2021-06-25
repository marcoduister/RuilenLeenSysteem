using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    public enum Type
    {
        borrow,
        Trade
    }
    public enum Status
    {
        waiting,
        OnderReview,
        GivingBack
    }
    public enum Roll
    {
        Volunteer,
        IT_Employee,
        Admin
    }
    
}
