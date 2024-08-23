using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000F RID: 15
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	internal class NativeMethodAttribute : Attribute
	{
		// Token: 0x1700000A RID: 10
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002098 File Offset: 0x00000298
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000019")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3D7C", Offset = "0x1FA3D7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000209B File Offset: 0x0000029B
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		public bool IsThreadSafe
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3D84", Offset = "0x1FA3D84", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000209E File Offset: 0x0000029E
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		public bool IsFreeFunction
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3D90", Offset = "0x1FA3D90", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020A1 File Offset: 0x000002A1
		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		public bool ThrowsException
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3D9C", Offset = "0x1FA3D9C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020A4 File Offset: 0x000002A4
		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		public bool HasExplicitThis
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3DA8", Offset = "0x1FA3DA8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020A7 File Offset: 0x000002A7
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3DB4", Offset = "0x1FA3DB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NativeMethodAttribute()
		{
			throw null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020AA File Offset: 0x000002AA
		[global::Cpp2ILInjected.Token(Token = "0x600001F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3DBC", Offset = "0x1FA3DBC", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativePropertyAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativePropertyAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(TargetType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FreeFunctionAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FreeFunctionAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
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
		public NativeMethodAttribute(string name)
		{
			throw null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000020AD File Offset: 0x000002AD
		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3EB8", Offset = "0x1FA3EB8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public NativeMethodAttribute(string name, bool isFreeFunction)
		{
			throw null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020B0 File Offset: 0x000002B0
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3EE0", Offset = "0x1FA3EE0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe)
		{
			throw null;
		}

		// Token: 0x0400000C RID: 12
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Name>k__BackingField;

		// Token: 0x0400000D RID: 13
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool <IsThreadSafe>k__BackingField;

		// Token: 0x0400000E RID: 14
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool <IsFreeFunction>k__BackingField;

		// Token: 0x0400000F RID: 15
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		private bool <ThrowsException>k__BackingField;

		// Token: 0x04000010 RID: 16
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B")]
		private bool <HasExplicitThis>k__BackingField;
	}
}
