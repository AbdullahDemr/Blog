using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TigrisTech.Services.Utilities.Tools
{
    public static class ResponseTools
    {
        public static ResponseModel GetSuccess()
        {
            ResponseModel responseModel = new ResponseModel();

            responseModel.IsSuccess = true;
            responseModel.Code = HttpStatusCode.OK;

            return responseModel;
        }

        public static ResponseModel GetSuccess(object data)
        {
            ResponseModel responseModel = new ResponseModel();

            responseModel.IsSuccess = true;
            responseModel.Code = HttpStatusCode.OK;
            responseModel.Data = data;

            return responseModel;
        }

        public static ResponseModel GetError(string errorMessage)
        {
            ResponseModel responseModel = new ResponseModel();

            responseModel.IsSuccess = false;
            responseModel.Code = HttpStatusCode.InternalServerError;
            responseModel.ErrorMessage = errorMessage;

            return responseModel;
        }

        public static ResponseModel GetError(string errorMessage, object data)
        {
            ResponseModel responseModel = new ResponseModel();

            responseModel.IsSuccess = false;
            responseModel.Code = HttpStatusCode.InternalServerError;
            responseModel.ErrorMessage = errorMessage;
            responseModel.Data = data;

            return responseModel;
        }
    }
}
