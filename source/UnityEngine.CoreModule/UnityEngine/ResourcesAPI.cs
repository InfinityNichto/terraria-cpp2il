using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x020000C4 RID: 196
	[global::Cpp2ILInjected.Token(Token = "0x20000D6")]
	public class ResourcesAPI
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0000299E File Offset: 0x00000B9E
		[global::Cpp2ILInjected.Token(Token = "0x170000E0")]
		internal static ResourcesAPI ActiveAPI
		{
			[global::Cpp2ILInjected.Token(Token = "0x600045E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F83C14", Offset = "0x1F83C14", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shader), Member = "Find", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Shader))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Resources), Member = "Load", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Type)
			}, ReturnType = typeof(Object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Type)
			}, ReturnType = typeof(ResourceRequest))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Resources), Member = "LoadAll", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Type)
			}, ReturnType = typeof(Object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Resources), Member = "UnloadAsset", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x000029A1 File Offset: 0x00000BA1
		[global::Cpp2ILInjected.Token(Token = "0x170000E1")]
		public static ResourcesAPI overrideAPI
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600045F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F83CBC", Offset = "0x1F83CBC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000029A4 File Offset: 0x00000BA4
		[global::Cpp2ILInjected.Token(Token = "0x6000460")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83D14", Offset = "0x1F83D14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected internal ResourcesAPI()
		{
			throw null;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000029A7 File Offset: 0x00000BA7
		[global::Cpp2ILInjected.Token(Token = "0x6000461")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83D1C", Offset = "0x1F83D1C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual Shader FindShaderByName(string name)
		{
			throw null;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000029AA File Offset: 0x00000BAA
		[global::Cpp2ILInjected.Token(Token = "0x6000462")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83D58", Offset = "0x1F83D58", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual Object Load(string path, Type systemTypeInstance)
		{
			throw null;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000029AD File Offset: 0x00000BAD
		[global::Cpp2ILInjected.Token(Token = "0x6000463")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83D9C", Offset = "0x1F83D9C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual Object[] LoadAll(string path, Type systemTypeInstance)
		{
			throw null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000029B0 File Offset: 0x00000BB0
		[global::Cpp2ILInjected.Token(Token = "0x6000464")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83DE0", Offset = "0x1F83DE0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected internal virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance)
		{
			throw null;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000029B3 File Offset: 0x00000BB3
		[global::Cpp2ILInjected.Token(Token = "0x6000465")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83E2C", Offset = "0x1F83E2C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual void UnloadAsset(Object assetToUnload)
		{
			throw null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000029B6 File Offset: 0x00000BB6
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000466")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83E68", Offset = "0x1F83E68", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static ResourcesAPI()
		{
			throw null;
		}

		// Token: 0x04000395 RID: 917
		[global::Cpp2ILInjected.Token(Token = "0x40003CD")]
		private static ResourcesAPI s_DefaultAPI;

		// Token: 0x04000396 RID: 918
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40003CE")]
		private static ResourcesAPI <overrideAPI>k__BackingField;
	}
}
