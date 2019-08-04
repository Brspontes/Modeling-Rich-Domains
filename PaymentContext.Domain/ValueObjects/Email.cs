using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string email)
        {
            EmailAddress = email;
            AddNotifications(new Contract()
                .Requires()
                .IsEmail(email, "Email.Address", "Email inválido"));
        }

        public string EmailAddress { get; private set; }
    }
}
