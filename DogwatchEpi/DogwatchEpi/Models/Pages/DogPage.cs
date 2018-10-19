using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;
using DogwatchEpi.Models.Media;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors.SelectionFactories;
using EPiServer.Core;
using EPiServer.DataAbstraction;
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
            Order = 320)]
        [CultureSpecific]
        [SelectOne(SelectionFactoryType = typeof(SelectionFactories.GenderSelectionFactory))]
        public virtual string Gender { get; set; }

        [Display(
            Order = 325)]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string DogDescription { get; set; }

        [Display(
            Order = 330)]
        [CultureSpecific]
        public virtual string ArrivalDescription { get; set; }

        [Display(
            Order = 405)]
        [CultureSpecific]
        public virtual bool Desexed { get; set; }

        [Display(
            Order = 410)]
        [CultureSpecific]
        public virtual bool Vaccinated { get; set; }

        [Display(
            Order = 415)]
        [CultureSpecific]
        [SelectOne(SelectionFactoryType = typeof(SelectionFactories.ChildSelectionFactory))]
        public virtual bool ChildSuitable { get; set; }

        [Display(
            Order = 420)]
        [CultureSpecific]
        [SelectOne(SelectionFactoryType = typeof(SelectionFactories.CatSelectionFactory))]
        public virtual string CatSuitable { get; set; }





        [UIHint("MultipleImagesEditor")]
        [BackingType(typeof(PropertyMultipleImages))]
        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        public virtual MultipleImages DogImages { get; set; }



}

}
