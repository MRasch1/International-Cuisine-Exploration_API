using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Repositories
{
    public class ReviewRepo : IReviewRepo
    {
        private readonly DataContext context;
        public ReviewRepo(DataContext data)
        {
            this.context = data;
        }

        public Review Create(Review column)
        {
            // Context is our Database
            context.Reviews.Add(column);
            context.SaveChanges();
            return column;
        }

        public List<Review> GetAll()
        {
            return context.Reviews.ToList();
        }

        public Review UpdateById(int id, Review updatedColumn)
        {
            var column = context.Reviews.FirstOrDefault(c => c.ReviewId == id);

            if (column != null)
            {
                column.Rating = updatedColumn.Rating;
                column.Comment = updatedColumn.Comment;
                column.UserId = updatedColumn.UserId;
                column.RecipeId = updatedColumn.RecipeId;

                context.SaveChanges();
            }

            return column;
        }

        public Review DeleteById(int id)
        {
            var column = context.Reviews.FirstOrDefault(c => c.ReviewId == id);

            if (column != null)
            {
                context.Reviews.Remove(column);
                context.SaveChanges();
            }
            return column;
        }
    }
}
