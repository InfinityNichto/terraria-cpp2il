using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x20000D6")]
	public class ResourcesAPI
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000460")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83D14", Offset = "0x1F83D14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected internal ResourcesAPI()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000461")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83D1C", Offset = "0x1F83D1C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual Shader FindShaderByName(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000462")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83D58", Offset = "0x1F83D58", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual Object Load(string path, Type systemTypeInstance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000463")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83D9C", Offset = "0x1F83D9C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual Object[] LoadAll(string path, Type systemTypeInstance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000464")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83DE0", Offset = "0x1F83DE0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected internal virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000465")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83E2C", Offset = "0x1F83E2C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual void UnloadAsset(Object assetToUnload)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40003CD")]
		private static ResourcesAPI s_DefaultAPI;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40003CE")]
		private static ResourcesAPI <overrideAPI>k__BackingField;
	}
}
