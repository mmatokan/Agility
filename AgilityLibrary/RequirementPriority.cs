using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.DomainModel
{
    public static class RequirementPriority
    {
		public enum PriorityEnum : int
		{
			HIGH = 1,
			MEDIUM = 2,
			LOW = 3
		};

		public static Dictionary<string, PriorityEnum> DesToPrority = new Dictionary<string, PriorityEnum>
		{
			{ "high", PriorityEnum.HIGH},
			{ "medium", PriorityEnum.MEDIUM},
			{ "low", PriorityEnum.LOW}
		};

		public static Dictionary<PriorityEnum, string> PriorityToDesc = new Dictionary<PriorityEnum, string>
		{
			{ PriorityEnum.HIGH, "high"},
			{ PriorityEnum.MEDIUM, "medium"},
			{ PriorityEnum.LOW, "low"}
		};
	}
}
