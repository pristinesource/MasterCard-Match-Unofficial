﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterCard.Core.Model;

namespace MasterCard.Api.Match {
    public class AcquirerContactRequest : BaseObject {

        public AcquirerContactRequest(RequestMap bm) : base(bm) { }

        public AcquirerContactRequest(IDictionary<string,object> map) : base(map) { }

        public AcquirerContactRequest() { }

        /// <summary>
        /// Creates object of type AcquirerContactRequest
        /// </summary>
        /// <param name="map">containing the required parameters to create a new object</param>
        /// <returns>AcquirerContactRequest of the response of created instance.</returns>
        public static AcquirerContactRequest Create(RequestMap map) {
            return BaseObject.Execute("create", new AcquirerContactRequest(map));
        }

        /// <summary>
        /// Creates object of type AcquirerContactRequest
        /// </summary>
        /// <param name="map">containing the required parameters to create a new object</param>
        /// <returns>AcquirerContactRequest of the response of created instance.</returns>
        public static AcquirerContactRequest Create(IDictionary<string, object> map) {
            return BaseObject.Execute("create", new AcquirerContactRequest(map));
        }

        protected override OperationConfig GetOperationConfig(string operationUUID) {
            if(operationUUID == "create") {
                return new OperationConfig(
                    "/fraud/merchant/v3/common/contact-details",
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
