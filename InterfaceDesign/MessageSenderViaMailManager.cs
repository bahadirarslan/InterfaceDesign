using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesign {
    public class MessageSenderViaMailManager : IMessageSenderManager {
        // userName and messagePlatform parameters aren't used in method but required for interface implemenatation
        public bool AddContact(string name, string mail, string phoneNumber, string mailType, string userName, string messagePlatform) {
            Console.WriteLine(string.Format("Contact {0} ({1}) added to list with phone number {2} and mail type choise {3}", name, mail, phoneNumber, mailType));
            return true;
        }

        public bool SendMessage(string recipientMailAddress,string recipientUserName, string message) {
            // In this method, recipientUserName isn't used.
            Console.WriteLine(string.Format("Message sent by mail:{0}, message:{1}", recipientMailAddress, message));
            return true;
        }       
    }
}
