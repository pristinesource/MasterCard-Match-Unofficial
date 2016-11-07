using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterCard.Core.Model;
using MasterCard_Core_Unofficial.MasterCard.Core;

namespace MasterCard.Api.Match {
    public class TerminationInquiryHistoryRequest : BaseObject {

        public TerminationInquiryHistoryRequest(RequestMap bm) : base(bm) {
        }

        public TerminationInquiryHistoryRequest(IDictionary<string, object> map) : base(map) {
        }

        public TerminationInquiryHistoryRequest() {
        }

        /// <summary>
        /// Creates object of type TerminationInquiryHistoryRequest
        /// </summary>
        /// <param name="criteria">containing the required parameters to read</param>
        /// <returns>TerminationInquiryHistoryRequest of the response.</returns>
        public static TerminationInquiryHistoryRequest Read( RequestMap criteria, IndividualApiConfig apiConfig = null) {
            return BaseObject.Execute("read", new TerminationInquiryHistoryRequest(criteria), apiConfig);
        }

        /// <summary>
        /// Creates object of type TerminationInquiryHistoryRequest
        /// </summary>
        /// <param name="criteria">containing the required parameters to read</param>
        /// <returns>TerminationInquiryHistoryRequest of the response.</returns>
        public static TerminationInquiryHistoryRequest Read(IDictionary<string, object> criteria, IndividualApiConfig apiConfig = null) {
            return BaseObject.Execute("read", new TerminationInquiryHistoryRequest(criteria), apiConfig);
        }

        protected override OperationConfig GetOperationConfig(string operationUUID) {
            if(operationUUID == "read") {
                return new OperationConfig(
                    "/fraud/merchant/v3/termination-inquiry/{IRN}",
                    "read",
                    new List<string>() { "PageOffset", "PageLength", "AcquirerId" },
                    new List<string>()
                ) {
                  RepsonseType = DataType.Xml,
                  RequestType = DataType.Xml
                };
            }

            throw new Exception("Invalid operation supplied: " + operationUUID);
        }

        protected override OperationMetadata GetOperationMetadata() {
            return new OperationMetadata(VersionInfo.AssemblyVersion, null);
        }
    }
}
