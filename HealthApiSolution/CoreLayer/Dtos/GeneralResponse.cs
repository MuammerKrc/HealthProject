using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dtos
{
    public class QResponse<TModel>
    {
        public bool IsSuccess { get; set; }
        public TModel Data { get; set; }
        public List<string> Errors { get; set; } = new List<string>();

        public string Message = "";

        public bool ShowError = true;

        public int ErrorStatus = 0;

        public static QResponse<TModel> SuccessResponse(TModel data, string message = "")
        {
            return new QResponse<TModel>() { IsSuccess = true, Data = data, Message = message };
        }

        public static QResponse<NoResponse> SuccessResponse(string message = "")
        {
            return new QResponse<NoResponse>() { IsSuccess = true, Data = new NoResponse(), Message = message };
        }

        public static QResponse<NoResponse> ErrorResponse(string error, bool showError = true, int errorStatus = 500)
        {
            return new QResponse<NoResponse>()
            {
                IsSuccess = false,
                Errors = new List<string>() { error },
                Data = new NoResponse(),
                ErrorStatus = errorStatus,
                ShowError = true,
            };
        }
        public static QResponse<NoResponse> ErrorResponse(List<string> error, bool showError = true, int errorStatus = 500)
        {
            return new QResponse<NoResponse>()
            {
                IsSuccess = false,
                Errors = error,
                Data = new NoResponse(),
                ErrorStatus = errorStatus,
                ShowError = true,
            };
        }
    }

    public class NoResponse
    {

    }
}
