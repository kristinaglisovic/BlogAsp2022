using Blog.Domain.Entities;
using System.Collections.Generic;

namespace Blog.Api.Core
{
    public class JwtUser : IApplicationUser
    {
        public string Identity { get; set;}

        public int Id { get; set; }
        public IEnumerable<int> UseCaseIds { get; set; } = new List<int>();
        public string Email { get; set; }
    }

    public class AnonimousUser : IApplicationUser
    {
        public string Identity => "Anonymous";

        public int Id => 0;

        public IEnumerable<int> UseCaseIds => new List<int> { 1, 2, 4, 6, 22, 24, 33, 35, 42, 43, 44, 18, 19 };

        public string Email => "anonimous@blog-asp-api.com";
    }
}
