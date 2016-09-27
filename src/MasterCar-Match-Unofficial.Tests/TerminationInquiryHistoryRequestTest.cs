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
    public class TerminationInquiryHistoryRequestTest : BaseTest {

        [SetUp]
        public override void setup() {
            base.setup();

            ApiConfig.SetDebug(true);
            ApiConfig.SetSandbox(true);
            string certPath = MasterCar_Match_Unofficial.Tests.Util.GetCurrenyAssemblyPath() + "\\mcapi_sandbox_key.p12";
            ApiConfig.SetAuthentication(new OAuthAuthentication("L5BsiPgaF-O3qA36znUATgQXwJB6MRoMSdhjd7wt50c97279!50596e52466e3966546d434b7354584c4975693238513d3d", certPath, "alias", "password"));
        }

        [Test]
        public void TestExampleTerminationHistoryInquiry() {

            var map = new RequestMap();
            map.Set("IRN", "19962016070500348");
            map.Set("AcquirerId", "1996");
            map.Set("PageOffset", "0");
            map.Set("PageLength", "10");
            map.Set("id", "");
            
            var response = TerminationInquiryHistoryRequest.Read(map);
            Assert.NotNull(response);

            int c = 0;
            foreach(var r in response) {
                putResponse("example_termination_history_inquiry[" + c.ToString() + "]", r);
                c++;
            }
        }
    }
}
