using AutoMapper;
using Clean_Architecture.Application.DTOs;
using Clean_Architecture.Application.Interfaces;
using Clean_Architecture.core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Clean_Architecture.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<product> _productRepository;
        private readonly IMapper mapper;

        public ProductController(IRepository<product> productRepo,IMapper mapper)
        {
            _productRepository = productRepo;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            List<product> products = _productRepository.GetAll().Where(p => !p.IsDeleted).ToList();
            return Ok(products);
        }

        [HttpGet("{id}", Name = "GetByID")]
        public IActionResult GetByID(int id)
        {
            product product = _productRepository.Get(id);
            if (product != null && !product.IsDeleted)
            {
                return Ok(product);
            }
            return NoContent();
        }

        [HttpPost]
        public IActionResult AddProduct(addProductDTO newProduct)
        {
            if (ModelState.IsValid)
            {
                product product =this.mapper.Map<product>(newProduct);




                _productRepository.insert(product);
                _productRepository.save();

                return Ok(newProduct);
            }
            return BadRequest(ModelState);
        }
    }
}
