using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x200041D")]
	internal sealed class TypeInformation
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000447")]
		internal string FullTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B653E0", Offset = "0x1B653E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000448")]
		internal string AssemblyString
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B653E8", Offset = "0x1B653E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000449")]
		internal bool HasTypeForwardedFrom
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B653F0", Offset = "0x1B653F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B653F8", Offset = "0x1B653F8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "GetTypeInformation", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(TypeInformation))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string fullTypeName;

		[global::Cpp2ILInjected.Token(Token = "0x4001139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string assemblyString;

		[global::Cpp2ILInjected.Token(Token = "0x400113A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool hasTypeForwardedFrom;
	}
}
