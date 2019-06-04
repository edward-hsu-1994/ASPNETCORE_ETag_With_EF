using System;

namespace WebApplication2.Models {
    public class Article {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Time { get; set; }
    }
}