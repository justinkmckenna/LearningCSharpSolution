using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class WaysToImplementAnInterface
    {
        [Fact]
        public void MakingARegistration()
        {
            var emailer = new Emailer();

            var specialEventRegistration = new SpecialEventRegistration(emailer)
            {
                DateOfEvent = new DateTime(2021, 4, 20),
                Employee = new Employee("Justin", "DEV", "280000"),
                Event = "Jeffs birthday bash."
            };
            specialEventRegistration.Invite();
        }

    }

    public enum ContentType { Plain, Html, Rtf }
    public class Emailer: IEmailPartyInvitations
    {
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string From { get; set; }
        public ContentType ContentType { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            // send the email
        }

        void IEmailPartyInvitations.Invite(string To, string Message)
        {
            Recipient = To;
            Content = Message;
            ContentType = ContentType.Plain;
            From = "partyhost@gmail.com";
            Send();
        }
    }

    public class SpecialEventRegistration
    {

        private IEmailPartyInvitations _emailer;

        public SpecialEventRegistration(IEmailPartyInvitations emailer)
        {
            _emailer = emailer;
        }

        public Employee Employee { get; set; }
        public string Event { get; set; }
        public DateTime DateOfEvent { get; set; }
        public void Invite() 
        {
            _emailer.Invite(Employee.Name + "@gmail.com", $"You are invited to {Event} on {DateOfEvent:D}.");
        }

    }
}
