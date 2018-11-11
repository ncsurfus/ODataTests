using System.ComponentModel.DataAnnotations;

namespace oData
{
    public class Note
    {
        /// <summary>
        /// The name of the <see cref="Note"/>
        /// </summary>
        [Key] public string Name { get; set; }

        /// <summary>
        /// The contents of the <see cref="Note"/>.
        /// </summary>
        public string Contents { get; set; }

        /// <summary>
        /// The <see cref="User"/> that owns this <see cref="Note"/>.
        /// </summary>
        public User User { get; set; }
    }
}
