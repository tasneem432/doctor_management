﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorCW.Models
{
    public class DoctorRegistration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public bool ApprovalStatus {  get; set; }
        public string? Address { get; set; }
        [ValidateNever]
        public string? Picpath { get; set; }
        [NotMapped]
        public IFormFile Pic { get; set; }
        public string Bio { get; set; }
    }
}
