using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace oData
{
    public class NotesController : ODataController
    {
        private List<Note> _dataSource = new List<Note>();

        public NotesController()
        {
            var user = new User() { Name = "nathan.surfus", First = "Nathan", Middle = "Cole", Last = "Surfus" };
            _dataSource.Add(user.CreateNote("First Note", "This is my first note!"));
            _dataSource.Add(user.CreateNote("Second Note", "This is my second note!"));
        }

        [EnableQuery(MaxExpansionDepth = 100)]
        public IActionResult Get()
        {
            return Ok(_dataSource);
        }

        [EnableQuery]
        public IActionResult Get(string key)
        {
            return Ok(_dataSource.FirstOrDefault(c => c.Name == key));
        }   
    }
}
