using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeploymentApp.Data
{
    public class TodoItem
    {
        public string? Title { get; set; }
        public bool IsComplete { get; set; }

        public TodoItem(string title) 
        { 
            Title = title;
            IsComplete = false;
        }
    }
}
