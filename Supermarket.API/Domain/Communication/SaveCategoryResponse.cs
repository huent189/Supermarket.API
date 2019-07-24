using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Communication
{
    public class SaveCategoryResponse : BaseResponse
    {
        public Category Category { get; private set; }
        private SaveCategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }

        public SaveCategoryResponse(Category category) : this(true, String.Empty, category)
        {
            
        }

        public SaveCategoryResponse(String message) : this(false, message, null)
        {

        }
    }
}
