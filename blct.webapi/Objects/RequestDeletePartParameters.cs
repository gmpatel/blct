using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blct.WebApi.Objects
{   
    public class RequestDeletePartParameters
    {
        [BindRequired]
        public int[] ProductIds { get; set;}
        [BindRequired]
        public int Position { get; set; }
    }
}