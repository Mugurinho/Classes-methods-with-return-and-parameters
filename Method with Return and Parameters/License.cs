using System;
using System.Collections.Generic;
using System.Text;

namespace Method_with_Return_and_Parameters
{
    class License
    {
        public string LicenseNumber { get; set; }

        //sample of hardcoded licence numbers
        private readonly string licenseNumber1 = "DJ38923NDHGS2";
        private readonly string licenseNumber2 = "DNEE3322EDD23";

        //the status of the license: valid or not valid
        string licenseStatus;

        public string CheckLicense()
        {
            if (LicenseNumber == licenseNumber1 || LicenseNumber == licenseNumber2)
            {
                licenseStatus = "VALID";
                return "Your license is: " + licenseStatus;
            }

            else
            {
                licenseStatus = "NOT VALID";
                return "Your license is: " + licenseStatus;
            }
        }
    }
}
