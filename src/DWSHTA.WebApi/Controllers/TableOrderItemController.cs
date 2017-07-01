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
    public class TableOrderItemController : TableController<TableOrderItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<TableOrderItem>(context, Request, enableSoftDelete: true);
        }

        // GET tables/TableOrderItem
        public IQueryable<TableOrderItem> GetAllTableOrderItems()
        {
            return Query();
        }

        // GET tables/TableOrderItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<TableOrderItem> GetTableOrderItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TableOrderItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<TableOrderItem> PatchTableOrderItem(string id, Delta<TableOrderItem> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TableOrderItem
        public async Task<IHttpActionResult> PostTableOrderItem(TableOrderItem item)
        {
            TableOrderItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TableOrderItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTableOrderItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}