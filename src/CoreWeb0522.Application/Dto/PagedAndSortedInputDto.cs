using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWeb0522.Application.Dto
{
    public class PagedAndSortedInputDto : IPagedResultRequest, ISortedResultRequest
    {
        public string Sorting { get; set; }

        public int SkipCount { get; set; }


        public int MaxResultCount { get; set; }
    }
}
