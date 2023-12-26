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

// global using CarBook.Application.Features.CQRS.Commands.BannerCommands;
// global using CarBook.Application.Features.CQRS.Queries.BannerQueries;
// global using CarBook.Application.Features.CQRS.Results.BannerResults;

// Feature
global using CarBook.Application.Features.Mediator.Results.FeatureResults;
global using CarBook.Application.Features.Mediator.Queries.FeatureQueries;

