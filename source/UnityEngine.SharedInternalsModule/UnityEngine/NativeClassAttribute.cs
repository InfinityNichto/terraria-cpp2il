using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	[VisibleToOtherModules]
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	internal sealed class NativeClassAttribute : Attribute
	{
		// Token: 0x17000001 RID: 1
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000205C File Offset: 0x0000025C
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		private string QualifiedNativeName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000005")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA39A0", Offset = "0x1FA39A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000205F File Offset: 0x0000025F
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		private string Declaration
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000006")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA39A8", Offset = "0x1FA39A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002062 File Offset: 0x00000262
		[global::Cpp2ILInjected.Token(Token = "0x6000007")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA39B0", Offset = "0x1FA39B0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public NativeClassAttribute(string qualifiedCppName)
		{
			throw null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002065 File Offset: 0x00000265
		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3A20", Offset = "0x1FA3A20", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NativeClassAttribute(string qualifiedCppName, string declaration)
		{
			throw null;
		}

		// Token: 0x04000003 RID: 3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <QualifiedNativeName>k__BackingField;

		// Token: 0x04000004 RID: 4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <Declaration>k__BackingField;
	}
}
