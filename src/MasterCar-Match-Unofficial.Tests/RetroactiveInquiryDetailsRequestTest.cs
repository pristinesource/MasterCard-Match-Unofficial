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
    public class RetroactiveInquiryDetailsRequestTest : BaseTest {

        [SetUp]
        public override void setup() {
            base.setup();

            ApiConfig.SetDebug(true);
            ApiConfig.SetSandbox(true);
            string certPath = MasterCar_Match_Unofficial.Tests.Util.GetCurrenyAssemblyPath() + "\\mcapi_sandbox_key.p12";
            ApiConfig.SetAuthentication(new OAuthAuthentication("L5BsiPgaF-O3qA36znUATgQXwJB6MRoMSdhjd7wt50c97279!50596e52466e3966546d434b7354584c4975693238513d3d", certPath, "alias", "password"));
        }

        [Test]
        public void TestExampleRetroactiveInquiryDetails() {
            var map = new RequestMap();
            //map.Set("RetroInquiryRequest.InquiryReferenceNumber", "19962014090200009");
            map.Set("RetroInquiryRequest.InquiryReferenceNumber", "19962014090200009");

            var response = RetroactiveInquiryDetailsRequest.Create(map);
            Assert.NotNull(response);

            putResponse("example_retroactive_inquiry_details", response);
        }
    }
}
