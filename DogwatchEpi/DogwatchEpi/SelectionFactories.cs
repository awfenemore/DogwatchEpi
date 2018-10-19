using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell.ObjectEditing;

namespace DogwatchEpi
{

    //This class uses selection factories to return selection items. This is for use in dropdown menus in CMS
    public class SelectionFactories
    {

        public class GenderSelectionFactory : ISelectionFactory
        {
            public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
            {
                return new ISelectItem[] { new SelectItem() { Text = "Male", Value = "Male" }, new SelectItem() { Text = "Female", Value = "Female" }
                };
            }
        }

        public class ChildSelectionFactory : ISelectionFactory
        {
            public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
            {
                return new ISelectItem[] { new SelectItem() { Text = "Suitable", Value = " is suitable with children" }, new SelectItem() { Text = "Unsuitable", Value = " is NOT suitable with children" }, new SelectItem() { Text = "Unknown", Value = " is suitable with children" }, 
                };
            }
        }

        public class CatSelectionFactory : ISelectionFactory
        {
            public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
            {
                return new ISelectItem[] { new SelectItem() { Text = "Suitable", Value = " is suitable with cats" }, new SelectItem() { Text = "Unsuitable", Value = " is NOT suitable with cats" }, new SelectItem() { Text = "Unknown", Value = " is suitable with cats" },
                };
            }
        }
    }
}