﻿

namespace Fluxus.Infra.Records
{
    public record BankBranchIndex
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Phone1 { get; set; }
        public string? Email { get; set; }
    }
}
