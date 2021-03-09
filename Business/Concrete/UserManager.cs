﻿using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constans;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        
        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.NewUserAdded);
        }

        
        public IDataResult<User>GetByMail(string email)
        {
            return new SuccessDataResult<User>( _userDal.Get(u => u.Email == email));
        }

        
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<UserClaimForUserInfoDto>> GetUserDetail()
        {
            return new SuccessDataResult<List<UserClaimForUserInfoDto>>(_userDal.UserDetail());
        }
    }
}
