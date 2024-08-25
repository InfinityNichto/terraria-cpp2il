using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x200038B")]
	public class InstallerTypeAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60017A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4CF48", Offset = "0x1E4CF48", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InstallerTypeAttribute(Type installerType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4CF84", Offset = "0x1E4CF84", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InstallerTypeAttribute(string typeName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000567")]
		public virtual Type InstallerType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4CFAC", Offset = "0x1E4CFAC", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D034", Offset = "0x1E4D034", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D0D4", Offset = "0x1E4D0D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400122C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _typeName;
	}
}
