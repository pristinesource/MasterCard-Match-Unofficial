using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterCard.Core.Model;
using NUnit.Framework;

namespace Test {
    public abstract class BaseTest {

        public Dictionary<string, BaseObject> responses = new Dictionary<string, BaseObject>();
        //protected object logger = null;


        public virtual void setup() {
            //this.logger = new object();
        }


        public void putResponse(string name, BaseObject response) {
            this.responses.Add(name, response);
        }

        /**
         *
         * @param type $overrideValue
         * @return type
         */
        public object resolveResponseValue(string overrideValue) {


            var pos = overrideValue.IndexOf('.');

            var name = overrideValue.Substring(0, pos);
            var key = overrideValue.Substring(pos + 1);

            if(responses.ContainsKey(name)) {
                var response = responses[name];
                if(response.ContainsKey(key)) {
                    return response[key];
                } else {
                    // this.logger.Error("Key:'" + key + "' is not found in the response");
                }
            } else {
                // this.logger.Error("Example:'" + name + "' is not found in the response");
            }

            return null;
        }

        protected void AssertAreEqualAsString<T>(string value1, T value2) {
            Assert.AreEqual(value1, Convert.ToString(value2));
        }
    }
}
