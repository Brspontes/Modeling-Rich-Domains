using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(firstName, 3, "Name.FirstName", "Nome deve conter três caracteres")
                .HasMinLen(lastName, 3, "lastName.LastName", "Sobrenome deve conter três caracteres")
                .HasMaxLen(firstName, 40, "Name.FirstName", "Nome deve conter 40 caracteres"));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
