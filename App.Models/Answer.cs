using App.Utils.Serializable;

namespace App.Models
{
    public class AnswerPagedList<T>
    {
        public bool IsSuccess { get; }
        public string Message { get; }
        public List<T> Items { get; }

        public int IndexFrom { get; }
        public int PageIndex { get; }
        public int PageSize { get; }
        public int TotalCount { get; }
        public int TotalPages { get; }
        public bool HasPreviousPage { get; }
        public bool HasNextPage { get; }

        public AnswerPagedList(bool isSuccess, string message, List<T> data, int indexFrom = 0, int pageIndex = 0, int pageSize = 0, int totalCount = 0, int totalPages = 0, bool hasPreviousPage = false, bool hasNextPage = false)
        {
            IsSuccess = isSuccess;
            Message = message;
            Items = data;

            IndexFrom = indexFrom;
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
            TotalPages = totalPages;
            HasPreviousPage = hasPreviousPage;
            HasNextPage = hasNextPage;
        }
    }

    public class Answer<T>
    {
        public bool IsSuccess { get; }
        public string Message { get; }
        public T Data { get; }
        public Answer(bool IsSuccess, string Message, T Data)
        {
            this.IsSuccess = IsSuccess;
            this.Message = Message;
            this.Data = Data;
        }

        public static string Create(bool IsSuccess, string Message, T Data)
        {
            var res = new Answer<T>(IsSuccess, Message, Data);
            return res.ToJson();
        }
    }

    public class AnswerBasic
    {
        public bool IsSuccess { get; }
        public string Message { get; }
        public AnswerBasic(bool IsSuccess, string Message)
        {
            this.IsSuccess = IsSuccess;
            this.Message = Message;
        }

        public static string Create(bool IsSuccess, string Message)
        {
            var res = new AnswerBasic(IsSuccess, Message);
            return res.ToJson();
        }
    }

    public class AnswerSignalResponse
    {
        public bool IsSuccess { get; }
        public string Message { get; }
        public string Cmd { get; }
        public AnswerSignalResponse(bool isSuccess, string message, string cmd)
        {
            IsSuccess = isSuccess;
            Message = message;
            Cmd = cmd;
        }

        public static string Create(bool isSuccess, string message, string cmd)
        {
            var res = new AnswerSignalResponse(isSuccess, message, cmd);
            return res.ToJson();
        }
    }

}
