using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject120619
{
    public interface ILoggedInCustomerFacade
    {
        IList<Ticket> GetAllMyFlights(LoginToken<Customer> token);
        Ticket PurchaseTicket(LoginToken<Customer> token, Flight flight);
        void CancelTicket(LoginToken<Customer> token, Ticket ticket);
    }
}
