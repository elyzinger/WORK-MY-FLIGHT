using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject120619
{
    public class LoggedInAdministratorFacade : AnonymousUserFacade, ILoggedInAdministratorFacade, IFacade
    {
        /// <summary>
        /// Creates a new airline company and adds it to the table in the DB amd take out his id
        /// </summary>
        public long CreateNewAirline(LoginToken<Administrator> token, AirLineCompany airline)
        {     
            if (ValidUserToken(token))
            {
               airline.ID = _airlineDAO.ADD(airline);
            }
            return airline.ID;
        }
        // create new customer and add it to the table and take id out
        public long CreateNewCustomer(LoginToken<Administrator> token, Customer customer)
        {
            if (ValidUserToken(token))
            {
              customer.ID = _customerDAO.ADD(customer);
            }
            return customer.ID;
        }
        // create new country and add it to the table and take id out
        public long CreateNewCountry(LoginToken<Administrator> token, Country country)
        {
            if (ValidUserToken(token))
            {
               country.ID = _countryDAO.ADD(country);
            }
            return country.ID;
        }
        // delete an existing airline from the system
        // first delete from ticktes after that from flights and at the end from airline
        // remove from data base
        public void RemoveAirline(LoginToken<Administrator> token, AirLineCompany airline)
        {
            if (ValidUserToken(token))
            {

                _airlineDAO.Remove(airline);
            }
        
        }
        // delete an existing customer
        // first delete from ticktes after delete the customer
        // remove from data base
        public void RemoveCustomer(LoginToken<Administrator> token, Customer customer)
        {
            if (ValidUserToken(token))
            {
                IList<Ticket> tickets = _ticketDAO.GetAll();
                foreach (Ticket t in tickets)
                {
                    if(t.CustomerID == customer.ID)
                    {
                        _ticketDAO.Remove(t);
                    }
                }
                _customerDAO.Remove(customer);
            }
        }
        //// updating the info of an airline company in the system
        // updating the table in the database
        public void UpdateAirlineDetails(LoginToken<Administrator> token, AirLineCompany airline)
        {
            if (ValidUserToken(token))
            {
                _airlineDAO.Update(airline);
            }
        }
        // updating the info of a customer the system
        // updating the table in the database
        public void UpdateCustomerDetails(LoginToken<Administrator> token, Customer customer)
        {
            if (ValidUserToken(token))
            {
                _customerDAO.Update(customer);
            }
        }
        // cheack for real admin every func
        public bool ValidUserToken(LoginToken<Administrator> token)
        {
            if (token != null && token.User != null)
                return true;
            else
                return false;
        }
    }
}
