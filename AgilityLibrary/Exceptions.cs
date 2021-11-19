using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.DomainModel
{
	[Serializable]
	public class UserLoginException : Exception
	{
		public UserLoginException(string details)
			: base("Login error! " + details)
        {

        }
	}

	[Serializable]
	public class EmptyLoginFieldException : UserLoginException
	{
		public EmptyLoginFieldException(string field)
			: base(field + " field is empty.")
        {

        }
	}

	[Serializable]
	public class NoSuchUserException : UserLoginException
	{
		public NoSuchUserException(string user)
			: base("User " + user + " not found.")
		{

		}
	}

	[Serializable]
	public class UserSignUpException : Exception
	{
		public UserSignUpException(string details)
			: base("Sign up error! " + details)
		{

		}
	}

	[Serializable]
	public class EmptySignUpFieldException : UserSignUpException
	{
		public EmptySignUpFieldException(string field)
			: base(field + " field is empty.")
		{

		}
	}

	[Serializable]
	public class UserExistsException : UserSignUpException
	{
		public UserExistsException(string email)
			: base("User with email " + email + " already exists.")
		{

		}
	}

	[Serializable]
	public class InvalidEmailAddressException : UserSignUpException
	{
		public InvalidEmailAddressException(string email)
			: base(email + " is not a valid e-mail address.")
		{

		}
	}

	[Serializable]
	public class ProjectException : Exception
	{
		public ProjectException(string details)
			: base("Project error! " + details)
		{

		}
	}

    [Serializable]
    public class EmptyProjectFieldException : ProjectException
    {
        public EmptyProjectFieldException(string field)
            : base(field + " field is empty.")
        {

        }
    }

    [Serializable]
	public class ProjectExistsException : ProjectException
	{
		public ProjectExistsException(string name)
			: base("Project with name " + name + " already exists.")
		{

		}
	}

	[Serializable]
	public class InvalidProjectDateException : ProjectException
	{
		public InvalidProjectDateException()
			: base("Project end date is before start date.")
		{

		}
	}

	[Serializable]
	public class InvalidMembersCountException : ProjectException
	{
		public InvalidMembersCountException()
			: base("Project must have at least one member.")
		{

		}
	}

	[Serializable]
	public class RequirementException : Exception
	{
		public RequirementException(string details)
			: base("Requirement error! " + details)
		{

		}
	}

	[Serializable]
	public class EmptyRequirementFieldException : RequirementException
	{
		public EmptyRequirementFieldException(string field)
			: base(field + " field is empty.")
		{

		}
	}

	[Serializable]
	public class TasksCountException : RequirementException
	{
		public TasksCountException()
			: base("Requirement must have at least one task.")
		{

		}
	}

	[Serializable]
	public class SprintException : Exception
	{
		public SprintException(string details)
			: base("Sprint error! " + details)
		{

		}
	}

	[Serializable]
	public class EmptySprintFieldException : SprintException
	{
		public EmptySprintFieldException(string field)
			: base(field + " field is empty.")
		{

		}
	}

	[Serializable]
	public class SprintTasksCountException : SprintException
	{
		public SprintTasksCountException()
			: base("Sprint must have at least one task.")
		{

		}
	}

	[Serializable]
	public class InvalidSprintDateException : SprintException
	{
		public InvalidSprintDateException()
			: base("Sprint end date is before start date.")
		{

		}
	}

	[Serializable]
	public class EmptyTaskDescriptionException : Exception
	{
		public EmptyTaskDescriptionException()
			: base("Task error! Description field is empty.")
		{

		}
	}
}
