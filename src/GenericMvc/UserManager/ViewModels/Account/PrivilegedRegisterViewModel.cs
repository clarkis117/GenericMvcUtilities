﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GenericMvc.Models;

namespace GenericMvc.ViewModels.UserManager.Account
{
	/// <summary>
	/// TODO: update this to work with new application user model, and razor form
	/// </summary>
	public class PrivilegedRegisterViewModel : IPrivilegedUserExtraProps
	{
		[Required]
		[StringLength(150, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
		[DataType(DataType.Text)]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Required]
		[StringLength(150, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
		[DataType(DataType.Text)]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Required]
		[EmailAddress]
		[DataType(DataType.EmailAddress)]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required]
		[EmailAddress]
		[DataType(DataType.EmailAddress)]
		[Display(Name = "Confirm Email")]
		[Compare(nameof(Email), ErrorMessage = "The email address and confirmation email address do not match.")]
		public string ConfirmEmail { get; set; }

		[Required]
		[Phone]
		[DataType(DataType.PhoneNumber)]
		[Display(Name ="Phone Number")]
		public string PhoneNumber { get; set; }

		[Required]
		[Phone]
		[DataType(DataType.PhoneNumber)]
		[Display(Name = "Confirm Phone Number")]
		[Compare(nameof(PhoneNumber), ErrorMessage = "The Phone Number and confirmation Phone Number do not match.")]
		public string ConfirmPhoneNumber { get; set; }

		//todo: fix handling of this through user manager
		[Required]
		[Display(Name ="Requested Role")]
		public string RequestedRole { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[Display(Name = "Date Registered")]
		public DateTime DateRegistered { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }
	}

	public interface IPrivilegedUserExtraProps : IPrivilegedUserConstraints
	{
		string ConfirmPhoneNumber { get; set; }

		string ConfirmEmail { get; set; }

		string Password { get; set; }

		string ConfirmPassword { get; set; }
	}
}
