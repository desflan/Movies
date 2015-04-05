using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSite.Services.Enumerations
{
    public enum Classification
    {
        [Display(Name = "Check the Classification")]
        CTC,
        [Display(Name = "General")]
        G,
        [Display(Name = "Parental Guidance")]
        PG,
        [Display(Name = "Mature")]
        M,
        [Display(Name = "Mature Audiences 15+")]
        MA,
        [Display(Name = "Restricted 18+")]
        R,
        [Display(Name = "Restricted Sexually Explicit 18+")]
        X
    }
}
