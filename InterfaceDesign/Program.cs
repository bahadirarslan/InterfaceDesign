using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesign {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to message sending program. Please select and enter user id to send message:");
            Console.WriteLine("ID\tName");
            Console.WriteLine("12\tBahadir");
            Console.WriteLine("27\tFurkan");
            Console.WriteLine("19\tGamze");
            Console.WriteLine("08\tSelman");
            Console.Write("User ID:");
            string id = Console.ReadLine();
            if(!string.IsNullOrEmpty(id)) {
                User selectedUser = FindUserById(id);
                IMessageSenderManager manager = MessageSenderFactory(id);
                if(manager != null && selectedUser != null) {
                    Console.Write("Enter your message:");
                    string message = Console.ReadLine();
                    if(!(string.IsNullOrEmpty(message))){
                        // The problem lays here, at this point i don't know which user is selected and which parameters are mandatory to send message.
                        // So i am supplying both of them
                        // In this small example this can be underestimated but it will be very complicated when methods become complex
                        // Also i don't want to check with if to determine which MessageSender will be used, because new message senders can be added in future 
                        // and checking with if condition will require code altering.
                        manager.SendMessage(selectedUser.Mail, selectedUser.UserName, message);
                    }
                }
            }
            Console.WriteLine("Thanks for sending message via our program");
            Console.WriteLine("Bye! Bye!");
            Console.ReadLine();
        }

        private static IMessageSenderManager MessageSenderFactory(string id) {
            switch(id) {
                case "12":
                    return new MessageSenderViaMailManager();
                case "27":
                    return new MessageSenderViaUserNameManager();
                case "19":
                    return new MessageSenderViaMailManager();
                case "08":
                    return new MessageSenderViaUserNameManager();
                default:
                    break;
            }
            return null;
        }

        private static User FindUserById(string id) {
            switch(id) {
                case "12":
                    return new User() {
                        ID = id,
                        Mail = "bahadir@nospam.com",
                        UserName = "bahadiarslan",
                        Name = "Bahadir"
                    };
                case "27":
                    return new User() {
                        ID = id,
                        Mail = "furkan@nospam.com",
                        UserName = "fomay",
                        Name = "Furkan"
                    };
                case "19":
                    return new User() {
                        ID = id,
                        Mail = "gamze@nospam.com",
                        UserName = "gibar",
                        Name = "Gamze"
                    };
                case "08":
                    return new User() {
                        ID = id,
                        Mail = "selman@nospam.com",
                        UserName = "namles",
                        Name = "Selman"
                    };
                default:
                    break;
            }
            return null;
        }
    }
}
