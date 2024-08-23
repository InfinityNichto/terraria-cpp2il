using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Bindings
{
	// Token: 0x02000014 RID: 20
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	[VisibleToOtherModules]
	[global::Cpp2ILInjected.Token(Token = "0x2000014")]
	internal class NativeTypeAttribute : Attribute
	{
		// Token: 0x17000010 RID: 16
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000020C2 File Offset: 0x000002C2
		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		public string Header
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000027")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3F60", Offset = "0x1FA3F60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000020C5 File Offset: 0x000002C5
		[global::Cpp2ILInjected.Token(Token = "0x17000011")]
		public string IntermediateScriptingStructName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000028")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3F68", Offset = "0x1FA3F68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000020C8 File Offset: 0x000002C8
		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		public CodegenOptions CodegenOptions
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000029")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3F70", Offset = "0x1FA3F70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020CB File Offset: 0x000002CB
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3F78", Offset = "0x1FA3F78", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NativeTypeAttribute()
		{
			throw null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020CE File Offset: 0x000002CE
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3F94", Offset = "0x1FA3F94", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NativeTypeAttribute(CodegenOptions codegenOptions)
		{
			throw null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020D1 File Offset: 0x000002D1
		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3FBC", Offset = "0x1FA3FBC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public NativeTypeAttribute(string header)
		{
			throw null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000020D4 File Offset: 0x000002D4
		[global::Cpp2ILInjected.Token(Token = "0x600002D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA40BC", Offset = "0x1FA40BC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName)
		{
			throw null;
		}

		// Token: 0x04000019 RID: 25
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Header>k__BackingField;

		// Token: 0x0400001A RID: 26
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <IntermediateScriptingStructName>k__BackingField;

		// Token: 0x0400001B RID: 27
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private CodegenOptions <CodegenOptions>k__BackingField;
	}
}
