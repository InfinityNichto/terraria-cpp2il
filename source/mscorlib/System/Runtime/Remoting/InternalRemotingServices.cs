using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x020002A3 RID: 675
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000341")]
	public class InternalRemotingServices
	{
		// Token: 0x060019AF RID: 6575 RVA: 0x00018D25 File Offset: 0x00016F25
		[global::Cpp2ILInjected.Token(Token = "0x6001BD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B25110", Offset = "0x1B25110", Length = "0x4EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "GetXmlElementForInteropType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "GetXmlTypeForInteropType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Metadata.SoapTypeAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Metadata.SoapFieldAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Metadata.SoapMethodAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Metadata.SoapParameterAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public static global::System.Runtime.Remoting.Metadata.SoapAttribute GetCachedSoapAttribute(object reflectionObject)
		{
			throw null;
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00018D28 File Offset: 0x00016F28
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001BD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B255FC", Offset = "0x1B255FC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static InternalRemotingServices()
		{
			throw null;
		}

		// Token: 0x04000B49 RID: 2889
		[global::Cpp2ILInjected.Token(Token = "0x4000E29")]
		private static global::System.Collections.Hashtable _soapAttributes;
	}
}
