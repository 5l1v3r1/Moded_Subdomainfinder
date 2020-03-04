using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moded_Subdomainfinder
{
    public class GetSubdomainResult
    {
        public String Message { get; set; }
        public Exception Ex { get; set; }
        public List<Subdomain> Subdomains = new List<Subdomain>();
        public String Raw { get; set; }
    }
}
