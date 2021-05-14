using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class UserPhoto:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string  ImagePath { get; set; }
    }
}
