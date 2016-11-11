using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterCard.Core.Model;
using MasterCard_Core_Unofficial.MasterCard.Core;

namespace MasterCard.Api.Match {
    public class TerminationInquiryHistoryRequestJSON : BaseObject {

        public TerminationInquiryHistoryRequestJSON(RequestMap bm) : base(bm) {
        }

        public TerminationInquiryHistoryRequestJSON(IDictionary<string, object> map) : base(map) {
        }

        public TerminationInquiryHistoryRequestJSON() {
        }

        /// <summary>
        /// Creates object of type TerminationInquiryHistoryRequestJSON
        /// </summary>
        /// <param name="criteria">containing the required parameters to read</param>
        /// <returns>TerminationInquiryHistoryRequestJSON of the response.</returns>
        public static TerminationInquiryHistoryRequestJSON Read( RequestMap criteria, IndividualApiConfig apiConfig = null) {
            return BaseObject.Execute("read", new TerminationInquiryHistoryRequestJSON(criteria), apiConfig);
        }

        /// <summary>
        /// Creates object of type TerminationInquiryHistoryRequestJSON
        /// </summary>
        /// <param name="criteria">containing the required parameters to read</param>
        /// <returns>TerminationInquiryHistoryRequestJSON of the response.</returns>
        public static TerminationInquiryHistoryRequestJSON Read(IDictionary<string, object> criteria, IndividualApiConfig apiConfig = null) {
            return BaseObject.Execute("read", new TerminationInquiryHistoryRequestJSON(criteria), apiConfig);
        }

        protected override OperationConfig GetOperationConfig(string operationUUID) {
            if(operationUUID == "read") {
                return new OperationConfig(
                    "/fraud/merchant/v3/termination-inquiry/{IRN}",
                    "read",
                    new List<string>() { "PageOffset", "PageLength", "AcquirerId" },
                    new List<string>()
                ) {
                  RepsonseType = DataType.Json,
                  RequestType = DataType.Json
                };
            }

            throw new Exception("Invalid operation supplied: " + operationUUID);
        }

        protected override OperationMetadata GetOperationMetadata() {
            return new OperationMetadata(VersionInfo.AssemblyVersion, null);
        }
    }
}
