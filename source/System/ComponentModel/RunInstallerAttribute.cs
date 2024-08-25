using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x20003B6")]
	public class RunInstallerAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001956")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D4BC", Offset = "0x1E5D4BC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RunInstallerAttribute(bool runInstaller)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005CD")]
		public bool RunInstaller
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001957")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5D4E4", Offset = "0x1E5D4E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001958")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D4EC", Offset = "0x1E5D4EC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001959")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D594", Offset = "0x1E5D594", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600195A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D59C", Offset = "0x1E5D59C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600195B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D604", Offset = "0x1E5D604", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static RunInstallerAttribute()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <RunInstaller>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x40012C5")]
		public static readonly RunInstallerAttribute Yes;

		[global::Cpp2ILInjected.Token(Token = "0x40012C6")]
		public static readonly RunInstallerAttribute No;

		[global::Cpp2ILInjected.Token(Token = "0x40012C7")]
		public static readonly RunInstallerAttribute Default;
	}
}
