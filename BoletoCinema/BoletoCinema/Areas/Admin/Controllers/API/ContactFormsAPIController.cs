using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoletoCinema.Areas.Admin.Data;
using BoletoCinema.Areas.Admin.Models;

namespace BoletoCinema.Areas.Admin.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactFormsAPIController : ControllerBase
    {
        private readonly BoletoContext _context;

        public ContactFormsAPIController(BoletoContext context)
        {
            _context = context;
        }

        // GET: api/ContactFormsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactForm>>> GetcontactForms()
        {
            return await _context.contactForms.ToListAsync();
        }

        // GET: api/ContactFormsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactForm>> GetContactForm(int id)
        {
            var contactForm = await _context.contactForms.FindAsync(id);

            if (contactForm == null)
            {
                return NotFound();
            }

            return contactForm;
        }

        // PUT: api/ContactFormsAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactForm(int id, ContactForm contactForm)
        {
            if (id != contactForm.id)
            {
                return BadRequest();
            }

            _context.Entry(contactForm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactFormExists(id))
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

        // POST: api/ContactFormsAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContactForm>> PostContactForm(ContactForm contactForm)
        {
            _context.contactForms.Add(contactForm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactForm", new { id = contactForm.id }, contactForm);
        }

        // DELETE: api/ContactFormsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactForm(int id)
        {
            var contactForm = await _context.contactForms.FindAsync(id);
            if (contactForm == null)
            {
                return NotFound();
            }

            _context.contactForms.Remove(contactForm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactFormExists(int id)
        {
            return _context.contactForms.Any(e => e.id == id);
        }
    }
}
