﻿using BusinessLayer.Abstract;
using BusinessLayer.Abstract.AbstractUow;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.ConcreteUow;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            //About1 Configuration
            services.AddScoped<IAbout1Service, About1Manager>();
            services.AddScoped<IAbout1Dal, EfAbout1Dal>();

            //About2 Configuration
            services.AddScoped<IAbout2Service, About2Manager>();
            services.AddScoped<IAbout2Dal, EfAbout2Dal>();

            //Contact Configuration
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EfContactDal>();

            //Destination Configuration
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();

            //Feature1 Configuration
            services.AddScoped<IFeature1Service, Feature1Manager>();
            services.AddScoped<IFeature1Dal, EfFeature1Dal>();

            //Feature2 Configuration
            services.AddScoped<IFeature2Service, Feature2Manager>();
            services.AddScoped<IFeature2Dal, EfFeature2Dal>();

            //Guide Configuration
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();

            //Newsletter Configuration
            services.AddScoped<INewsletterService, NewsletterManager>();
            services.AddScoped<INewsletterDal, EfNewsletterDal>();

            //SubAbout Configuration
            services.AddScoped<ISubAboutService, SubAboutManager>();
            services.AddScoped<ISubAboutDal, EfSubAboutDal>();

            //Testimonial Configuration
            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();

            //Comment Configuration
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            //Reservation Configuration
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

            //AppUser Configuration
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            //Excel Configuration
            services.AddScoped<IExcelService, ExcelManager>();

            //PDF Configuration
            services.AddScoped<IPdfService, PdfManager>();

            //ContactUs Configuration
            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();

            //Announcement Configuration
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            //Account Configuration
            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();

            //UnitOfWork Configuration
            services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();
        }

        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();
        }
    }
}
