using System;

namespace GoodBooks.Data.Models
{
    /// <summary>
    /// Book data entity model.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the unique identifier for the book.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date the review was created on.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the most recent date that the review was updated on.
        /// </summary>
        /// <value></value>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; }
    }
}