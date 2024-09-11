﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static JurayUniversal.Domain.Enum.Enum;

namespace JurayUniversal.Domain.Models
{
    public class PageSection
    {
        public long Id { get; set; }
        public string? VideoUrl { get; set; }
        public string? VideoKey { get; set; }

        public string? ImageUrl { get; set; }
        public string? ImageKey { get; set; }


        public string? SecondImageUrl { get; set; }
        public string? SecondImageKey { get; set; }

        [Display(Name = "Youtube Url Link")]
        public string? YoutubeUrlLink { get; set; }



        [Display(Name = "Title")]
        public string? Title { get; set; }

        [Display(Name = "Mini Title")]
        public string? MiniTitle { get; set; }

        [Display(Name = "Qoute")]
        public string? Qoute { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Full Description")]
        public string? FullDescription { get; set; }

        [Display(Name = "Button Text")]
        public string? ButtonText { get; set; }

        [Display(Name = "Button Link")]
        public string? ButtonLink { get; set; }
         [Display(Name = "Direct Url")]
        public string? DirectUrl { get; set; }
        [Display(Name = "Show In Home")]
        public bool ShowInHome { get; set; }

        [Display(Name = "Disable Button")]
        public bool DisableButton { get; set; }


        public bool Disable { get; set; }

        [Display(Name = "Fixed After Footer")]
        public bool FixedAfterFooter { get; set; }

        [Display(Name = "Home Page Sort Order")]
        public int HomePageSortOrder { get; set; }

        [Display(Name = "Home Sort From")]
        public HomeSortFrom HomeSortFrom { get; set; }

        [Display(Name = "Page Sort Order")]
        public int PageSortOrder { get; set; }

        [Display(Name = "Blog Section Position")]
        public BlogSectionPosition BlogSectionPosition { get; set; }

        [Display(Name = "Show Section In Blog")]
        public bool ShowSectionInBlog { get; set; }


        public long? WebPageId { get; set; }
        public WebPage WebPage { get; set; }

        public string? TemplateKey { get; set; }
        public string? CustomClass { get; set; }

        [Display(Name = "Add To Ribon")]
        public bool AddToRibon { get; set; }
        [Display(Name = "Ribon Custom Display Title (if you want a title that will override the main title in the ribon.)")]
        public string? RibonCustomDisplayTitle { get; set; }
        [Display(Name = "Ribon Sort Order")]
        public int RibonSortOrder { get; set; }

        public ICollection<PageSectionList> PageSectionLists { get; set; }
    }
}
