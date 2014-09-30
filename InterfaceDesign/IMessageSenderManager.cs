using System;
namespace InterfaceDesign {
    // Interface methods contains lots of paramters to suit both class
    // If another message sender is added in the future, possibly new parameters will be added.
    interface IMessageSenderManager {
        bool AddContact(string name, string mail, string phoneNumber, string mailType, string userName, string messagePlatform);
        bool SendMessage(string recipientMailAddress,string recipientUserName, string message);
    }
}
