﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NotesMarketPlace.Models.Admin
{
    public class SystemConfigurationsModel
    {
        public int SystemConfigurationsID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        [Required(ErrorMessage = "Enter Support Email")]
        [EmailAddress]
        public string SupportEmail { get; set; }

        [Required(ErrorMessage = "Enter Support Phone Number")]
        public string SupportContact { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress]
        public string Emails { get; set; }

        public string FacebookUrl { get; set; }

        public string TwitterUrl { get; set; }

        public string LinkedinUrl { get; set; }

        public string DefaultProfileImg { get; set; }

        public string DefaultNoteImg { get; set; }

        public string TempPath { get; set; }

        [Required(ErrorMessage = "Select Default Profile Image")]
        public HttpPostedFileBase DefaultNotePicturePath { get; set; }

        //[Required(ErrorMessage = "Select Default Profile Image")]
        public HttpPostedFileBase DefaultDefaultProfileImgPath { get; set; }

        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
