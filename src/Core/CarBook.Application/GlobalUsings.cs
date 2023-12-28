// Configuration
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;

// Core
global using CarBook.Application.Interfaces;
global using CarBook.Domain.Entities;

// Mediator
global using MediatR;

// About 
global using CarBook.Application.Features.Mediator.Results.AboutResults;
global using CarBook.Application.Features.Mediator.Queries.AboutQueries;

// Banner
global using CarBook.Application.Features.Mediator.Results.BannerResults;
global using CarBook.Application.Features.Mediator.Queries.BannerQueries;
global using CarBook.Application.Features.Mediator.Commands.BannerCommands;

// Feature
global using CarBook.Application.Features.Mediator.Results.FeatureResults;
global using CarBook.Application.Features.Mediator.Queries.FeatureQueries;

// Location
global using CarBook.Application.Features.Mediator.Results.LocationResults;
global using CarBook.Application.Features.Mediator.Queries.LocationQueries;
global using CarBook.Application.Features.Mediator.Commands.LocationCommands;

// Brand
global using CarBook.Application.Features.Mediator.Commands.BrandCommands;
global using CarBook.Application.Features.Mediator.Queries.BrandQueries;
global using CarBook.Application.Features.Mediator.Results.BrandResults;

// Contact
global using CarBook.Application.Features.Mediator.Results.ContactResults;
global using CarBook.Application.Features.Mediator.Queries.ContactQueries;
global using CarBook.Application.Features.Mediator.Commands.ContactCommands;

// Service
global using CarBook.Application.Features.Mediator.Results.ServiceResults;
global using CarBook.Application.Features.Mediator.Queries.ServiceQueries;
global using CarBook.Application.Features.Mediator.Commands.ServiceCommands;

// Testimonial
global using CarBook.Application.Features.Mediator.Results.TestimonialResults;
global using CarBook.Application.Features.Mediator.Queries.TestimonialQueries;
global using CarBook.Application.Features.Mediator.Commands.TestimonialCommands;

// Category
global using CarBook.Application.Features.Mediator.Results.CategoryResults;
global using CarBook.Application.Features.Mediator.Queries.CategoryQueries;
global using CarBook.Application.Features.Mediator.Commands.CategoryCommands;

// FooterAddress
global using CarBook.Application.Features.Mediator.Results.FooterAddressResults;
global using CarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
global using CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;

// SocialMedia
global using CarBook.Application.Features.Mediator.Results.SocialMediaResults;
global using CarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
global using CarBook.Application.Features.Mediator.Commands.SocialMediaCommands;

// Pricing
global using CarBook.Application.Features.Mediator.Results.PricingResults;
global using CarBook.Application.Features.Mediator.Queries.PricingQueries;
global using CarBook.Application.Features.Mediator.Commands.PricingCommands;

// Car
global using CarBook.Application.Features.Mediator.Results.CarResults;
global using CarBook.Application.Features.Mediator.Queries.CarQueries;
global using CarBook.Application.Features.Mediator.Commands.CarCommands;

