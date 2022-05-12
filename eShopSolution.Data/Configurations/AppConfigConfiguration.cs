﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            //Cau hinh cho bang
            builder.ToTable("AppConfig");

            builder.HasKey(x => x.Key);


            //Bat phai nhap
            builder.Property(x => x.Value).IsRequired(true);

        }
    }
}