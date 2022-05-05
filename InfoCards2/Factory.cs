using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    internal class Factory : IInfoCardFactory
    {
        //variables
        private readonly Dictionary<string, string> description = new Dictionary<string, string>()
        {
            {"Credit Card", "Store credit card details"},
            {"Airline Ticket", "Store airline ticket details"},
            {"Image", "Store image"}
        };

        //methods
        public IInfoCard CreateNewInfoCard(string category)
        {
            if (description.ContainsKey(category))
            {
                switch (category)
                {
                    case "Credit Card":
                        {
                            return new CreditCard();
                        }
                    case "Airline Ticket":
                        {
                            return new AirlineTicket();
                        }
                    case "Image":
                        {
                            return new ImageCard();
                        }
                }
            }
            throw new Exception("Unhandled Infocard Type");
        }

        public IInfoCard CreateInfoCard(string initialDetails)
        {
            if (description.ContainsKey(initialDetails.Split('|')[0]))
            {
                switch (initialDetails.Split('|')[0])
                {
                    case "Credit Card":
                        {
                            return new CreditCard(initialDetails.Substring(12));
                        }
                    case "Airline Ticket":
                        {
                            return new AirlineTicket(initialDetails.Substring(15));
                        }
                    case "Image":
                        {
                            return new ImageCard(initialDetails.Substring(6));
                        }
                }
            }
            throw new Exception("Unhandled Infocard Type");
        }

        public string[] CategoriesSupported => description.Keys.ToArray();

        public string GetDescription(string category)
        {
            return description.ContainsKey(category) ? description[category] : throw new Exception("Unhandled Infocard Type");
        }
    }
}
