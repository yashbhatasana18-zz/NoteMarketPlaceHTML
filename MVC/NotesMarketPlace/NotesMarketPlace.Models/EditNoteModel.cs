﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NotesMarketPlace.Models
{
    public class EditNoteModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(100, ErrorMessage = "<100 char")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\s]*$", ErrorMessage = "Use letters only")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int Category { get; set; }

        public HttpPostedFileBase DisplayPicture { get; set; }

        public HttpPostedFileBase[] UploadNotes { get; set; }

        public Nullable<int> NoteType { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only digits allowed")]
        public Nullable<int> NumberofPages { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [MaxLength(200, ErrorMessage = "University name should be <200 char")]
        public string UniversityName { get; set; }

        public Nullable<int> Country { get; set; }

        [MaxLength(100, ErrorMessage = "Course name should be <100 char")]
        public string Course { get; set; }

        [MaxLength(100, ErrorMessage = "CourseCode should be <100 char")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only digits allowed")]
        public string CourseCode { get; set; }

        [MaxLength(100, ErrorMessage = "Professor should be <100 char")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\s]*$", ErrorMessage = "Use letters only")]
        public string Professor { get; set; }

        [Required(ErrorMessage = "Select the Selling Mode")]
        public bool IsPaid { get; set; }

        [RegularExpression(@"((\d+)((\. \d{1,2})?))$", ErrorMessage = "Valid Decimal number with maximum 2 decimal places")]
        public Nullable<decimal> SellingPrice { get; set; }

        public HttpPostedFileBase NotesPreview { get; set; }

        public IEnumerable<NoteCategoriesModel> NoteCategoryList { get; set; }

        public IEnumerable<NoteTypesModel> NoteTypeList { get; set; }

        public IEnumerable<CountriesModel> CountryList { get; set; }

        public string DisplayPicturePathName { get; set; }
        public string NotePreviewPathName { get; set; }
        public string NotePathName { get; set; }
    }
}
