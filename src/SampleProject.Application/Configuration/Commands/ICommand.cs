﻿namespace SampleProject.Application.Configuration.Commands
{
    using System;
    using MediatR;

    public interface ICommand : IRequest
    {
        Guid Id { get; }
    }

    public interface ICommand<out TResult> : IRequest<TResult>
    {
        Guid Id { get; }
    }
}