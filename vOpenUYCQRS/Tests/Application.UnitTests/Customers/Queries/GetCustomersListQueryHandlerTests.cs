﻿using AutoMapper;
using vOpenUYCQRS.Application.Customers.Queries.GetCustomersList;
using vOpenUYCQRS.Application.UnitTests.Common;
using vOpenUYCQRS.Persistence;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace NorthwindTraders.Application.UnitTests.Infrastructure
{
    [Collection("QueryCollection")]
    public class GetCustomersListQueryHandlerTests
    {
        private readonly NorthwindDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomersListQueryHandlerTests(QueryTestFixture fixture)
        {
            _context = fixture.Context;
            _mapper = fixture.Mapper;
        }

        [Fact]
        public async Task GetCustomersTest()
        {
            var sut = new GetCustomersListQueryHandler(_context, _mapper);

            var result = await sut.Handle(new GetCustomersListQuery(), CancellationToken.None);

            result.ShouldBeOfType<CustomersListVm>();

            result.Customers.Count.ShouldBe(3);
        }
    }
}