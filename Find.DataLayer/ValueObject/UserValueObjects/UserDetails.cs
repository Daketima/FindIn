using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class UserDetail
{
    [Required]
    [MaxLength(54)]
    public string FirstName { get; set; }
    [MaxLength(54)]
    public string MiddleName { get; set; }
    [Required]
    [MaxLength(54)]
    public string LastName { get; set; }
    [Required]
    public int GenderId { get; set; }
    [Required]
    [MaxLength(11)]
    public string BVN { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
    public bool IsActive { get; set; }
    public int MaritalStatusId { get; set; }
    public DateTime DateCreated { get; set; }


    public HashSet<EducationBackground> educationBackGround;

    public Address _userAddress;
    public UserDetail()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
