using Abp.Domain.Entities.Auditing;
using CoreWeb0522.PhoneBook.PhoneNumbers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreWeb0522.PhoneBook.Persons
{
    /// <summary>
    /// 人员
    /// </summary>
    public class Person : FullAuditedEntity
    {

        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(CoreWeb0522Consts.MaxNameLength)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [EmailAddress]
        [MaxLength(CoreWeb0522Consts.MaxEmailLength)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary> 
        [MaxLength(CoreWeb0522Consts.MaxAddressLength)]
        public string Address { get; set; }


        /// <summary>
        /// 电话号码的导航属性
        /// </summary>
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }

    }
}
