﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterCard.Core.Model;
using MasterCard_Core_Unofficial.MasterCard.Core;

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
        public static RetroactiveInquiryRequest create(RequestMap map, IndividualApiConfig apiConfig = null) {
            return BaseObject.Execute("create", new RetroactiveInquiryRequest(map), apiConfig);
        }

        /// <summary>
        /// Creates object of type RetroactiveInquiryRequest
        /// </summary>
        /// <param name="map">containing the required parameters to create a new object</param>
        /// <returns>RetroactiveInquiryRequest of the response of created instance.</returns>
        public static RetroactiveInquiryRequest create(IDictionary<string, object> map, IndividualApiConfig apiConfig = null) {
            return BaseObject.Execute("create", new RetroactiveInquiryRequest(map), apiConfig);
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
            return new OperationMetadata(VersionInfo.AssemblyVersion, null);
        }

    }
}
