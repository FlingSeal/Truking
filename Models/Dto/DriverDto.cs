﻿namespace Truking.Models.Dto
{
    public class DriverDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int DriverStatus { get; set; }
        public string? Description { get; set; }
        public long PaymentAmount { get; set; }
    }
}
