using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003BC")]
	public class RemotingSurrogateSelector : global::System.Runtime.Serialization.ISurrogateSelector
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B41350", Offset = "0x1B41350", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RemotingSurrogateSelector()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4E4CC", Offset = "0x1B4E4CC", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsMarshalByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual global::System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(global::System.Type type, global::System.Runtime.Serialization.StreamingContext context, out global::System.Runtime.Serialization.ISurrogateSelector ssout)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001E97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4E654", Offset = "0x1B4E654", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static RemotingSurrogateSelector()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F5D")]
		private static global::System.Type s_cachedTypeObjRef;

		[global::Cpp2ILInjected.Token(Token = "0x4000F5E")]
		private static ObjRefSurrogate _objRefSurrogate;

		[global::Cpp2ILInjected.Token(Token = "0x4000F5F")]
		private static RemotingSurrogate _objRemotingSurrogate;

		[global::Cpp2ILInjected.Token(Token = "0x4000F60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Runtime.Serialization.ISurrogateSelector _next;
	}
}
