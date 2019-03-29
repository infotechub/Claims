using TestMVCMultiEdit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NovoClaims.ViewModel
{
    public class ProviderListViewModel
    {
        [Key]
        public int Id { get; set; }
        public List<Provider> Providers { get; set; }
        public List<Claim> Claims { get; set; }
        public List<ClaimBatch> ClaimsBatch { get; set; }
        public List<ClaimDrug> ClaimDrugs { get; set; }
        public List<ClaimService> ClaimServices { get; set; }
        public List<Enrollee> Enrollees { get; set; }
        public List<Company> Companies { get; set; }
        public List<User> Users { get; set; }
        public List<Subscription> Subscriptions { get; set; }
        public List<CompanySubsidiary> CompanySubsidiaries { get; set; }
    }
}