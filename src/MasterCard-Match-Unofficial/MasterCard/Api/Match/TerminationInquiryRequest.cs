using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterCard.Core.Model;
using MasterCard_Core_Unofficial.MasterCard.Core;

namespace MasterCard.Api.Match {
    public class TerminationInquiryRequest : BaseObject {

        public TerminationInquiryRequest(RequestMap bm) : base(bm) { }

        public TerminationInquiryRequest(IDictionary<string, object> map) : base(map) { }

        public TerminationInquiryRequest() { }

        /// <summary>
        /// Creates object of type TerminationInquiryRequest
        /// </summary>
        /// <param name="map">containing the required parameters to create a new object</param>
        /// <returns>TerminationInquiryRequest of the response of created instance.</returns>
        public static TerminationInquiryRequest Create(RequestMap map, IndividualApiConfig apiConfig = null) {
            return BaseObject.Execute("create", new TerminationInquiryRequest(map), apiConfig);
        }

        /// <summary>
        /// Creates object of type TerminationInquiryRequest
        /// </summary>
        /// <param name="map">containing the required parameters to create a new object</param>
        /// <returns>TerminationInquiryRequest of the response of created instance.</returns>
        public static TerminationInquiryRequest Create(IDictionary<string, object> map, IndividualApiConfig apiConfig = null) {
            return BaseObject.Execute("create", new TerminationInquiryRequest(map), apiConfig);
        }

        protected override OperationConfig GetOperationConfig(string operationUUID) {
            if(operationUUID == "create") {
                return new OperationConfig(
                    "/fraud/merchant/v3/termination-inquiry",
                    "create",
                    new List<string>() { "PageOffset", "PageLength" },
                    new List<string>()
                );
            }

            throw new Exception("Invalid operation supplied: " + operationUUID);
        }

        protected override OperationMetadata GetOperationMetadata() {
            return new OperationMetadata(VersionInfo.AssemblyVersion, null);
        }
    }
}
