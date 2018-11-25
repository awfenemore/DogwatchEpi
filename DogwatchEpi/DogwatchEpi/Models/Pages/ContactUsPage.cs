using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace DogwatchEpi.Models.Pages
{
    [ContentType(DisplayName = "ContactUsPage", GUID = "b73c32c9-1eb9-4af7-80bf-31eddb0fb664", Description = "Contact Us Page")]
    public class ContactUsPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Contact Email",
            Description = "Contact Email for the company",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string ContactEmail { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Contact Phone",
            Description = "Contact Phone for the company",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string ContactPhone { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Opening Hours",
            Description = "Opening Hours for the centre, formatted",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual XhtmlString OpeningHours { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Address",
            Description = "Address for the centre, formatted",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual XhtmlString Address { get; set; }

    }
}