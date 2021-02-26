using System.ComponentModel.DataAnnotations;

namespace SGrade.Models
{
    public class Review : IEntity
    {

        [Display(Name = "Tytuł")]
        [MaxLength(30)]
        [Required]
        public string ReviewTitle { get; set; }

        [Display(Name = "Ilość gwiazdek")]
        [Range(0, 5)]
        public float NumberOfStars { get; set; }

        [Required]
        [Display(Name = "Komentarz")]
        public string ReviewMessage { get; set; }

        public float MarkOfTheReview { get; set; }

        public string UserName { get; set; }

        public ApplicationUser User { get; set; }
        public int UserId { get; set; }
        public int? TeacherId { get; set; }
#pragma warning disable CS8632 // Adnotacja dla typów referencyjnych dopuszczających wartość null powinna być używana tylko w kodzie z kontekstem adnotacji „#nullable”.
        public Teacher? Teacher { get; set; }
#pragma warning restore CS8632 // Adnotacja dla typów referencyjnych dopuszczających wartość null powinna być używana tylko w kodzie z kontekstem adnotacji „#nullable”.
        public int? SubjectId { get; set; }

#pragma warning disable CS8632 // Adnotacja dla typów referencyjnych dopuszczających wartość null powinna być używana tylko w kodzie z kontekstem adnotacji „#nullable”.
        public Subject? Subject { get; set; }
#pragma warning restore CS8632 // Adnotacja dla typów referencyjnych dopuszczających wartość null powinna być używana tylko w kodzie z kontekstem adnotacji „#nullable”.
        public int? MajorId { get; set; }
#pragma warning disable CS8632 // Adnotacja dla typów referencyjnych dopuszczających wartość null powinna być używana tylko w kodzie z kontekstem adnotacji „#nullable”.
        public Major? Major { get; set; }
#pragma warning restore CS8632 // Adnotacja dla typów referencyjnych dopuszczających wartość null powinna być używana tylko w kodzie z kontekstem adnotacji „#nullable”.
        public int? UniversityId { get; set; }
#pragma warning disable CS8632 // Adnotacja dla typów referencyjnych dopuszczających wartość null powinna być używana tylko w kodzie z kontekstem adnotacji „#nullable”.
        public University? University { get; set; }
#pragma warning restore CS8632 // Adnotacja dla typów referencyjnych dopuszczających wartość null powinna być używana tylko w kodzie z kontekstem adnotacji „#nullable”.


    }
}