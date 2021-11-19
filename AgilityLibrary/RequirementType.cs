using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.DomainModel
{
    public static class RequirementType
    {
        public enum TypeEnum : int
        {
            FEATURE = 1, 
            BUG_FIX = 2, 
            NON_FUNCTIONAL = 3
        }

		public static Dictionary<string, TypeEnum> DesToType = new Dictionary<string, TypeEnum>
		{
			{ "feature", TypeEnum.FEATURE},
			{ "bug fix", TypeEnum.BUG_FIX},
			{ "non-functional", TypeEnum.NON_FUNCTIONAL}
		};

		public static Dictionary<TypeEnum, string> TypeToDesc = new Dictionary<TypeEnum, string>
		{
			{ TypeEnum.FEATURE, "feature"},
			{ TypeEnum.BUG_FIX, "bug fix"},
			{ TypeEnum.NON_FUNCTIONAL, "non-functional"}
		};
	}
    
}
