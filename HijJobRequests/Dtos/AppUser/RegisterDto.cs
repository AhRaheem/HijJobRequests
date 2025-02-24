using System.ComponentModel.DataAnnotations;

namespace HijJobRequests.Dtos.AppUser
{
    public class RegisterDto
    {
        public decimal FCompanyId { get; set; }


        public string FEmpFirst { get; set; } = null!;
        public string? FEmpFather { get; set; }
        public string? FEmpGrandfather { get; set; }
        public string FEmpFamily { get; set; } = null!;
        public string FEmpFirstE { get; set; } = null!;
        public string? FEmpFatherE { get; set; }
        public string? FEmpGrandfatherE { get; set; }
        public string FEmpFamilyE { get; set; } = null!;
        public string FEmpName { get; set; } = null!;
        public string FEmpNameE { get; set; } = null!;
        public decimal FGender { get; set; }
        public string FBirthDate { get; set; } = null!;
        public decimal FAge { get; set; }
        public decimal FNatiNo { get; set; }
        public decimal FIdType { get; set; }
        public decimal FIdNo { get; set; }

        public string? FIdSaveNo { get; set; }

        public string FIdDateExpiry { get; set; } = null!;

        public decimal FBankNo { get; set; }

        [Required(ErrorMessage = "رقم الإيبان مطلوب")]
        [RegularExpression(@"^SA[0-9A-Za-z]{22}$", ErrorMessage = "رقم الإيبان يجب أن يبدأ بـ 'SA' ويليه 22 رقمًا أو حرفًا بدون مسافات.")]
        public string? FBankIbanNo { get; set; }

        public decimal? FHomeCity { get; set; }

        public string FJawNo { get; set; } = null!;


        [EmailAddress(ErrorMessage = "البريد الإلكتروني غير صالح")]
        public string? FEmail { get; set; }

        public decimal FEmailActivation { get; set; }

        public string? FHomeAddress { get; set; }

        public decimal FQualiNo { get; set; }

        public decimal FMajorNo { get; set; }
    }
}
