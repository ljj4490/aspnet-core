using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using CoreWeb0522.PhoneBook.Persons;
using CoreWeb0522.PhoneBooks.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CoreWeb0522.PhoneBooks
{
    public class PersonAppService : CoreWeb0522AppServiceBase, IPersonAppService
    {
        /// <summary>
        /// 依赖注入
        /// </summary>
        private readonly IRepository<Person> _personRepository;


        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var query = _personRepository.GetAll();

            var personCount = await query.CountAsync();
            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();


            //老方法
            //--------------begin
            //var listDto = new List<PersonListDto>();
            //foreach (var person in persons)
            //{
            //    var dto = new PersonListDto();
            //    dto.EmailAddress = person.EmailAddress;
            //}
            //----------------end

            //abp封装方法
            var dtos = persons.MapTo<List<PersonListDto>>();
            return new PagedResultDto<PersonListDto>(personCount, dtos);


            throw new NotImplementedException();
        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id);
            if (entity == null)
            {
                throw new UserFriendlyException("该联系人已经删除，无法进行二次删除");

            }

            await _personRepository.DeleteAsync(input.Id);
        }

        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input)
        {

            var person = await _personRepository.GetAsync(input.Id.Value);

            return person.MapTo<PersonListDto>();

        }

        public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {

            if (input.PersonEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);

            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }



        }


        protected async Task CreatePersonAsync(PersonEditDto input)
        {
           await  _personRepository.InsertAsync(input.MapTo<Person>());

        }
        protected async Task UpdatePersonAsync(PersonEditDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id.Value);
            await _personRepository.UpdateAsync(input.MapTo(entity));

        }






    }
}
