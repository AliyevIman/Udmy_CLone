namespace Entites
{
    public class CourseSpecifaction
    {
        public int Id { get; set; }
        public int CourseId     { get; set; }
        public int SpecifctionId { get; set; }
        public virtual Specifaction Specifaction { get; set; }
    }
}
