using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Data.SqlTypes;
using TigrisTech.Shared.Entities.Concrete;

namespace TigrisTecH.MvcUI.Filters
{
    public class MvcExceptionFilter : IExceptionFilter
    {
        private readonly IHostEnvironment _enviroment;
        private readonly IModelMetadataProvider _metadataProvider;
        private readonly ILogger _logger;
        public MvcExceptionFilter(IModelMetadataProvider metadataProvider,
            IHostEnvironment enviroment,
            ILogger<MvcExceptionFilter> logger)
        {
            _metadataProvider = metadataProvider;
            _enviroment = enviroment;
            _logger = logger;
        }
        public void OnException(ExceptionContext context)
        {
            if (_enviroment.IsDevelopment())
            {
                context.ExceptionHandled = true;
                var mvcErrorModel = new MvcErrorModel();
                ViewResult result;
                switch (context.Exception)
                {
                    case SqlNullValueException:
                        mvcErrorModel.Message =$"500";
                        mvcErrorModel.Detail = context.Exception.Message;
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 500;
                        _logger.LogError(context.Exception, context.Exception.Message);
                        break;
                    case NullReferenceException:
                        mvcErrorModel.Message = $"403";
                        mvcErrorModel.Detail = context.Exception.Message;
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 403;
                        _logger.LogError(context.Exception, context.Exception.Message);
                        break;
                    default:
                        mvcErrorModel.Message =$"404";
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 404;
                        _logger.LogError(context.Exception, "Bu benim log hata mesajım!");
                        break;
                }
                result.ViewData = new ViewDataDictionary(_metadataProvider,context.ModelState);
                result.ViewData.Add("MvcErrorModel", mvcErrorModel);
                context.Result = result;
            }
        }
    }
}
