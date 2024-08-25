using System;
using System.Reflection;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000168")]
	internal sealed class TypeNameParser
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000E90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79CEC", Offset = "0x1C79CEC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly>),
			typeof(global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type>),
			typeof(bool)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TypeSpec))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeSpec), Member = "Resolve", MemberParameters = new object[]
		{
			typeof(global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly>),
			typeof(global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Type))]
		internal static global::System.Type GetType(string typeName, global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly> assemblyResolver, global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type> typeResolver, bool throwOnError, bool ignoreCase, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}
	}
}
