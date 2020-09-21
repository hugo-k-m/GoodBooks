using System;

namespace GoodBooks.Data.Models
{
    /// <summary>
    /// Book data entity model.
    /// </summary>
    public class BookReview
    {
        /// <summary>
        /// Gets or sets the unique identifier for the book review.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date the review was created on.
        /// </summary>
        public DateTime CreateOn { get; set; }

        /// <summary>
        /// Gets or sets the most recent date that the review was updated on.
        /// </summary>
        /// <value></value>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the review author for the book.
        /// </summary>
        public string ReviewAuthor { get; set; }

        /// <summary>
        /// Gets or sets the review content for the book.
        /// </summary>
        public string ReviewContent { get; set; }

        /// <summary>
        /// Gets or sets the book associated with the review.
        /// </summary>
        public virtual Book Book { get; set; }
    }
}