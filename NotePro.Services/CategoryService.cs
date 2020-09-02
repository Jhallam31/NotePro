using NotePro.Data;
using NotePro.Models.Category;
using NotePro.WebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePro.Services
{
    public class CategoryService
    {
        public bool CreateCategory(CategoryCreate model)
        {
            var entity =
                new Category()
                {
                    Name = model.Name
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Categories.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CategoryListItem> GetCategories()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Categories
                    .Where(e => e.CategoryId == e.CategoryId)
                    .Select(
                        e =>
                        new
                        CategoryListItem
                        {
                            CategoryId = e.CategoryId,
                            Name = e.Name,
                            NoteCount = e.Notes.Count()
                        }
                        );
                return query.ToArray();
            }
        }

        public CategoryDetail GetCategoryById(string id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Categories
                    .Single(e => e.CategoryId == id);
                return
                    new CategoryDetail
                    {
                        CategoryId = entity.CategoryId,
                        Name = entity.Name,
                        Notes = entity.Notes.ToList(),
                        NoteCount = entity.Notes.Count()

                    };

            }
        }

        public bool UpdateCategory(CategoryEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Categories
                    .Single(e => e.CategoryId == e.CategoryId);

                entity.Name = model.Name;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCategory(int Id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Categories
                    .Single(e => e.CategoryId == e.CategoryId);

                ctx.Categories.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
    

