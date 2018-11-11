using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oData
{
    public class User
    {
        /// <summary>
        /// The unique name of the <see cref="User"/>.
        /// </summary>
        [Key] public string Name { get; set; }

        /// <summary>
        /// The <see cref="User"/>'s first name.
        /// </summary>
        public string First { get; set; }

        /// <summary>
        /// The <see cref="User"/>'s middle name.
        /// </summary>
        public string Middle { get; set; }

        /// <summary>
        /// The <see cref="User"/>'s last name.
        /// </summary>
        public string Last { get; set; }

        /// <summary>
        /// The <see cref="User"/>'s notes.
        /// </summary>
        public List<Note> Notes { get; } = new List<Note>();

        /// <summary>
        /// Creates a <see cref="Note"/> for this <see cref="User"/>.
        /// </summary>
        /// <returns>The created <see cref="Note"/></returns>
        public Note CreateNote(string name, string contents)
        {
            var note = new Note { Name = name, Contents = contents, User = this };
            Notes.Add(note);
            return note;
        }
    }
}
