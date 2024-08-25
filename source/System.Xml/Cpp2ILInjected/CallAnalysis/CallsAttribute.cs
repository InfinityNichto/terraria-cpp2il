using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		public CallsAttribute()
		{
			throw null;
		}

		public object Type;

		public string Member;

		public object[] MemberTypeParameters;

		public object[] MemberParameters;

		public object ReturnType;
	}
}
