using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Text;

namespace SportClubStart.Models
{
    internal class DB
    {
        public class Attendances
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public int SportsmanId { get; set; }
            public int CoachId { get; set; }
            public DateTime TrainingDate { get; set; }
            public bool Attended { get; set; } //1 был 0 нет()))))))))))))
        }

        public class Sportsmen
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [MaxLength(100)]
            public string FullName { get; set; } = string.Empty; // string потому что nvarchar command.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = myString;
            public DateTime Birthday { get; set; }
            public string ParentPhone { get; set; }
        }

        public class Coaches
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [MaxLength(100)]
            public string FullName { get; set; }
            public string SportType { get; set; }
            public override string ToString() => FullName;
        }
    }
}