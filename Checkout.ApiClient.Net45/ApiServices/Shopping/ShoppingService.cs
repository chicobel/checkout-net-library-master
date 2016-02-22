using Checkout.ApiServices.SharedModels;
using Checkout.ApiServices.Shopping.RequestModels;
using Checkout.ApiServices.Shopping.ResponseModels;
using Checkout.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping
{
    public class ShoppingService
    {
        private ShoppingToken shoppingToken;

        public ShoppingService(ShoppingToken shoppingToken)
        {
            // TODO: Complete member initialization
            this.shoppingToken = shoppingToken;
        }
        public HttpResponse<ShoppingItem> AddToShoppingList(ShoppingItem requestModel)
        {
            var updateCustomerUri = string.Format(ApiUrls.ShoppingList, "add");
            return new ApiHttpClient().PostRequest<ShoppingItem>(ApiUrls.ShoppingList, shoppingToken.Token, requestModel);
        }

        public HttpResponse<OkResponse> UpdateShoppingList(string ItemName, ShoppingItem requestModel)
        {
            var updateCustomerUri = string.Format(ApiUrls.ShoppingList, ItemName);
            return new ApiHttpClient().PutRequest<OkResponse>(updateCustomerUri, shoppingToken.Token, requestModel);
        }

        public HttpResponse<OkResponse> DeleteFromShoppingList(string ItemName)
        {
            var deleteCustomerUri = string.Format(ApiUrls.ShoppingList, ItemName);
            return new ApiHttpClient().DeleteRequest<OkResponse>(deleteCustomerUri, shoppingToken.Token);
        }

        public HttpResponse<ShoppingItem> GetShoppingItem(string ItemName)
        {
            var getCustomerUri = string.Format(ApiUrls.ShoppingList, ItemName);
            return new ApiHttpClient().GetRequest<ShoppingItem>(getCustomerUri, shoppingToken.Token);
        }

        public HttpResponse<ShoppingList> GetShoppingList(ShoppingList request)
        {
            var getShoppingListUri = string.Format(ApiUrls.ShoppingList, "all");

            if (request.Limit.HasValue)
            {
                getShoppingListUri = UrlHelper.AddParameterToUrl(getShoppingListUri, "limit", request.Limit.ToString());
            }

            if (request.Offset.HasValue)
            {
                getShoppingListUri = UrlHelper.AddParameterToUrl(getShoppingListUri, "offset", request.Offset.ToString());
            }

            return new ApiHttpClient().GetRequest<ShoppingList>(getShoppingListUri,"Bearer "+shoppingToken.Token);
        }
    }
}
