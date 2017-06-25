using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using DWSHTA.WebApi.DataObjects;
using DWSHTA.WebApi.Models;

namespace DWSHTA.WebApi.Controllers
{
    public class TableOrderController : TableController<TableOrder>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<TableOrder>(context, Request, enableSoftDelete: true);
        }

        // GET tables/TableOrder
        public IQueryable<TableOrder> GetAllTableOrders()
        {
            return Query();
        }

        // GET tables/TableOrder/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<TableOrder> GetTableOrder(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TableOrder/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<TableOrder> PatchTableOrder(string id, Delta<TableOrder> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TableOrder
        public async Task<IHttpActionResult> PostTableOrder(TableOrder item)
        {
            TableOrder current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TableOrder/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTableOrder(string id)
        {
            return DeleteAsync(id);
        }
    }
}