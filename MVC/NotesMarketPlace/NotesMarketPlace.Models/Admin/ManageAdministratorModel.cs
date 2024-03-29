﻿using System;

namespace NotesMarketPlace.Models.Admin
{
    public class ManageAdministratorModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime? DateAdded { get; set; }

        public string Active { get; set; }
    }
}
