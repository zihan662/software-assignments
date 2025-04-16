using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderApp;
namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService orderService;

        public OrdersController(OrderService orderService)
        {
            this.orderService = orderService;
        }

        // GET: api/orders
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            return Ok(orderService.Orders);
        }
        // GET: api/orders/{id}
        [HttpGet("{id}")]
        public ActionResult<Order> GetById(string id)
        {
            var order = orderService.GetOrder(id);
            return order != null ? Ok(order) : NotFound();
        }
        // GET: api/orders/by-product/{productName}
        [HttpGet("by-product/{productName}")]
        public ActionResult<IEnumerable<Order>> GetByProduct(
            string productName,
            [FromQuery] DateTime? startDate,
            [FromQuery] DateTime? endDate)
        {
            var query = orderService.QueryOrdersByProductName(productName);
            return query != null ? Ok(query) : NotFound();
        }

        // GET: api/orders/by-customer/{customerName}
        [HttpGet("by-customer/{customerName}")]
        public ActionResult<IEnumerable<Order>> GetByCustomer(
            string customerName,
            [FromQuery] decimal? minTotalPrice)
        {
            var query = orderService.QueryOrdersByCustomerName(customerName);

            return query != null ? Ok(query) : NotFound();
        }
        // POST: api/orders
        [HttpPost]
        public ActionResult<Order> CreateOrder([FromBody] Order order)
        {
            try
            {
                orderService.AddOrder(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return order;
        }

        // DELETE: api/orders/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(string id)
        {
            try
            {
                orderService.RemoveOrder(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult Update(string id, [FromBody] Order order)
        {
            if (id != order.OrderId) return BadRequest("ID不匹配");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                orderService.UpdateOrder(order);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

    }
}

