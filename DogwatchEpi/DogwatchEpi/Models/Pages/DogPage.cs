using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors.SelectionFactories;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;

namespace DogwatchEpi.Models.Pages
{
    [ContentType(DisplayName = "DogPage", GUID = "80ef5bfd-c402-42ec-8122-ce4d129230d8", Description = "")]
    public class DogPage : SitePageData
    {
        [Display(
            Order = 300)]
        [CultureSpecific]
        public virtual string DogName { get; set; }

        [Display(
            Order = 305)]
        [UIHint(Global.SiteUIHints.StringsCollection)]
        [CultureSpecific]
        public virtual IList<string> PreviousDogNames { get; set; }

        [Display(
            Order = 310)]
        [CultureSpecific]
        public virtual string BreedDescription { get; set; }

        [Display(
            Order = 315)]
        [CultureSpecific]
        public virtual string AgeDescription { get; set; }


        [Display(
            Order = 325)]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string DogDescription { get; set; }

        [Display(
            Order = 400)]
        [CultureSpecific]
        public virtual bool Desexed { get; set; }

        [Display(
            Order = 400)]
        [CultureSpecific]
        public virtual bool Vaccinated { get; set; }



        [Display(
            Order = 320)]
        [CultureSpecific]
        [SelectOne(SelectionFactoryType = typeof(LanguageSelectionFactory))]
        public virtual string Gender { get; set; }
    }


    public class LanguageSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[] { new SelectItem() { Text = "Male", Value = "Male" }, new SelectItem() { Text = "Female", Value = "Female" }
            };
        }
    }
}
