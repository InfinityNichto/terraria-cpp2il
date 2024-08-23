using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000C2 RID: 194
	[global::Cpp2ILInjected.Token(Token = "0x20000F4")]
	public class ResolveEventArgs : global::System.EventArgs
	{
		// Token: 0x06000868 RID: 2152 RVA: 0x00015DAF File Offset: 0x00013FAF
		[global::Cpp2ILInjected.Token(Token = "0x6000910")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45B00", Offset = "0x1C45B00", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "DoTypeResolve", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ResolveEventArgs(string name)
		{
			throw null;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00015DB2 File Offset: 0x00013FB2
		[global::Cpp2ILInjected.Token(Token = "0x6000911")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45B6C", Offset = "0x1C45B6C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "DoAssemblyResolve", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.Assembly),
			typeof(bool)
		}, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "DoResourceResolve", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ResolveEventArgs(string name, global::System.Reflection.Assembly requestingAssembly)
		{
			throw null;
		}

		// Token: 0x04000241 RID: 577
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000393")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Name>k__BackingField;

		// Token: 0x04000242 RID: 578
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000394")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly global::System.Reflection.Assembly <RequestingAssembly>k__BackingField;
	}
}
