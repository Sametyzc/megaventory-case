
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using project.Dto;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace project.Services
{
    public interface ICreateService
    {
        GeneralResponse CreateTax(TaxDto.MvTax mvTax);
        GeneralResponse CreateDiscount(DiscountDto.MvDiscount mvDiscount);
        GeneralResponse CreateInventoryLocation(InventoryLocationDto.MvInventoryLocation mvInventoryLocation);
        GeneralResponse CreateProduct(ProductDto.MvProduct mvProduct);
        GeneralResponse CreateSupplierClient(SupplierClientDto.MvSupplierClient mvSupplierClient);
        GeneralResponse CreateSalesOrder(SalesOrderDto.MvSalesOrder mvSalesOrder);
    }

    public class CreateService : ICreateService
    {
        HttpClient _httpClient;
        ApiSettings _apiSettings;
        public CreateService(IOptions<ApiSettings> options)
        {
            _httpClient = new HttpClient();
            _apiSettings = options.Value;
        }

        #region Private Functions

        private GeneralResponse Request(object data, string requestURI, HttpMethod method)
        {
            string contentSerialized = string.Empty;
            StringContent content = new StringContent("");
            GeneralResponse response = new GeneralResponse();

            Task<HttpResponseMessage> result = null;
            if (data != null)
            {
                content = new StringContent(
                        JsonConvert.SerializeObject(data),
                        Encoding.UTF8, "application/json"
                );
            }

            switch (method)
            {
                case HttpMethod m when m == HttpMethod.Post:
                    result = _httpClient.PostAsync(requestURI, content);
                    break;
                case HttpMethod m when m == HttpMethod.Get:
                    result = _httpClient.GetAsync(requestURI);
                    break;
                case HttpMethod m when m == HttpMethod.Put:
                    result = _httpClient.PutAsync(requestURI, content);
                    break;
                case HttpMethod m when m == HttpMethod.Delete:
                    result = _httpClient.DeleteAsync(requestURI);
                    break;
                default:
                    break;
            }

            try
            {
                Task<string> responseResultValue = result.Result.Content.ReadAsStringAsync();

                response.Code = result.Result.StatusCode;

                if (response.Code != HttpStatusCode.OK)
                {
                    return response;
                }

                response.Data = responseResultValue.Result;
                return response;
            }
            catch(Exception ex)
            {
                return new GeneralResponse();
            }
        }

        #endregion

        public GeneralResponse CreateTax(TaxDto.MvTax mvTax)
        {
            try
            {
                TaxDto.Create data = new TaxDto.Create()
                {
                    APIKEY = _apiSettings.ApiKey,
                    mvTax = mvTax,
                    mvRecordAction = "Insert"
                };

                GeneralResponse response = Request(data, $"{_apiSettings.BaseUrl}/Tax/TaxUpdate", HttpMethod.Post);
                return response;
            }
            catch (Exception exp)
            {
                //log exp
                return new GeneralResponse();
            }
        }

        public GeneralResponse CreateDiscount(DiscountDto.MvDiscount mvDiscount)
        {
            try
            {
                DiscountDto.Create data = new DiscountDto.Create()
                {
                    APIKEY = _apiSettings.ApiKey,
                    mvDiscount = mvDiscount,
                    mvRecordAction = "Insert"
                };

                GeneralResponse response = Request(data, $"{_apiSettings.BaseUrl}/Discount/DiscountUpdate", HttpMethod.Post);
                return response;
            }
            catch (Exception exp)
            {
                //log exp
                return new GeneralResponse();
            }
        }

        public GeneralResponse CreateInventoryLocation(InventoryLocationDto.MvInventoryLocation mvInventoryLocation)
        {
            try
            {
                InventoryLocationDto.Create data = new InventoryLocationDto.Create()
                {
                    APIKEY = _apiSettings.ApiKey,
                    mvInventoryLocation = mvInventoryLocation,
                    mvRecordAction = "Insert"
                };

                GeneralResponse response = Request(data, $"{_apiSettings.BaseUrl}/InventoryLocation/InventoryLocationUpdate", HttpMethod.Post);
                return response;
            }
            catch (Exception exp)
            {
                //log exp
                return new GeneralResponse();
            }
        }

        public GeneralResponse CreateProduct(ProductDto.MvProduct mvProduct)
        {
            try
            {
                ProductDto.Create data = new ProductDto.Create()
                {
                    APIKEY = _apiSettings.ApiKey,
                    mvProduct = mvProduct,
                    mvRecordAction = "Insert"
                };

                GeneralResponse response = Request(data, $"{_apiSettings.BaseUrl}/Product/ProductUpdate", HttpMethod.Post);
                return response;
            }
            catch (Exception exp)
            {
                //log exp
                return new GeneralResponse();
            }
        }

        public GeneralResponse CreateSupplierClient(SupplierClientDto.MvSupplierClient mvSupplierClient)
        {
            try
            {
                SupplierClientDto.Create data = new SupplierClientDto.Create()
                {
                    APIKEY = _apiSettings.ApiKey,
                    mvSupplierClient = mvSupplierClient,
                    mvRecordAction = "Insert"
                };

                GeneralResponse response = Request(data, $"{_apiSettings.BaseUrl}/SupplierClient/SupplierClientUpdate", HttpMethod.Post);
                return response;
            }
            catch (Exception exp)
            {
                //log exp
                return new GeneralResponse();
            }
        }

        public GeneralResponse CreateSalesOrder(SalesOrderDto.MvSalesOrder mvSalesOrder)
        {
            try
            {
                SalesOrderDto.Create data = new SalesOrderDto.Create()
                {
                    APIKEY = _apiSettings.ApiKey,
                    mvSalesOrder = mvSalesOrder,
                    mvRecordAction = "Insert"
                };

                GeneralResponse response = Request(data, $"{_apiSettings.BaseUrl}/SalesOrder/SalesOrderUpdate", HttpMethod.Post);
                return response;
            }
            catch (Exception exp)
            {
                //log exp
                return new GeneralResponse();
            }
        }
    }
}
