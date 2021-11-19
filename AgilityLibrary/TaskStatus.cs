using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.DomainModel
{
    public static class TaskStatus
    {
        public enum StatusEnum
        {
            TO_DO,
            IN_PROGRESS,
            STUCK,
            DONE
        }
    }
}
