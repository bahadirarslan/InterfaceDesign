using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesign {
    public class MessageSenderViaUserNameManager : IMessageSenderManager {
        // mailType and phoneNumber parameters aren't used in method but required for interface implemenatation
        public bool AddContact(string name, string mail, string phoneNumber, string mailType, string userName, string messagePlatform) {
            Console.WriteLine(string.Format("Contact {0} ({1}) added to list with user name {2} and message platform choise {3}", name, mail, userName, messagePlatform));
            return true;
        }
        public bool SendMessage(string recipientMailAddress, string recipientUserName, string message) {
            // In this method, recipientMailAddress isn't used.
            Console.WriteLine(string.Format("Message sent by user name:{0}, message:{1}", recipientUserName, message));
            return true;
        }
    }
}
