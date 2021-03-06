﻿using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using DWSHTA.WebApi.DataObjects;
using DWSHTA.WebApi.Models;

namespace DWSHTA.WebApi.Controllers
{
    public class MenuItemController : TableController<MenuItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<MenuItem>(context, Request, enableSoftDelete: true);
        }

        // GET tables/MenuItem
        public IQueryable<MenuItem> GetAllMenuItems()
        {
            return Query();
        }

        // GET tables/MenuItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<MenuItem> GetMenuItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/MenuItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<MenuItem> PatchMenuItem(string id, Delta<MenuItem> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/MenuItem
        public async Task<IHttpActionResult> PostMenuItem(MenuItem item)
        {
            MenuItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/MenuItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMenuItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}