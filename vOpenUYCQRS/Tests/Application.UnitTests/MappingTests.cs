using AutoMapper;
using vOpenUYCQRS.Application.Categories.Queries.GetCategoriesList;
using vOpenUYCQRS.Application.Customers.Queries.GetCustomerDetail;
using vOpenUYCQRS.Application.Customers.Queries.GetCustomersList;
//using vOpenUYCQRS.Application.Products.Queries.GetProductsList;
//using vOpenUYCQRS.Application.Products.Queries.GetProductDetail;
//using vOpenUYCQRS.Application.Products.Queries.GetProductsFile;
using vOpenUYCQRS.Domain.Entities;
using Shouldly;
using Xunit;

namespace vOpenUYCQRS.Application.UnitTests
{
    public class MappingTests : IClassFixture<MappingTestsFixture>
    {
        private readonly IConfigurationProvider _configuration;
        private readonly IMapper _mapper;

        public MappingTests(MappingTestsFixture fixture)
        {
            _configuration = fixture.ConfigurationProvider;
            _mapper = fixture.Mapper;
        }

        [Fact]
        public void ShouldHaveValidConfiguration()
        {
            _configuration.AssertConfigurationIsValid();
        }

        [Fact]
        public void ShouldMapCategoryToCategoryLookupDto()
        {
            var entity = new Category();

            var result = _mapper.Map<CategoryLookupDto>(entity);

            result.ShouldNotBeNull();
            result.ShouldBeOfType<CategoryLookupDto>();
        }

        [Fact]
        public void ShouldMapCustomerToCustomerLookupDto()
        {
            var entity = new Customer();

            var result = _mapper.Map<CustomerLookupDto>(entity);

            result.ShouldNotBeNull();
            result.ShouldBeOfType<CustomerLookupDto>();
        }

        //[Fact]
        //public void ShouldMapProductToProductDetailVm()
        //{
        //    var entity = new Product();

        //    var result = _mapper.Map<ProductDetailVm>(entity);

        //    result.ShouldNotBeNull();
        //    result.ShouldBeOfType<ProductDetailVm>();
        //}

        //[Fact]
        //public void ShouldMapProductToProductDto()
        //{
        //    var entity = new Product();

        //    var result = _mapper.Map<ProductDto>(entity);

        //    result.ShouldNotBeNull();
        //    result.ShouldBeOfType<ProductDto>();
        //}

        //[Fact]
        //public void ShouldMapProductToProductRecordDto()
        //{
        //    var entity = new Product();

        //    var result = _mapper.Map<ProductRecordDto>(entity);

        //    result.ShouldNotBeNull();
        //    result.ShouldBeOfType<ProductRecordDto>();
        //}

        [Fact]
        public void ShouldMapCustomerToCustomerDetailVm()
        {
            var entity = new Customer();

            var result = _mapper.Map<CustomerDetailVm>(entity);

            result.ShouldNotBeNull();
            result.ShouldBeOfType<CustomerDetailVm>();
        }
    }
}
