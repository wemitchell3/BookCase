using BookCase.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCase.ViewComponents
{
    public class OtherBooksByAuthorViewComponent : ViewComponent
    {
        // NOTE: This view component "code-behind" is kinda like the cross between a controller and a razor page code-behind.
        // The razor view for this component is located in Views/Shared/Components/OtherBooksByAuthor/Default.cshtml
        private readonly ApplicationDbContext _context;

        // NOTE: Using dependency injection to get the Application DB Context
        public OtherBooksByAuthorViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        // NOTE: This method is run when the view component is rendered (aka. "invoked")
        //       You can specify any parameters you want, 
        //         as long as you have access to the data when you invoke the view component
        public async Task<IViewComponentResult> InvokeAsync(int authorId, int excludeBookId)
        {
            var otherBooks = await _context.Book
                .Where(b => b.AuthorId == authorId && b.Id != excludeBookId)
                .ToListAsync();

            // NOTE: The razor view is configured to accept an IEnumerable<Book>
            return View(otherBooks);
        }
    }
}
