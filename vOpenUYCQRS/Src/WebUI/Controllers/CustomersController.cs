using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vOpenUYCQRS.Application.Customers.Commands.CreateCustomer;
using vOpenUYCQRS.Application.Customers.Commands.DeleteCustomer;
using vOpenUYCQRS.Application.Customers.Commands.UpdateCustomer;
using vOpenUYCQRS.Application.Customers.Queries.GetCustomerDetail;
using vOpenUYCQRS.Application.Customers.Queries.GetCustomersList;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace vOpenUYCQRS.WebUI.Controllers
{
    [Authorize]
    public class CustomersController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CustomersListVm>> GetAll()
        {
            return Ok(await Mediator.Send(new GetCustomersListQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CustomerDetailVm>> Get(string id)
        {
            return Ok(await Mediator.Send(new GetCustomerDetailQuery { Id = id }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create([FromBody]CreateCustomerCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update([FromBody]UpdateCustomerCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id)
        {
            await Mediator.Send(new DeleteCustomerCommand { Id = id });

            return NoContent();
        }
    }
}