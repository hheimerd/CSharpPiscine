using d01_ex01.Tasks;

namespace d01_ex01.Events
{
    public record CreatedEvent : Event
    {
        public CreatedEvent() : base(TaskState.New)
        {
            
        }
    }
}