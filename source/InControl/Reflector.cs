using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000061 RID: 97
	[global::Cpp2ILInjected.Token(Token = "0x200006C")]
	public static class Reflector
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00002EEE File Offset: 0x000010EE
		[global::Cpp2ILInjected.Token(Token = "0x17000162")]
		public static IEnumerable<Type> AllAssemblyTypes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6F94", Offset = "0x19B6F94", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Reflector), Member = "GetAllAssemblyTypes", ReturnType = typeof(IEnumerable<Type>))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00002EF1 File Offset: 0x000010F1
		[global::Cpp2ILInjected.Token(Token = "0x6000500")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B71D4", Offset = "0x19B71D4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Reflector), Member = "GetAllAssemblyTypes", ReturnType = typeof(IEnumerable<Type>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IgnoreAssemblyWithName(string assemblyName)
		{
			throw null;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00002EF4 File Offset: 0x000010F4
		[global::Cpp2ILInjected.Token(Token = "0x6000501")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7014", Offset = "0x19B7014", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Reflector), Member = "get_AllAssemblyTypes", ReturnType = typeof(IEnumerable<Type>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Reflector), Member = "IgnoreAssemblyWithName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static IEnumerable<Type> GetAllAssemblyTypes()
		{
			throw null;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00002EF7 File Offset: 0x000010F7
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000502")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B727C", Offset = "0x19B727C", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		static Reflector()
		{
			throw null;
		}

		// Token: 0x040003A3 RID: 931
		[global::Cpp2ILInjected.Token(Token = "0x40003F0")]
		private static readonly string[] ignoreAssemblies;

		// Token: 0x040003A4 RID: 932
		[global::Cpp2ILInjected.Token(Token = "0x40003F1")]
		private static IEnumerable<Type> assemblyTypes;
	}
}
