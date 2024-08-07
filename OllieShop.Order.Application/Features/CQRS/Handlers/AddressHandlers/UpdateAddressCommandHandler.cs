﻿using OllieShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using OllieShop.Order.Application.Interfaces;
using OllieShop.Order.Domain.Entities;

namespace OllieShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;
        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddressCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AddressId);
            values.UserId = command.UserId;
            values.Name = command.Name;
            values.Surname = command.Surname;
            values.City = command.City;
            values.Country = command.Country;
            values.ZipCode = command.ZipCode;
            values.PhoneNumber = command.PhoneNumber;
            values.Email = command.Email;
            values.Description = command.Description;
            await _repository.UpdateAsync(values);
        }

    }
}
