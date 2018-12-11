using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cqrsmediatr.domain.models
{
    public class TodoItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id {get; set;}
        public bool IsCompleted {get; set;}
        public bool Title  {get; set;}
        public bool Description  {get; set;}
    }
}
