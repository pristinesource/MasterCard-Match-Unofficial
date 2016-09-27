using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterCard.Core.Model;

namespace MasterCard.Api.Match {
    public class RetroactiveInquiryRequest : BaseObject {

        public RetroactiveInquiryRequest(RequestMap bm) : base(bm) { }

        public RetroactiveInquiryRequest(IDictionary<string, object> map) : base(map) { }

        public RetroactiveInquiryRequest() { }

        /// <summary>
        /// Creates object of type RetroactiveInquiryRequest
        /// </summary>
        /// <param name="map">containing the required parameters to create a new object</param>
        /// <returns>RetroactiveInquiryRequest of the response of created instance.</returns>
        public static RetroactiveInquiryRequest create(RequestMap map) {
            return BaseObject.Execute("create", new RetroactiveInquiryRequest(map));
        }

        /// <summary>
        /// Creates object of type RetroactiveInquiryRequest
        /// </summary>
        /// <param name="map">containing the required parameters to create a new object</param>
        /// <returns>RetroactiveInquiryRequest of the response of created instance.</returns>
        public static RetroactiveInquiryRequest create(IDictionary<string, object> map) {
            return BaseObject.Execute("create", new RetroactiveInquiryRequest(map));
        }

        protected override OperationConfig GetOperationConfig(string operationUUID) {
            if(operationUUID == "create") {
                return new OperationConfig(
                    "/fraud/merchant/v3/retro/retro-list",
                    "create",
                    new List<string>(),
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
