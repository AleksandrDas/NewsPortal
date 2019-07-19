namespace NewsPortal.Logic.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int TopicId { get; set; }

        [Required]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        public DateTime AddDate { get; set; }

        public virtual Topic Topic { get; set; }
    }
}
