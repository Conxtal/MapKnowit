﻿using Microsoft.EntityFrameworkCore;
            {
                entity.Property(e => e.CompanyID)

                entity.Property(e => e.DivisionId);
                entity.HasKey(e => e.CompanyID);
                

            });
        }