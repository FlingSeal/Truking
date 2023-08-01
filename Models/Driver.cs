﻿namespace Truking.Models
{
    public class Driver
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int DriverStatus { get; set; }
        public string? Description { get; set; }
        public long PaymentAmount { get; set; }

        public User? User { get; set; }

    }
}
