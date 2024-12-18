using AuthApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace AuthApi.Controllers
{
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [Route("api/[controller]")]
    public class UserController: Controller
    {
        private AuthDbContext _dbContext;
        public UserController(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser([FromBody] User user)
        {
            try
            {
                if (user == null)
                {
                    throw new ArgumentNullException($"nameof(user) is null");
                }

                _dbContext.Users.Add(user);
                await _dbContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The action {nameof(CreateUser)} is failed with an exception {ex}");
            }
        }
    }
}
