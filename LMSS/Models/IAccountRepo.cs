using System.Collections.Generic;
namespace LMSS.Models
{
    public interface IAccountRepo
    {
        Account getUserByName(string username);
       
    }
}
