using System.Collections.Generic;

namespace SendCV
{
    public class ListObjects
    {

        public List<string> ListOfOccupations()
        {
            List<string> occupation = new List<string>();
            occupation.Add("Junior Backendutvecklare");
            occupation.Add("Junior Frontendutvecklare");
            occupation.Add("Junior Fullstackutvecklare");
            occupation.Add("Junior .NET utvecklare");
            occupation.Add("Junior Webbutvecklare");
            return occupation;
        }
        public List<CompanyInformation> CompanyInfo(string compName, string occupation, string compEmail)
        {
            List<CompanyInformation> companyInformation = new List<CompanyInformation>();
            companyInformation.Add(new CompanyInformation { CompanyEmail = compEmail, CompanyName = compName, Occupation = occupation });
            return companyInformation;
        } 
    }
}