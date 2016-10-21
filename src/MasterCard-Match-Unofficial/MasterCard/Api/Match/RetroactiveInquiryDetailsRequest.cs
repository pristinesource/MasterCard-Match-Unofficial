using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterCard.Core.Model;

namespace MasterCard.Api.Match {
    public class RetroactiveInquiryDetailsRequest : BaseObject {

        public RetroactiveInquiryDetailsRequest(RequestMap bm) : base(bm) { }

        public RetroactiveInquiryDetailsRequest(IDictionary<string, object> map) : base(map) { }

        public RetroactiveInquiryDetailsRequest() { }

        /// <summary>
        /// Creates object of type RetroactiveInquiryDetailsRequest
        /// </summary>
        /// <param name="map">containing the required parameters to create a new object</param>
        /// <returns>RetroactiveInquiryDetailsRequest of the response of created instance.</returns>
        public static RetroactiveInquiryDetailsRequest Create(RequestMap map) {
            return BaseObject.Execute("create", new RetroactiveInquiryDetailsRequest(map));
        }

        /// <summary>
        /// Creates object of type RetroactiveInquiryDetailsRequest
        /// </summary>
        /// <param name="map">containing the required parameters to create a new object</param>
        /// <returns>RetroactiveInquiryDetailsRequest of the response of created instance.</returns>
        public static RetroactiveInquiryDetailsRequest Create(IDictionary<string, object> map) {
            return BaseObject.Execute("create", new RetroactiveInquiryDetailsRequest(map));
        }

        protected override OperationConfig GetOperationConfig(string operationUUID) {
            if(operationUUID == "create") {
                return new OperationConfig(
                    "/fraud/merchant/v3/retro/retro-inquiry-details",
                    "create",
                    new List<string>() { "AcquirerId" },
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
