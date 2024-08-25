using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20003E7")]
	public sealed class OptionalFieldAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001F8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59A94", Offset = "0x1B59A94", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public OptionalFieldAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000434")]
		public int VersionAdded
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B59AA4", Offset = "0x1B59AA4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000FC8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int versionAdded;
	}
}
