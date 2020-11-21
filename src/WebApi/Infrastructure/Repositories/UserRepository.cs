using AutoMapper;
using Domain.Models;
using Infrastructure.Entities;
using System;

namespace Infrastructure.Repositories
{
    public sealed class UserRepository : GenericRepository<UserModel, User>
    {
        private readonly MyDbContext _context;

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        public UserRepository(MyDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
