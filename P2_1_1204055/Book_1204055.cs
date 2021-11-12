using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204055
{

    public class Book_1204055: Product_1204055
    {
        protected string pageCount;

        public Book_1204055(string type, string title, string pagecount) : base(type,title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }

            set
            {
                pageCount = value;
            }
        }
    }
}
