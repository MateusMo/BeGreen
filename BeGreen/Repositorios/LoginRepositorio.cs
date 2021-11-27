﻿using BeGreen.Context;
using BeGreen.InterfaceRepositorio;
using BeGreen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Repositorios
{
    public class LoginRepositorio : RepositorioBase<Login>, ILoginRepositorio
    {
        private readonly DbSet<Login> _login;

        public LoginRepositorio(ContextBase db) : base(db)
        {
            _login = db.Set<Login>();
        }


    }
}