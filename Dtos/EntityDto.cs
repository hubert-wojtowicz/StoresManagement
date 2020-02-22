using StoresManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoresManagement.Dtos
{
    public class EntityDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}