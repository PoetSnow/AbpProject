﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using MyProject.Entities;
using MyProject.IRepositories;
namespace MyProject.EntityFramework.Repositories
{
   public class Mic_ThumbnailSettingsRepository:MyProjectRepositoryBase<Mic_ThumbnailSettings>,IMic_ThumbnailSettingsRepository
    {
        public Mic_ThumbnailSettingsRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider)
        { }
    }
}