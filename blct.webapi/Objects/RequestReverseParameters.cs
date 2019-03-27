using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blct.WebApi.Objects
{   
    public class RequestReverseParameters
    {
        [BindRequired]
        public int[] ProductIds { get; set;}
    }
}