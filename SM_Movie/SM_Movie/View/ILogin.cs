using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Movie.View
{
    public interface ILogin
    {
        string userId { get; set; }
        string userPassword { get; set; }
    }
}
