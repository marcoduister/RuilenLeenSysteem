using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    public enum Type
    {
        Borrow,
        Trade
    }
    public enum Status
    {
        Sold,
        InStock,
        Loaned,
        OnderReview,
        GivingBack,
    }
    public enum Roll
    {
        Volunteer,
        IT_Employee,
        Admin
    }
}
