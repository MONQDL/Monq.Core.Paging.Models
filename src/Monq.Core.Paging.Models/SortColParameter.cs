
namespace Monq.Core.Paging.Models
{
    /// <summary>
    /// Model of describing a sort.
    /// </summary>
    public class SortColParameter
    {
        /// <summary>
        /// Name of Column for sorting.
        /// </summary>
        public string ColName { get; set; } = string.Empty;

        /// <summary>
        /// Direction of sorting.
        /// </summary>
        public string? Dir { get; set; }
    }
}
