﻿using System;

namespace Cil.Todo.Data.Model
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Guid RowId { get; set; }
    }
}
