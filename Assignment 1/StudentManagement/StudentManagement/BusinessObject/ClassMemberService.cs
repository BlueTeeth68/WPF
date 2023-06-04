using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Repository;
using DataAccess.Repository.Impl;

namespace BusinessObject
{

    public class ClassMemberService
    {
        private IClassMemberRepository _classMemberRepository;

        public ClassMemberService()
        {
            this._classMemberRepository = new ClassMemberRepositoryImpl();
        }

        public List<ClassMember> GetStudentList()
        {
            return _classMemberRepository.FindByRole("student");
        }

        public List<ClassMember> GetTeacherList()
        {
            return _classMemberRepository.FindByRole("teacher");
        }

        public List<ClassMember> GetClassMemberByRoleAndName(String role, String name)
        {
            if (String.IsNullOrEmpty(role) || String.IsNullOrEmpty(name))
            {
                return null;
            }
            return _classMemberRepository.FindByRoleAndName(role, name);
        }

        public List<ClassMember> GetMemberByRole(String role)
        {
            if (String.IsNullOrEmpty(role))
            {
                return null;
            }
            else
            {
                return _classMemberRepository.FindByRole(role);
            }
        }

        public void UpdateMember(ClassMember input)
        {
            _classMemberRepository.Update(input);
        }

        public (bool status, string message) AddNew(ClassMember input)
        {

            if (String.IsNullOrEmpty(input.MemberId))
            {
                return (false, "Id is null");
            }
            else if (String.IsNullOrEmpty(input.FirstName))
            {
                return (false, "First name is null");
            }
            else if (String.IsNullOrEmpty(input.LastName))
            {
                return (false, "Last name is null");
            }
            else if (input.DateOfBirth == null)
            {
                return (false, "Invalid date of birth");
            }
            else if (_classMemberRepository.ExistById(input.MemberId))
            {

                return (false, "Id has been existed.");

            }
            else
            {
                _classMemberRepository.Insert(input);
                return (true, "OK");
            }
        }

        public void DeleteMember(String id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                _classMemberRepository.Delete(id);
            }
        }
    }
}
