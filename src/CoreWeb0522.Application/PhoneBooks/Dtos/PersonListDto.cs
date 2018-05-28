using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using CoreWeb0522.PhoneBook.Persons;
using CoreWeb0522.PhoneBook.PhoneNumbers;

namespace CoreWeb0522.PhoneBooks.Dtos
{
    [AutoMapFrom(typeof(Person))] 

    public class PersonListDto: FullAuditedEntityDto
    {


        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [EmailAddress]
        [MaxLength(80)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary> 
        [MaxLength(200)]
        public string Address { get; set; }

         

    }
}