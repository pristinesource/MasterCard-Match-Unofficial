using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterCard.Core.Model;

namespace MasterCard.Api.Match {
    public class AddTerminatedMerchant : BaseObject {

        public AddTerminatedMerchant(RequestMap bm) : base(bm) { }

        public AddTerminatedMerchant(IDictionary<string, object> map) : base(map) { }

        public AddTerminatedMerchant() { }

        /// <summary>
        /// Creates object of type AddTerminatedMerchant
        /// </summary>
        /// <param name="map">containing the required parameters to create a new object</param>
        /// <returns>AddTerminatedMerchant of the response of created instance.</returns>
        public static AddTerminatedMerchant Create(RequestMap map) {
            return BaseObject.Execute("create", new AddTerminatedMerchant(map));
        }

        /// <summary>
        /// Creates object of type AddTerminatedMerchant
        /// </summary>
        /// <param name="map">containing the required parameters to create a new object</param>
        /// <returns>AddTerminatedMerchant of the response of created instance.</returns>
        public static AddTerminatedMerchant Create(IDictionary<string, object> map) {
            return BaseObject.Execute("create", new AddTerminatedMerchant(map));
        }

        protected override OperationConfig GetOperationConfig(string operationUUID) {
            if(operationUUID == "create") {
                return new OperationConfig(
                    "/fraud/merchant/v3/add-merchant",
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
