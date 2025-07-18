﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(value);
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount() 
        {
            return Ok(_categoryService.TCategoryCount());
        }

        [HttpGet("ActivateCategoryCount")]
        public IActionResult ActivateCategoryCount()
        {
            return Ok(_categoryService.TActivateCategoryCount());
        }

        [HttpGet("TDeactivateCategoryCount")]
        public IActionResult TDeactivateCategoryCount()
        {
            return Ok(_categoryService.TDeactivateCategoryCount());
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            createCategoryDto.Status = true;
            var value = _mapper.Map<Category>(createCategoryDto);
            _categoryService.Tadd(value);
            return Ok("Kategori Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return Ok("Kategori Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult updateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);   
            _categoryService.Tupdate(value);
            return Ok("Kategori güncellendi");
        }
    }
}
