
using System;
using System.Collections.Generic;
using System.Text;
using Abp.Runtime.Validation;
using CoreWeb0522.Application.Dto;

namespace CoreWeb0522.PhoneBooks.Dtos
{
    public class GetPersonInput: PagedAndSortedInputDto,IShouldNormalize
    {
        //viewmodel => dto => model


        public  string FilterText { get; set; }


        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
