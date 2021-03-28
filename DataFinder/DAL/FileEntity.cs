﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataFinder.DAL
{
    class FileEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public FileEntity(Guid id, string name, string path)
        {
            this.Id = id;
            this.Name = name;
            this.Path = path;
        }
    }
}
