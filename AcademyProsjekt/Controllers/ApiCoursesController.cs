﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AcademyProsjekt.Data;
using AcademyProsjekt.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;


namespace AcademyProsjekt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ApiCoursesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ApiCoursesController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET: api/ApiCourses
        [HttpGet]
        public ActionResult GetCourse()
        {
            return new JsonResult (_context.Course
                .Include(course => course.Modules)
                .ThenInclude(module => module.Pages)
                .ToList()
                .Select(course => {
                return new
                {
                    course.Id,
                    course.Title,

                    modules = course.Modules.Select(module =>
                    {
                        return new
                        {
                            module.Id,
                            module.Title,


                             pages = module.Pages.Select(pages =>
                             {
                                 return new
                                 {
                                     pages.Id,
                                     pages.LearningMaterial,
                                     pages.LearningOutcomes
                                  
                                 };
                             })
                        };
                    })
                };
            }));
        }

        // GET: api/ApiCourses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            var course = await _context.Course.FindAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return course;
        }

        // PUT: api/ApiCourses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(int id, Course course)
        {
            if (id != course.Id)
            {
                return BadRequest();
            }

            _context.Entry(course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ApiCourses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {
            _context.Course.Add(course);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }

        // DELETE: api/ApiCourses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var course = await _context.Course.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            _context.Course.Remove(course);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.Id == id);
        }
    }
}
