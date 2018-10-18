using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace DogwatchEpi.Models.Pages
{
    [ContentType(DisplayName = "DogPage", GUID = "80ef5bfd-c402-42ec-8122-ce4d129230d8", Description = "")]
    public class DogPage : SitePageData
    {
        [Display(
            GroupName = Global.GroupNames.MetaData,
            Order = 300)]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string DogName { get; set; }

        [Display(
            GroupName = Global.GroupNames.MetaData,
            Order = 200)]
        [CultureSpecific]
        [BackingType(typeof(PropertyStringList))]
        public virtual string[] PreviousDogNames { get; set; }

        [Display(
            GroupName = Global.GroupNames.MetaData,
            Order = 400)]
        [CultureSpecific]
        public virtual bool Desexed { get; set; }

        [Display(
            GroupName = Global.GroupNames.MetaData,
            Order = 400)]
        [CultureSpecific]
        public virtual bool Vaccinated { get; set; }

        [Display(
            GroupName = Global.GroupNames.MetaData,
            Order = 300)]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string DogDescription { get; set; }
    }
}