using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterCard.Api.Match;
using MasterCard.Core;
using MasterCard.Core.Model;
using MasterCard.Core.Security.OAuth;
using NUnit.Framework;

namespace Test {

    [TestFixture()]
    public class TerminationInquiryRequestTest : BaseTest {

        [SetUp]
        public override void setup() {
            base.setup();

            ApiConfig.SetDebug(true);
            ApiConfig.SetSandbox(true);
            string certPath = MasterCar_Match_Unofficial.Tests.Util.GetCurrenyAssemblyPath() + "\\mcapi_sandbox_key.p12";
            ApiConfig.SetAuthentication(new OAuthAuthentication("L5BsiPgaF-O3qA36znUATgQXwJB6MRoMSdhjd7wt50c97279!50596e52466e3966546d434b7354584c4975693238513d3d", certPath, "alias", "password"));
        }

        [Test]
        public void TestExampleTerminationInquiry() {
            var map = new RequestMap();
            map.Set("PageOffset", "0");
            map.Set("PageLength", "10");
            map.Set("TerminationInquiryRequest.AcquirerId", "1996");
            map.Set("TerminationInquiryRequest.Merchant.Name", "XYZTEST  XYZTECHMERCHANT");
            map.Set("TerminationInquiryRequest.Merchant.DoingBusinessAsName", "XYZTEST  XYZTECHMERCHANT");
            map.Set("TerminationInquiryRequest.Merchant.AltPhoneNumber", "3098876333");
            map.Set("TerminationInquiryRequest.Merchant.Address.Line1", "88 Nounce World");
            map.Set("TerminationInquiryRequest.Merchant.Address.Line2", "APT 9009");
            map.Set("TerminationInquiryRequest.Merchant.Address.City", "MICKENVINCE");
            map.Set("TerminationInquiryRequest.Merchant.Address.CountrySubdivision", "MO");
            map.Set("TerminationInquiryRequest.Merchant.Address.PostalCode", "66559");
            map.Set("TerminationInquiryRequest.Merchant.Address.Country", "USA");
            map.Set("TerminationInquiryRequest.Merchant.ServiceProvLegal", "JJC WORKSHIRE");
            map.Set("TerminationInquiryRequest.Merchant.Principal.FirstName", "PRINCE");
            map.Set("TerminationInquiryRequest.Merchant.Principal.LastName", "HENREY");
            map.Set("TerminationInquiryRequest.Merchant.Principal.PhoneNumber", "9983339923");
            map.Set("TerminationInquiryRequest.Merchant.Principal.AltPhoneNumber", "6365689336");
            map.Set("TerminationInquiryRequest.Merchant.Principal.Address.CountrySubdivision", "IL");
            map.Set("TerminationInquiryRequest.Merchant.Principal.Address.PostalCode", "66579");
            map.Set("TerminationInquiryRequest.Merchant.Principal.Address.Country", "USA");
            map.Set("TerminationInquiryRequest.Merchant.SearchCriteria.SearchAll", "Y");
            map.Set("TerminationInquiryRequest.Merchant.SearchCriteria.MinPossibleMatchCount", "1");
            

            

            var response = TerminationInquiryRequest.Create(map);
            AssertAreEqualAsString("0", response["TerminationInquiry.PageOffset"]);
            AssertAreEqualAsString("14", response["TerminationInquiry.PossibleMerchantMatches[0].TotalLength"]);
            AssertAreEqualAsString("XYZTEST  XYZTECHMERCHANT", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Name"]);
            AssertAreEqualAsString("XYZTEST  XYZTECHMERCHANT", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.DoingBusinessAsName"]);
            AssertAreEqualAsString("1996", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AddedByAcquirerID"]);
            AssertAreEqualAsString("10/13/2015", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AddedOnDate"]);
            AssertAreEqualAsString("5675543210", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.PhoneNumber"]);
            AssertAreEqualAsString("5672655441", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AltPhoneNumber"]);
            AssertAreEqualAsString("6700 BEN NEVIS", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.Line1"]);
            AssertAreEqualAsString("GLASGOW", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.City"]);
            AssertAreEqualAsString("MA", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.CountrySubdivision"]);
            AssertAreEqualAsString("93137", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.PostalCode"]);
            AssertAreEqualAsString("USA", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.Country"]);
            AssertAreEqualAsString("*****", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.CountrySubdivisionTaxId"]);
            AssertAreEqualAsString("*****", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.NationalTaxId"]);
            AssertAreEqualAsString("TESTXYZ SVC PRVDER", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.ServiceProvLegal"]);
            AssertAreEqualAsString("JNL ASSOC", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.ServiceProvDBA"]);
            AssertAreEqualAsString("PAUL", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].FirstName"]);
            AssertAreEqualAsString("HEMINGHOFF", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].LastName"]);
            AssertAreEqualAsString("*****", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].NationalId"]);
            AssertAreEqualAsString("3906541234", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].PhoneNumber"]);
            AssertAreEqualAsString("4567390234", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].AltPhoneNumber"]);
            AssertAreEqualAsString("2200 SHEPLEY DRIVE", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Line1"]);
            AssertAreEqualAsString("SUITE 789", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Line2"]);
            AssertAreEqualAsString("BROWNSVILLE", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.City"]);
            AssertAreEqualAsString("MO", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.CountrySubdivision"]);
            AssertAreEqualAsString("89022", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.PostalCode"]);
            AssertAreEqualAsString("USA", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Country"]);
            AssertAreEqualAsString("*****", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.Number"]);
            AssertAreEqualAsString("MS", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.CountrySubdivision"]);
            AssertAreEqualAsString("USA", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.Country"]);
            AssertAreEqualAsString("WWW.TESTJJ.COM", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.UrlGroup[0].NoMatchUrls.Url[0]"]);
            AssertAreEqualAsString("WWW.JNLTESTJJ.COM", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.UrlGroup[0].NoMatchUrls.Url[1]"]);
            AssertAreEqualAsString("04", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.TerminationReasonCode"]);
            AssertAreEqualAsString("M01", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.Name"]);
            AssertAreEqualAsString("M02", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.DoingBusinessAsName"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.Address"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PhoneNumber"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.AltPhoneNumber"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.CountrySubdivisionTaxId"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.NationalTaxId"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.ServiceProvLegal"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.ServiceProvDBA"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].Name"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].Address"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].PhoneNumber"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].AltPhoneNumber"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].NationalId"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].DriversLicense"]);
            AssertAreEqualAsString("XYZTEST  XYZTECHMERCHANT", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Name"]);
            AssertAreEqualAsString("XYZTEST  XYZTECHMERCHANT", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.DoingBusinessAsName"]);
            AssertAreEqualAsString("1996", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AddedByAcquirerID"]);
            AssertAreEqualAsString("01/20/2016", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AddedOnDate"]);
            AssertAreEqualAsString("5675543210", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.PhoneNumber"]);
            AssertAreEqualAsString("5672655441", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AltPhoneNumber"]);
            AssertAreEqualAsString("6700 BEN NEVIS", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.Line1"]);
            AssertAreEqualAsString("GLASGOW", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.City"]);
            AssertAreEqualAsString("MA", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.CountrySubdivision"]);
            AssertAreEqualAsString("93137", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.PostalCode"]);
            AssertAreEqualAsString("USA", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.Country"]);
            AssertAreEqualAsString("*****", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.CountrySubdivisionTaxId"]);
            AssertAreEqualAsString("*****", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.NationalTaxId"]);
            AssertAreEqualAsString("TESTXYZ SVC PRVDER", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.ServiceProvLegal"]);
            AssertAreEqualAsString("JNL ASSOC", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.ServiceProvDBA"]);
            AssertAreEqualAsString("PAUL", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].FirstName"]);
            AssertAreEqualAsString("HEMINGHOFF", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].LastName"]);
            AssertAreEqualAsString("*****", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].NationalId"]);
            AssertAreEqualAsString("3906541234", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].PhoneNumber"]);
            AssertAreEqualAsString("4567390234", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].AltPhoneNumber"]);
            AssertAreEqualAsString("2200 SHEPLEY DRIVE", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Line1"]);
            AssertAreEqualAsString("SUITE 789", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Line2"]);
            AssertAreEqualAsString("BROWNSVILLE", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.City"]);
            AssertAreEqualAsString("MO", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.CountrySubdivision"]);
            AssertAreEqualAsString("89022", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.PostalCode"]);
            AssertAreEqualAsString("USA", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Country"]);
            AssertAreEqualAsString("*****", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.Number"]);
            AssertAreEqualAsString("MS", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.CountrySubdivision"]);
            AssertAreEqualAsString("USA", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.Country"]);
            AssertAreEqualAsString("WWW.TESTJJ.COM", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.UrlGroup[0].NoMatchUrls.Url[0]"]);
            AssertAreEqualAsString("WWW.JNLTESTJJ.COM", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.UrlGroup[0].NoMatchUrls.Url[1]"]);
            AssertAreEqualAsString("04", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.TerminationReasonCode"]);
            AssertAreEqualAsString("M01", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.Name"]);
            AssertAreEqualAsString("M02", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.DoingBusinessAsName"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.Address"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PhoneNumber"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.AltPhoneNumber"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.CountrySubdivisionTaxId"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.NationalTaxId"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.ServiceProvLegal"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.ServiceProvDBA"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].Name"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].Address"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].PhoneNumber"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].AltPhoneNumber"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].NationalId"]);
            AssertAreEqualAsString("M00", response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].DriversLicense"]);
            

            putResponse("example_termination_inquiry", response);
        }
    }
}
