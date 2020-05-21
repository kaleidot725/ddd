﻿using System;
namespace ddd.ApplicationService
{
    class UserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository) {
            this.userRepository = userRepository;
        }

        public bool Exists(User user)
        {
            return userRepository.Exists(user);
        }
    }
}
