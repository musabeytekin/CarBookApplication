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
