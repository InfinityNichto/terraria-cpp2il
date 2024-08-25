using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel.Design
{
	[global::Cpp2ILInjected.Token(Token = "0x200040B")]
	public class DesigntimeLicenseContextSerializer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8BC78", Offset = "0x1E8BC78", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeLicenseContext), Member = "GetSavedLicenseKey", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Assembly)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static void Deserialize(Stream o, string cryptoKey, RuntimeLicenseContext context)
		{
			throw null;
		}
	}
}
