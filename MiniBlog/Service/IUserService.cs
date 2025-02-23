﻿using MiniBlog.Model;
using System.Collections.Generic;

namespace MiniBlog.Service
{
    public interface IUserService
    {
        List<User> GetAll();

        User Register(User user);

        User Update(User user);

        User Delete(string name);

        User GetByName(string name);
    }
}