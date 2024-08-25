using System;

namespace Cpp2ILInjected.CallAnalysis
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CalledByAttribute : global::System.Attribute
	{
		public CalledByAttribute()
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
