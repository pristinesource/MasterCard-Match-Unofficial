using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterCard.Core.Model;

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
        public static ResourceList<TerminationInquiryHistoryRequest> Read( RequestMap criteria) {
            return BaseObject.ExecuteForList("read", new TerminationInquiryHistoryRequest(criteria));
        }

        /// <summary>
        /// Creates object of type TerminationInquiryHistoryRequest
        /// </summary>
        /// <param name="criteria">containing the required parameters to read</param>
        /// <returns>TerminationInquiryHistoryRequest of the response.</returns>
        public static ResourceList<TerminationInquiryHistoryRequest> Read(IDictionary<string, object> criteria) {
            return BaseObject.ExecuteForList("read", new TerminationInquiryHistoryRequest(criteria));
        }

        protected override OperationConfig GetOperationConfig(string operationUUID) {
            if(operationUUID == "read") {
                return new OperationConfig(
                    "/fraud/merchant/v3/termination-inquiry/{IRN}",
                    "read",
                    new List<string>() { "PageOffset", "PageLength", "AcquirerId" },
                    new List<string>()
                );
            }

            throw new Exception("Invalid operation supplied: " + operationUUID);
        }

        protected override OperationMetadata GetOperationMetadata() {
            return new OperationMetadata("1.0.1", null);
        }
    }
}
