﻿using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace DogwatchEpi.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "2f669c4b-f678-4d59-bbd9-42fd4e88c1a1", Description = "")]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The page heading",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description =
                "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}