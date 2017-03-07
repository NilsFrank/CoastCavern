using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace CoastCavern
{
    [TableName("Zeit")]
    [PrimaryKey("Id", autoIncrement = true)]
    public class TimeDB
    {
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int Id { get; set; }

        public string Day { get; set; }

        public string TimeFrom { get; set; }

        public string TimeTo { get; set; }
    }
}